using MenuCycles.AutomatedTests.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using MenuCycleData;
using MenuCycleData.Services;

namespace MenuCycles.AutomatedTests.Steps
{
    [Binding]
    public sealed class SeedSteps
    {
        private ScenarioContext scenarioContext;
        private readonly RecipeService recipeService;
        private readonly MealPeriodService mealPeriodService;
        private readonly MenuCycleService menuCycleService;

        public SeedSteps(ScenarioContext scenarioContext, RecipeService recipeService, MealPeriodService mealPeriodService, MenuCycleService menuCycleService)
        {
            this.scenarioContext = scenarioContext;
            this.recipeService = recipeService;
            this.menuCycleService = menuCycleService;
            this.mealPeriodService = mealPeriodService;
        }

        [Given(@"(.*) Menu Cycles exists")]
        public void GivenMenuCyclesWithMealPeriodExists(int menuCyclesQuantity)
        {
            this.scenarioContext.Set(this.menuCycleService.CreateMenuCycle(menuCyclesQuantity));
        }

        [Given(@"(.*) Meal Period exists")]
        public void GivenMealPeriodExists(int mealPeriodQuantity)
        {
            this.scenarioContext.Set(this.mealPeriodService.CreateMealPeriod(mealPeriodQuantity));
        }


        [Given(@"(.*) recipes exists")]
        public void GivenRecipesExists(int recipeQuantity)
        {
            this.scenarioContext.Set(this.recipeService.CreateRecipe(recipeQuantity));
        }
    }
}
