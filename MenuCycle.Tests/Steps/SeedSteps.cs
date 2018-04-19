using TechTalk.SpecFlow;
using MenuCycle.Data.Services;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public sealed class SeedSteps
    {
        readonly ScenarioContext scenarioContext;
        readonly RecipeService recipeService;
        readonly MealPeriodService mealPeriodService;
        readonly MenuCycleService menuCycleService;

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
