using MenuCycles.AutomatedTests.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCyclesData.DatabaseDataModel;
using MenuCyclesData;

namespace MenuCycles.AutomatedTests.Steps
{
    [Binding]
    public sealed class SeedSteps
    {
        private ScenarioContext scenarioContext;
        private Seeding seeding;

        public SeedSteps(ScenarioContext scenarioContext, Seeding seeding)
        {
            this.scenarioContext = scenarioContext;
            this.seeding = seeding;
        }

        [Given(@"(.*) Menu Cycles exists")]
        public void GivenMenuCyclesWithMealPeriodExists(int menuCyclesQuantity)
        {
            scenarioContext.Set(seeding.RandomMenuCycles(menuCyclesQuantity));
        }

        [Given(@"(.*) Meal Period exists")]
        public void GivenMealPeriodExists(int mealPeriodQuantity)
        {
            scenarioContext.Set(seeding.RandomMealPeriods(mealPeriodQuantity));
        }


        [Given(@"(.*) recipes exists")]
        public void GivenRecipesExists(int recipeQuantity)
        {
            scenarioContext.Set(seeding.RandomRecipe(recipeQuantity));
        }


    }
}
