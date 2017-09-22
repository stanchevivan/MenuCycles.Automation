using MenuCycles.AutomatedTests.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCyclesData.DatabaseDataModel;
using MenuCyclesData;


namespace MenuCycles.AutomatedTests.Steps
{
    [Binding]
    public sealed class SearchRecipeSteps
    {
        private MenuCycleCalendarView menuCycleCalendarView;
        private CreateMealPeriod createMealPeriod;
        private RecipeSearch recipeSearch;
        private ToastNotification notification;
        private ScenarioContext scenarioContext;
        private Seeding seeding;

        public SearchRecipeSteps(ScenarioContext scenarioContext, Seeding seeding, MenuCycleCalendarView menuCycleCalendarView, 
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
            this.seeding = seeding;
        }

        [When(@"a Meal Period for (.*) is added")]
        public void GivenAMealPeriodForIsAddedToAMenuCycle(string weekDayName)
        {
            menuCycleCalendarView.AddMealPeriod(weekDayName);
            createMealPeriod.SelectMealPeriod(scenarioContext.Get<List<MealPeriod>>().First().Name);
        }


        [When(@"the first recipe is searched by name")]
        public void WhenTheFirstRecipeIsSearchedByName()
        {
            createMealPeriod.AddRecipe();
            recipeSearch.SearchRecipeByName(scenarioContext.Get<List<Recipe>>().First().Name);
        }

        [When(@"recipe is added to a meal period")]
        public void WhenRecipeIsAddedToAMealPeriod()
        {
            recipeSearch.AddRecipe(scenarioContext.Get<List<Recipe>>().First().Name);
            createMealPeriod.SaveAndCloseMealPeriod();
        }

        [Then(@"recipe is displayed under (.*) column inside the correct Meal Period")]
        public void ThenRecipeIsDiplayedUnderColumnInsideTheCorrectMealPeriod(string weekDayName)
        {
            menuCycleCalendarView.ValidateMealPeriod(weekDayName, scenarioContext.Get<List<MealPeriod>>().First(), scenarioContext.Get<List<Recipe>>());
        }

        //[When(@"a test is made for (.*)")]
        //public void WhenATestIsMade(string weekDay)
        //{
        //    var mc = scenarioContext.Get<List<MenuCycle>>()[0];
        //    menuCycleDashboard.SelectMenuCycleByName(mc.Name);
        //    menuCycleCalendarView.AddMealPeriod(weekDay);

        //    var mp = scenarioContext.Get<MealPeriod>();
        //    createMealPeriod.SelectMealPeriod(mp.Name);
        //    createMealPeriod.AddRecipe();

        //    var recipe = scenarioContext.Get<List<Recipe>>();
        //    recipeSearch.SearchRecipeByName(recipe[0].Name);

        //    createMealPeriod.SaveMealPeriod();
        //    notification.ValidateToastMessage("Meal Period Saved successfully");
        //    createMealPeriod.CloseMealPeriod();

        //    menuCycleCalendarView.ValidateMealPeriod(weekDay, mp, recipe);
        //}
    }
}
