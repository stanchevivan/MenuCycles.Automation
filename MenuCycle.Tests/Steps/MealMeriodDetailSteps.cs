
using MenuCycle.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class MealMeriodDetailSteps
    {
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly MealPeriodDetails mealPeriodDetails;
        readonly RecipeSearch recipeSearch;

        public MealMeriodDetailSteps(ScenarioContext scenarioContext, MenuCycleCalendarView menuCycleCalendarView,
                                     ToastNotification notification, MealPeriodDetails mealPeriodDetails,
                                     RecipeSearch recipeSearch)
        {
            this.scenarioContext = scenarioContext;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.notification = notification;
            this.mealPeriodDetails = mealPeriodDetails;
            this.recipeSearch = recipeSearch;
        }

        [When(@"Details for meal period ""(.*)"" in ""(.*)"" are opened")]
        public void WhenDetailsForMealPeriodInAreOpened(string mealPeriod, string weekDay)
        {
            menuCycleCalendarView.GetDay(weekDay).GetMealPeriodCard(mealPeriod).OpenMealPeriodDetails();
            mealPeriodDetails.WaitForLoad();
        }

        [When(@"Recipe search is opened")]
        public void WhenRecipeSearchIsOpened()
        {
            mealPeriodDetails.AddRecipe();
        }

        [When(@"Recipe ""(.*)"" is searched")]
        public void RecipeIsSearched(string text)
        {
            recipeSearch.SearchRecipeByName(text);
        }

        [When(@"Recipe ""(.*)"" is added")]
        public void RecipeIsAdded(string text)
        {
            recipeSearch.AddRecipe(text);
        }
    }
}