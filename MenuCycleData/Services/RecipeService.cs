using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycleData.Generators;
using MenuCycleData.Repositories;

namespace MenuCycleData.Services
{
    public class RecipeService
    {
        private readonly RecipeGenerator recipeGenerator;
        private readonly RecipeRepository recipeRepository;
        private readonly RelationshipsRepository relationshipsRepository;
        private readonly DefaultValues defaultValues;

        public RecipeService(RecipeGenerator recipeGenerator, RecipeRepository recipeRepository, 
            RelationshipsRepository relationshipsRepository, DefaultValues defaultValues)
        {
            this.recipeGenerator = recipeGenerator;
            this.recipeRepository = recipeRepository;
            this.relationshipsRepository = relationshipsRepository;
            this.defaultValues = defaultValues;
        }

        public IList<Recipe> CreateRecipe(int count)
        {
            var recipes = this.recipeGenerator.Generate(count, defaultValues.Customer.CustomerId);

            this.recipeRepository.BulkInsert(recipes.ToList());

            foreach (var item in recipes)
            {
                this.relationshipsRepository.InsertGroupRecipe(new GroupRecipe()
                {
                    RecipeId = item.RecipeId,
                    GroupId = this.defaultValues.Group.GroupId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = this.defaultValues.User.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = this.defaultValues.User.ExternalId
                });
            }

            return recipes;
        }

        public void DeleteRecipe(IList<Recipe> list)
        {
            this.relationshipsRepository.DeleteGroupRecipe(list);
            this.recipeRepository.DeleteAll(list);
        }
    }
}