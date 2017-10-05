using System;
using System.Collections.Generic;
using MenuCycle.Data.Models;
using System.Linq;

namespace MenuCycle.Data.Repositories
{
    public class MenuCycleRepository : IRepository<MenuCycles>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public MenuCycleRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }
        public void SingleInsert(MenuCycles item)
        {
            dbContext.MenuCycles.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<MenuCycles> list)
        {
            dbContext.MenuCycles.AddRange(list);
            dbContext.SaveChanges();
        }

        public MenuCycles FindByName(string name)
        {
            return dbContext.MenuCycles.FirstOrDefault(m => m.Name == name);
        }

        public MenuCycles FindById(int id)
        {
            return dbContext.MenuCycles.FirstOrDefault(m => m.MenuCycleId == id);
        }

        public void DeleteAll(IList<MenuCycles> menuCycleList)
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
