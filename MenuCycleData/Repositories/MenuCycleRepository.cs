using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class MenuCycleRepository : IRepository<MenuCycle>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public MenuCycleRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }
        public void SingleInsert(MenuCycle item)
        {
            dbContext.MenuCycles.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<MenuCycle> list)
        {
            dbContext.MenuCycles.AddRange(list);
            dbContext.SaveChanges();
        }

        public MenuCycle FindByName(string name)
        {
            return dbContext.MenuCycles.FirstOrDefault(m => m.Name == name);
        }

        public MenuCycle FindById(int id)
        {
            return dbContext.MenuCycles.FirstOrDefault(m => m.MenuCycleId == id);
        }

        public void DeleteAll(IList<MenuCycle> menuCycleList)
        {
            foreach (var item in menuCycleList)
            {
                var menuCycle = (item.MenuCycleId == 0) ? FindByName(item.Name) : FindById(Convert.ToInt32(item.MenuCycleId));
                dbContext.MenuCycles.Remove(menuCycle);
            }
            dbContext.SaveChanges();
        }
    }
}
