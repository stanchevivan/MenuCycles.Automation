using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class RecipeRepository : IRepository<Recipe>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public RecipeRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }

        public void SingleInsert(Recipe item)
        {
            dbContext.Recipes.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<Recipe> list)
        {
            dbContext.Recipes.AddRange(list);
            dbContext.SaveChanges();
        }

        public Recipe FindByName(string name)
        {
            return dbContext.Recipes.FirstOrDefault(m => m.Name == name);
        }

        public Recipe FindById(int id)
        {
            return dbContext.Recipes.FirstOrDefault(m => m.RecipeId == id);
        }

        public void DeleteAll(IList<Recipe> list)
        {
            dbContext.Recipes.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
