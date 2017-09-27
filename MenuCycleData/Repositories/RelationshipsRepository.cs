using System;
using System.Collections.Generic;
using System.Linq;


namespace MenuCycleData.Repositories
{
    public class RelationshipsRepository
    {
        private MenuServiceSodexoQAIEntities dbContext;
        public RelationshipsRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIEntities();
        }
        public void InsertMenuCycleGroup(MenuCycleGroup item)
        {
            dbContext.MenuCycleGroups.Add(item);
            dbContext.SaveChanges();
        }

        public void InsertGroupRecipe(GroupRecipe item)
        {
            dbContext.GroupRecipes.Add(item);
            dbContext.SaveChanges();
        }

        public IList<MenuCycleGroup> FindMenuCycleGroupByMenuCycleId(MenuCycle menuCycle)
        {
            var query = from mg in dbContext.MenuCycleGroups
                        join m in dbContext.MenuCycles
                        on mg.MenuCycleId equals m.MenuCycleId
                        where mg.MenuCycleId == menuCycle.MenuCycleId
                        select mg;

            return query.ToList(); 
        }

        public IList<GroupRecipe> FindGroupRecipesByRecipeId(Recipe recipe)
        {
            var query = from gp in dbContext.GroupRecipes
                        join r in dbContext.Recipes
                        on gp.RecipeId equals r.RecipeId
                        where gp.RecipeId == recipe.RecipeId
                        select gp;

            return query.ToList();
        }

        public void DeleteMenuCycleGroup(IList<MenuCycle> menuCycles)
        {
            foreach (var item in menuCycles)
            {
                var menuCycleGroups = FindMenuCycleGroupByMenuCycleId(item);
                dbContext.MenuCycleGroups.RemoveRange(menuCycleGroups);
            }
            dbContext.SaveChanges();
        }

        public void DeleteGroupRecipe(IList<Recipe> recipes)
        {
            foreach (var item in recipes)
            {
                var groupRecipe = FindGroupRecipesByRecipeId(item);
                dbContext.GroupRecipes.RemoveRange(groupRecipe);
            }
            dbContext.SaveChanges();
        }
    }
}
