using MenuCycles.AutomatedTests.PageObjects;
using MenuCycles.AutomatedTests.Model;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;

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
        private ScenarioContext scenarioContext;

        public MenuCycleSteps(ScenarioContext scenarioContext, EngageDashboard engageDashboard, LogInAs logInAs,
            MenuCyclesDashboard menuCycleDashboard, CreateMenuCycle createMenuCycle, MenuCycleCalendarView menuCycleCalendarView)
        {
            this.engageDashboard = engageDashboard;
            this.logInAs = logInAs;
            this.menuCycleDashboard = menuCycleDashboard;
            this.createMenuCycle = createMenuCycle;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.scenarioContext = scenarioContext;
        }

        [Given(@"the Menu Cycles Dashboard is open as a (.*) user")]
        public void GivenTheMenuCycleDashboardIsOpen(string userType)
        {
            logInAs.LogAs(userType);
        }

        [When(@"a Menu Cycle with the following data is created")]
        public void WhenAMenuCycleWithTheFollowingDataIsCreated(List<MenuCycle> menuCycle)
        {
            scenarioContext.Set(menuCycle);
            menuCycleDashboard.CreateMenuCycleClick();
            createMenuCycle.Create(menuCycle.First());
        }

        [Then(@"the message '(.*)' is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            createMenuCycle.ValidateToastMessage(message);
        }

        [Then(@"the calendar view is opened")]
        public void ThenTheCalendardViewIsOpened()
        {
            string name = scenarioContext.Get<List<MenuCycle>>().First().Name;
            menuCycleCalendarView.ValidateWindow(name);
        }
    }
}
