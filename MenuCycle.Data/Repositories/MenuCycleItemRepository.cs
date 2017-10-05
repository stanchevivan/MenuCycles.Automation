using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class MenuCycleItemRepository : IRepository<MenuCycleItems>
    {
        private MenuServiceSodexoQAIContext dbContext;
        public MenuCycleItemRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }
        public void SingleInsert(MenuCycleItems item)
        {
            dbContext.MenuCycleItems.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<MenuCycleItems> list)
        {
            dbContext.MenuCycleItems.AddRange(list);
            dbContext.SaveChanges();
        }

        public MenuCycleItems FindByName(string name)
        {
            return null;
        }

        public MenuCycleItems FindById(int id)
        {
            return dbContext.MenuCycleItems.FirstOrDefault(m => m.MealPeriodId == id);
        }

        public void DeleteAll(IList<MenuCycleItems> list)
        {
            dbContext.MenuCycleItems.RemoveRange(list);
            dbContext.SaveChanges();
        }

        public void DeleteAllByMenuCycle(IList<MenuCycles> menuCycles)
        {
            foreach (var item in menuCycles)
            {
                var menuCycleItems = FindByMenuCycleId(item);
                dbContext.MenuCycleItems.RemoveRange(menuCycleItems);
            }
            dbContext.SaveChanges();
        }
        public IList<MenuCycleItems> FindByMenuCycleId(MenuCycles menuCycle)
        {
            var query = from mi in dbContext.MenuCycleItems
                        join r in dbContext.MenuCycles
                        on mi.MenuCycleId equals r.MenuCycleId
                        where mi.MenuCycleId == menuCycle.MenuCycleId
                        select mi;

            return query.ToList();
        }
    }
}
