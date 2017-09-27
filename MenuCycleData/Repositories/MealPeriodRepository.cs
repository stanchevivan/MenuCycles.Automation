using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class MealPeriodRepository : IRepository<MealPeriod>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public MealPeriodRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }
        public void SingleInsert(MealPeriod item)
        {
            dbContext.MealPeriods.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(List<MealPeriod> list)
        {
            dbContext.MealPeriods.AddRange(list);
            dbContext.SaveChanges();
        }

        public MealPeriod FindByName(string name)
        {
            return dbContext.MealPeriods.FirstOrDefault(m => m.Name == name);
        }

        public MealPeriod FindById(int id)
        {
            return dbContext.MealPeriods.FirstOrDefault(m => m.MealPeriodId == id);
        }

        public void DeleteAll(IList<MealPeriod> list)
        {
            dbContext.MealPeriods.RemoveRange(list);
            dbContext.SaveChanges();
        }
    }
}
