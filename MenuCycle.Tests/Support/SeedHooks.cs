using TechTalk.SpecFlow;
using System.Collections.Generic;
using MenuCycle.Data;
using MenuCycle.Data.Services;
using MenuCycle.Data.Models;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public sealed class SeedHooks
    {
        private ScenarioContext scenarioContext;
        private readonly RecipeService recipeService;
        private readonly MealPeriodService mealPeriodService;
        private readonly MenuCycleService menuCycleService;

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

