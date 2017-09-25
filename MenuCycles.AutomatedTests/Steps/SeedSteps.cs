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
        private Seeding seeding;
        private readonly RecipeService recipeService;
        private readonly DefaultValues defaultValues;

        public SeedSteps(ScenarioContext scenarioContext, Seeding seeding, RecipeService recipeService, DefaultValues defaultValues)
        {
            this.scenarioContext = scenarioContext;
            this.seeding = seeding;
            this.recipeService = recipeService;

            this.defaultValues = defaultValues;
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
            ////scenarioContext.Set(seeding.RandomRecipe(recipeQuantity));
            this.scenarioContext.Set(

                this.recipeService.CreateRecipe(
                    this.defaultValues.User, 
                    this.defaultValues.Customer,
                    this.defaultValues.Group.GroupId,
                    recipeQuantity));
        }


    }
}
