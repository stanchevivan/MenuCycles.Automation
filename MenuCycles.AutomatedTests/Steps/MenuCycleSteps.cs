using MenuCycles.AutomatedTests.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCycleData;

namespace MenuCycles.AutomatedTests.Steps
{
    [Binding]
    public sealed class MenuCycleSteps
    {
        private LogInAs logInAs;
        private MenuCyclesDashboard menuCycleDashboard;
        private CreateMenuCycle createMenuCycle;
        private MenuCycleCalendarView menuCycleCalendarView;
        private CreateMealPeriod createMealPeriod;
        private RecipeSearch recipeSearch;
        private ToastNotification notification;
        private ScenarioContext scenarioContext;
        private Seeding seeding;

        public MenuCycleSteps(ScenarioContext scenarioContext, Seeding seeding, LogInAs logInAs,
            MenuCyclesDashboard menuCycleDashboard, CreateMenuCycle createMenuCycle, MenuCycleCalendarView menuCycleCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.logInAs = logInAs;
            this.menuCycleDashboard = menuCycleDashboard;
            this.createMenuCycle = createMenuCycle;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
            this.seeding = seeding;
        }

        [Given(@"a (.*) user is selected")]
        public void GivenAUserIsSelected(string userType)
        {
            logInAs.LogAs(userType);
        }

        [Given(@"a Menu Cycle is selected")]
        public void GivenAMenuCycleIsSelected()
        {
            menuCycleDashboard.SelectMenuCycleByName(scenarioContext.Get<List<MenuCycle>>().First().Name);
        }

        [When(@"a Menu Cycle with the following criteria is create")]
        public void WhenAMenuCycleWithTheFollowingDataIsCreated(List<MenuCycle> menuCycles)
        {
            menuCycleDashboard.CreateMenuCycleClick();

            Group group = scenarioContext.Get<List<Group>>().First();
            MenuCycle menuCycle = scenarioContext.Get<List<MenuCycle>>().First();

            createMenuCycle.Create(menuCycle, group);
        }

        [Then(@"the message '(.*)' is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            notification.ValidateToastMessage(message);
        }

        [Then(@"the calendar view is opened")]
        public void ThenTheCalendardViewIsOpened()
        {
            menuCycleCalendarView.ValidateWindow(scenarioContext.Get<MenuCycle>().Name);
        }
    }
}
