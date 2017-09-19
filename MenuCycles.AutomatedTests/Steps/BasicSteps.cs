using MenuCycles.AutomatedTests.PageObjects;
using MenuCycles.AutomatedTests.Model;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MenuCycles.AutomatedTests.Steps
{
    [Binding]
    public class BasicSteps
    {
        private EngageLogin engageLogin;
        private EngageDashboard engageDashboard;
        private LogInAs logInAs;
        private MenuCyclesDashboard menuCycleDashboard;
        private CreateMenuCycle createMenuCycle;
        private MenuCycleCalendarView menuCycleCalendarView;

        public BasicSteps(EngageLogin engageLogin, EngageDashboard engageDashboard, LogInAs logInAs,
            MenuCyclesDashboard menuCycleDashboard, CreateMenuCycle createMenuCycle, MenuCycleCalendarView menuCycleCalendarView)
        {
            this.engageLogin = engageLogin;
            this.engageDashboard = engageDashboard;
            this.logInAs = logInAs;
            this.menuCycleDashboard = menuCycleDashboard;
            this.createMenuCycle = createMenuCycle;
            this.menuCycleCalendarView = menuCycleCalendarView;
        }

        [Given(@"the Menu Cycles Dashboard is opened as a (.*) user")]
        public void GivenTheMenuCycleDashboardIsOpened(string userType)
        {
            engageLogin.OpenLoginPage();
            engageLogin.PerformLogin();
            engageDashboard.SelectApplication("Menu Cycles");
            logInAs.LogAs(userType);
        }

        [When(@"a Menu Cycle with the following data is created")]
        public void WhenAMenuCycleWithTheFollowingDataIsCreated(Table table)
        {
            MenuCycle mc = new MenuCycle()
            {
                Name = "Icaro here",
                Description = "Testing Up",
                Offer = table.Rows[0][0],
                NonServingDays = new List<DayOfWeek>()
            };
            menuCycleDashboard.CreateMenuCycle();
            createMenuCycle.Create(mc);
        }

        [Then(@"the message (.*) is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            createMenuCycle.ValidateToastMessage(message);
        }

        [Then(@"the calendar view is opened")]
        public void ThenTheCalendardViewIsOpened()
        {
            menuCycleCalendarView.ValidateWindow("Icaro here");
        }

    }
}
