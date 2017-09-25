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

        public RecipeService(RecipeGenerator recipeGenerator, RecipeRepository recipeRepository, RelationshipsRepository relationshipsRepository)
        {
            this.recipeGenerator = recipeGenerator;
            this.recipeRepository = recipeRepository;
            this.relationshipsRepository = relationshipsRepository;
        }

        public IList<Recipe> CreateRecipe(User user, Customer customer, long groupId, int count)
        {
            var recipes = this.recipeGenerator.Generate(count, customer.CustomerId);

            this.recipeRepository.BulkInsert(recipes.ToList());

            foreach (var item in recipes)
            {
                this.relationshipsRepository.InsertGroupRecipe(new GroupRecipe()
                {
                    RecipeId = item.RecipeId,
                    GroupId = groupId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = user.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = user.ExternalId
                });
            }

            return recipes;
        }
    }
}