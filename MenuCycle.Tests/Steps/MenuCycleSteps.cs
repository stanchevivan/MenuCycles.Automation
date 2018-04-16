using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCycle.Data.Models;
using MenuCycle.Tests.PageObjects;

namespace MenuCycle.Tests.Steps
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
            MenuCycles menuCycle = scenarioContext.Get<IList<MenuCycles>>().First();
            menuCycleDashboard.SelectMenuCycleByName(menuCycle.Name);
            menuCycleCalendarView.WaitPageLoad();
        }

        [Given(@"Menu Cycle ""(.*)"" is selected")]
        public void GivenMenuCycleIsSelected(string menuCycleName)
        {
            menuCycleDashboard.SelectMenuCycleByName(menuCycleName);
            menuCycleCalendarView.WaitPageLoad();
        }

        [When(@"a Menu Cycle with the following criteria is create")]
        public void WhenAMenuCycleWithTheFollowingDataIsCreated(IList<MenuCycles> menuCycles)
        {
            menuCycleDashboard.CreateMenuCycleClick();

            Groups group = scenarioContext.Get<IList<Groups>>().First();
            MenuCycles menuCycle = scenarioContext.Get<IList<MenuCycles>>().First();

            createMenuCycle.Create(menuCycle, group);

            menuCycleCalendarView.WaitPageLoad();
        }

        [Then(@"the message '(.*)' is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            notification.ValidateToastMessage(message);
        }

        [Then(@"the calendar view is opened")]
        public void ThenTheCalendardViewIsOpened()
        {
            MenuCycles menuCycle = scenarioContext.Get<IList<MenuCycles>>().First();
            menuCycleCalendarView.ValidateWindow(menuCycle.Name);
        }
    }
}
