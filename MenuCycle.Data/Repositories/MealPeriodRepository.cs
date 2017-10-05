using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class MealPeriodRepository : IRepository<MealPeriods>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public MealPeriodRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }
        public void SingleInsert(MealPeriods item)
        {
            dbContext.MealPeriods.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<MealPeriods> list)
        {
            dbContext.MealPeriods.AddRange(list);
            dbContext.SaveChanges();
        }

        public MealPeriods FindByName(string name)
        {
            return dbContext.MealPeriods.FirstOrDefault(m => m.Name == name);
        }

        public MealPeriods FindById(int id)
        {
            return dbContext.MealPeriods.FirstOrDefault(m => m.MealPeriodId == id);
        }

        public void DeleteAll(IList<MealPeriods> list)
        {
            dbContext.MealPeriods.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
