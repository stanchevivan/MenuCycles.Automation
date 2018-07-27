using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public sealed class MenuCycleSteps
    {
        readonly LogInAs logInAs;
        readonly PlanningView planningView;
        readonly MenuCyclesDashboard menuCycleDashboard;
        readonly CreateMenuCycle createMenuCycle;
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly CreateMealPeriod createMealPeriod;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public MenuCycleSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, LogInAs logInAs,
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
            this.planningView = dailyPlanningView;

            this.scenarioContext = scenarioContext;
        }

        [Given(@"a (.*) user is selected")]
        public void GivenAUserIsSelected(string userType)
        {
            logInAs.LogAs(userType);
        }

        [Given(@"Menu Cycle ""(.*)"" is selected")]
        [When(@"Menu Cycle ""(.*)"" is selected")]
        public void GivenMenuCycleIsSelected(string menuCycleName)
        {
            menuCycleDashboard.WaitPageLoad();
            menuCycleDashboard.SearchMenuCycle(menuCycleName);
            menuCycleDashboard.SelectMenuCycleByName(menuCycleName);
            menuCycleCalendarView.WaitPageLoad();
        }

        [Given(@"Menu Cycle ""(.*)"" is searched")]
        [When(@"Menu Cycle ""(.*)"" is searched")]
        public void MenuCycleIsSearched(string menuCycleName)
        {
            menuCycleDashboard.WaitPageLoad();
            menuCycleDashboard.SearchMenuCycle(menuCycleName);
        }

        [When(@"Verify search results contain the following menu cycles")]
        public void VerifySearchResultsContainMenuCycles(Table table)
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                Assert.That(menuCycleDashboard.MenuCycles[i].Name == table.Rows[i]["Name"]);
                Assert.That(menuCycleDashboard.MenuCycles[i].Description == table.Rows[i]["Description"]);
            }
        }

        [Given(@"the message '(.*)' is displayed")]
        [When(@"the message '(.*)' is displayed")]
        [Then(@"the message '(.*)' is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            notification.ValidateToastMessage(message);
        }

        [Given(@"planning for (.*) is opened")]
        [When(@"planning for (.*) is opened")]
        [Then(@"planning for (.*) is opened")]
        public void WhenPlanningForADayIsOpened(string weekDay)
        {
            menuCycleCalendarView.WaitPageLoad();
            menuCycleCalendarView.OpenDailyPlanningForDay(weekDay);
            planningView.WaitForLoad();
        }
       
        [Then(@"Calendar view is opened")]
        public void CalendardViewIsOpened()
        {
            Assert.IsTrue(menuCycleCalendarView.IsCalendarViewOpen);
        }

    }
}
