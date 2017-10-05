using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Repositories
{
    public class RelationshipsRepository
    {
        private MenuServiceSodexoQAIContext dbContext;
        public RelationshipsRepository()
        {
            this.dbContext = new MenuServiceSodexoQAIContext();
        }
        public void InsertMenuCycleGroup(MenuCycleGroups item)
        {
            dbContext.MenuCycleGroups.Add(item);
            dbContext.SaveChanges();
        }

        public void InsertGroupRecipe(GroupRecipes item)
        {
            dbContext.GroupRecipes.Add(item);
            dbContext.SaveChanges();
        }

        public IList<MenuCycleGroups> FindMenuCycleGroupByMenuCycleId(MenuCycles menuCycle)
        {
            var query = from mg in dbContext.MenuCycleGroups
                        join m in dbContext.MenuCycles
                        on mg.MenuCycleId equals m.MenuCycleId
                        where mg.MenuCycleId == menuCycle.MenuCycleId
                        select mg;

            return query.ToList(); 
        }

        public IList<GroupRecipes> FindGroupRecipesByRecipeId(Recipes recipe)
        {
            var query = from gp in dbContext.GroupRecipes
                        join r in dbContext.Recipes
                        on gp.RecipeId equals r.RecipeId
                        where gp.RecipeId == recipe.RecipeId
                        select gp;

            return query.ToList();
        }

        public void DeleteMenuCycleGroup(IList<MenuCycles> menuCycles)
        {
            foreach (var item in menuCycles)
            {
                var menuCycleGroups = FindMenuCycleGroupByMenuCycleId(item);
                dbContext.MenuCycleGroups.RemoveRange(menuCycleGroups);
            }
            dbContext.SaveChanges();
        }

        public void DeleteGroupRecipe(IList<Recipes> recipes)
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
