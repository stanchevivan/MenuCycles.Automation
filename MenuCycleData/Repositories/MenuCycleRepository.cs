using System.Collections.Generic;
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

        public void BulkInsert(List<MenuCycle> list)
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

        public void DeleteAll(List<MenuCycle> menuCycleList)
        {
            //Gets all from the list that has id = 0, finds it and update list in order to proper delete.
            menuCycleList.Where(l => l.MenuCycleId == 0).ToList().ForEach(l => l.MenuCycleId = FindByName(l.Name).MenuCycleId);

            dbContext.MenuCycleItems.Remove();
            dbContext.MenuCycles.RemoveRange(menuCycleList);
            dbContext.SaveChanges();
        }

        public void CleanTestData()
        {
            //dbContext.MenuCycles.Remove(FindByName());
            //dbContext.SaveChanges();

            //this.db.Execute("DELETE FROM MenuCycleItems Where MenuCycleId In (SELECT MenuCycleId FROM MenuCycles WHERE NAME LIKE 'Ico %')");
            //this.db.Execute("DELETE FROM MenuCycleGroups Where MenuCycleId In (SELECT MenuCycleId FROM MenuCycles WHERE NAME LIKE 'Ico %')");
            //this.db.Execute("DELETE FROM MenuCycles Where MenuCycleId In (SELECT MenuCycleId FROM MenuCycles WHERE NAME LIKE 'Ico %')");
            //this.db.Execute("DELETE FROM GroupRecipes WHERE RecipeId IN (SELECT RecipeId FROM Recipes  WHERE NAME LIKE 'Ico %')");
            //this.db.Execute("DELETE FROM Recipes WHERE RecipeId IN (SELECT RecipeId FROM Recipes  WHERE NAME LIKE 'Ico %')");
            //this.db.Execute("DELETE FROM MealPeriods WHERE MealPeriodId IN (SELECT MealPeriodId FROM MealPeriods WHERE NAME LIKE 'Ico %')");
        }
    }
}
