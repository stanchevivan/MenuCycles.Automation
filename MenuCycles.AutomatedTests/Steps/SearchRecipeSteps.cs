using MenuCycles.AutomatedTests.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCycleData;


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
        
        public SearchRecipeSteps(ScenarioContext scenarioContext, MenuCycleCalendarView menuCycleCalendarView, 
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [Given(@"a Meal Period for (.*) is added")]
        public void GivenAMealPeriodForIsAddedToAMenuCycle(string weekDayName)
        {
            menuCycleCalendarView.AddMealPeriod(weekDayName);
            createMealPeriod.SelectMealPeriod(scenarioContext.Get<IList<MealPeriod>>().First().Name);
        }


        [When(@"the first recipe is searched by name")]
        public void WhenTheFirstRecipeIsSearchedByName()
        {
            createMealPeriod.AddRecipe();
            recipeSearch.SearchRecipeByName(scenarioContext.Get<IList<Recipe>>().First().Name);
        }

        [When(@"recipe is added to a meal period")]
        public void WhenRecipeIsAddedToAMealPeriod()
        {
            recipeSearch.AddRecipe(scenarioContext.Get<IList<Recipe>>().First().Name);
            createMealPeriod.SaveAndCloseMealPeriod();
        }

        [Then(@"recipe is displayed under (.*) column inside the correct Meal Period")]
        public void ThenRecipeIsDiplayedUnderColumnInsideTheCorrectMealPeriod(string weekDayName)
        {
            menuCycleCalendarView.ValidateMealPeriod(weekDayName, scenarioContext.Get<IList<MealPeriod>>().First(), scenarioContext.Get<IList<Recipe>>());
        }
    }
}
