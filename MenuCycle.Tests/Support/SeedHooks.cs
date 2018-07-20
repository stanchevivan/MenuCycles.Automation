using TechTalk.SpecFlow;
using System.Collections.Generic;
using MenuCycle.Data;
using MenuCycle.Data.Services;
using MenuCycle.Data.Models;

namespace MenuCycle.Tests.Support
{
    //[Binding]
    public sealed class SeedHooks
    {
        readonly ScenarioContext scenarioContext;
        readonly RecipeService recipeService;
        readonly MealPeriodService mealPeriodService;
        readonly MenuCycleService menuCycleService;

        public SeedHooks(ScenarioContext scenarioContext, RecipeService recipeService, 
            MealPeriodService mealPeriodService, MenuCycleService menuCycleService)
        {
            this.scenarioContext = scenarioContext;
            this.recipeService = recipeService;
            this.menuCycleService = menuCycleService;
            this.mealPeriodService = mealPeriodService;
        }

        [AfterScenario]
        [Scope(Tag = "menucycle")]
        public void DeleteMenuCycleAfterScenario()
        {
            this.menuCycleService.DeleteMenuCycle(this.scenarioContext.Get<IList<MenuCycles>>());
        }

        [AfterScenario]
        [Scope(Tag = "mealperiod")]
        public void DeleteMealPeriodAfterScenario()
        {
            this.mealPeriodService.DeleteMealPeriod(this.scenarioContext.Get<IList<MealPeriods>>());
        }

        [AfterScenario]
        [Scope(Tag = "recipe")]
        public void DeleteRecipeAfterScenario()
        {
            this.recipeService.DeleteRecipe(this.scenarioContext.Get<IList<Recipes>>());
        }
    }
}

