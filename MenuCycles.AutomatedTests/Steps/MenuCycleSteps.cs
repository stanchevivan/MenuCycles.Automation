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

        public MenuCycleSteps(ScenarioContext scenarioContext, LogInAs logInAs,
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
        }

        [Given(@"a (.*) user is selected")]
        public void GivenAUserIsSelected(string userType)
        {
            logInAs.LogAs(userType);
        }

        [Given(@"a Menu Cycle is selected")]
        public void GivenAMenuCycleIsSelected()
        {
            MenuCycle menuCycle = scenarioContext.Get<IList<MenuCycle>>().First();
            menuCycleDashboard.SelectMenuCycleByName(menuCycle.Name);
        }

        [When(@"a Menu Cycle with the following criteria is create")]
        public void WhenAMenuCycleWithTheFollowingDataIsCreated(IList<MenuCycle> menuCycles)
        {
            menuCycleDashboard.CreateMenuCycleClick();

            Group group = scenarioContext.Get<IList<Group>>().First();
            MenuCycle menuCycle = scenarioContext.Get<IList<MenuCycle>>().First();

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
            MenuCycle menuCycle = scenarioContext.Get<IList<MenuCycle>>().First();
            menuCycleCalendarView.ValidateWindow(menuCycle.Name);
        }
    }
}
