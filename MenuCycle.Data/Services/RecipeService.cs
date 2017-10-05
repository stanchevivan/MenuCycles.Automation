using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Generators;
using MenuCycle.Data.Repositories;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Services
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

        public IList<Recipes> CreateRecipe(int count)
        {
            var recipes = this.recipeGenerator.Generate(count, defaultValues.Customer.CustomerId);

            this.recipeRepository.BulkInsert(recipes.ToList());

            foreach (var item in recipes)
            {
                this.relationshipsRepository.InsertGroupRecipe(new GroupRecipes()
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

        public void DeleteRecipe(IList<Recipes> list)
        {
            this.relationshipsRepository.DeleteGroupRecipe(list);
            this.recipeRepository.DeleteAll(list);
        }
    }
}