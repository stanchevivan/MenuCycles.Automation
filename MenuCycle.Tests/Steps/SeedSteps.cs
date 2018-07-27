using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public sealed class SeedSteps
    {
        readonly ScenarioContext scenarioContext;

        public SeedSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"(.*) Menu Cycles exists")]
        public void GivenMenuCyclesWithMealPeriodExists(int menuCyclesQuantity)
        {
        }

        [Given(@"(.*) Meal Period exists")]
        public void GivenMealPeriodExists(int mealPeriodQuantity)
        {
        }


        [Given(@"(.*) recipes exists")]
        public void GivenRecipesExists(int recipeQuantity)
        {
        }
    }
}
