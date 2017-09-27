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

        public void BulkInsert(List<MenuCycleItem> list)
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
    }
}
