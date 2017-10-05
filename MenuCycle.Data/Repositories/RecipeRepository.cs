using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class RecipeRepository : IRepository<Recipes>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public RecipeRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }

        public void SingleInsert(Recipes item)
        {
            dbContext.Recipes.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<Recipes> list)
        {
            dbContext.Recipes.AddRange(list);
            dbContext.SaveChanges();
        }

        public Recipes FindByName(string name)
        {
            return dbContext.Recipes.FirstOrDefault(m => m.Name == name);
        }

        public Recipes FindById(int id)
        {
            return dbContext.Recipes.FirstOrDefault(m => m.RecipeId == id);
        }

        public void DeleteAll(IList<Recipes> list)
        {
            dbContext.Recipes.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
