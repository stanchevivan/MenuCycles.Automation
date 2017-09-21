using MenuCycles.AutomatedTests.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCyclesData.DatabaseDataModel;
using MenuCyclesData;

namespace MenuCycles.AutomatedTests.Steps
{
    [Binding]
    public sealed class MenuCycleSteps
    {
        private EngageDashboard engageDashboard;
        private LogInAs logInAs;
        private MenuCyclesDashboard menuCycleDashboard;
        private CreateMenuCycle createMenuCycle;
        private MenuCycleCalendarView menuCycleCalendarView;
        private CreateMealPeriod createMealPeriod;
        private RecipeSearch recipeSearch;
        private ScenarioContext scenarioContext;
        private Seeding seeding;

        public MenuCycleSteps(ScenarioContext scenarioContext, Seeding seeding, EngageDashboard engageDashboard, LogInAs logInAs,
            MenuCyclesDashboard menuCycleDashboard, CreateMenuCycle createMenuCycle, MenuCycleCalendarView menuCycleCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch)
        {
            this.engageDashboard = engageDashboard;
            this.logInAs = logInAs;
            this.menuCycleDashboard = menuCycleDashboard;
            this.createMenuCycle = createMenuCycle;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;

            this.scenarioContext = scenarioContext;
            this.seeding = seeding;
        }

        [Given(@"the Menu Cycles Dashboard is open as a (.*) user")]
        public void GivenTheMenuCycleDashboardIsOpen(string userType)
        {
            logInAs.LogAs(userType);
        }

        [When(@"a Menu Cycle with the following data is created")]
        public void WhenAMenuCycleWithTheFollowingDataIsCreated(MenuCycle menuCycle)
        {
            scenarioContext.Set(menuCycle);
            menuCycleDashboard.CreateMenuCycleClick();
            createMenuCycle.Create(menuCycle);
        }

        [Then(@"the message '(.*)' is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            createMenuCycle.ValidateToastMessage(message);
        }

        [Then(@"the calendar view is opened")]
        public void ThenTheCalendardViewIsOpened()
        {
            menuCycleCalendarView.ValidateWindow(scenarioContext.Get<MenuCycle>().Name);
        }

        [Given(@"a Menu Cycle with the following data exists")]
        public void GivenAMenuCycleWithTheFollowingDataExists(List<MenuCycle> menuCyclesList)
        {
            scenarioContext.Set(seeding.MenuCycles(menuCyclesList));
        }

        [Given(@"data exists")]
        public void GivenDataExists()
        {
            scenarioContext.Set(seeding.RandomMenuCycles(1));
            scenarioContext.Set(seeding.RandomRecipe(1));

            scenarioContext.Set(new MealPeriod()
            {
                Name = "LUNCH",
            });
        }


        [When(@"a test is made for (.*)")]
        public void WhenATestIsMade(string weekDay)
        {
            var mc = scenarioContext.Get<List<MenuCycle>>()[0];
            menuCycleDashboard.SelectMenuCycleByName(mc.Name);
            menuCycleCalendarView.AddMealPeriod(weekDay);

            var mp = scenarioContext.Get<MealPeriod>();
            createMealPeriod.SelectMealPeriod(mp.Name);
            createMealPeriod.AddRecipe();

            var recipe = scenarioContext.Get<List<Recipe>>();
            recipeSearch.SearchRecipeByName(recipe[0].Name);

            createMealPeriod.SaveMealPeriod();
            createMenuCycle.ValidateToastMessage("Meal Period Saved successfully");
            createMealPeriod.CloseMealPeriod();

            menuCycleCalendarView.ValidateMealPeriod(weekDay, mp, recipe);
        }
    }
}
