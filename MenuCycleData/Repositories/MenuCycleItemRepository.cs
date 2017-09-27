using System.Collections.Generic;
using System.Linq;

namespace MenuCycleData.Repositories
{
    public class MenuCycleItemRepository : IRepository<MenuCycleItem>
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public MenuCycleItemRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }
        public void SingleInsert(MenuCycleItem item)
        {
            dbContext.MenuCycleItems.Add(item);
            dbContext.SaveChanges();
        }

        public void BulkInsert(IList<MenuCycleItem> list)
        {
            dbContext.MenuCycleItems.AddRange(list);
            dbContext.SaveChanges();
        }

        public MenuCycleItem FindByName(string name)
        {
            return null;
        }

        public MenuCycleItem FindById(int id)
        {
            return dbContext.MenuCycleItems.FirstOrDefault(m => m.MealPeriodId == id);
        }

        public void DeleteAll(IList<MenuCycleItem> list)
        {
            dbContext.MenuCycleItems.RemoveRange(list);
            dbContext.SaveChanges();
        }

        public void DeleteAllByMenuCycle(IList<MenuCycle> menuCycles)
        {
            foreach (var item in menuCycles)
            {
                var menuCycleItems = FindByMenuCycleId(item);
                dbContext.MenuCycleItems.RemoveRange(menuCycleItems);
            }
            dbContext.SaveChanges();
        }
        public IList<MenuCycleItem> FindByMenuCycleId(MenuCycle menuCycle)
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
