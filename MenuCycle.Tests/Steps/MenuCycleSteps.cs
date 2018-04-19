using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;
using MenuCycle.Tests.PageObjects;
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

        [Given(@"a Menu Cycle is selected")]
        public void GivenAMenuCycleIsSelected()
        {
            var menuCycle = scenarioContext.Get<IList<MenuCycles>>().First();
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
        public void WhenAMenuCycleWithTheFollowingDataIsCreated()
        {
            menuCycleDashboard.CreateMenuCycleClick();

            var group = scenarioContext.Get<IList<Groups>>().First();
            var menuCycle = scenarioContext.Get<IList<MenuCycles>>().First();

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
            var menuCycle = scenarioContext.Get<IList<MenuCycles>>().First();
            menuCycleCalendarView.ValidateWindow(menuCycle.Name);
        }

        [When(@"planning for (.*) is opened")]
        public void WhenPlanningForADayIsOpened(string weekDay)
        {
            menuCycleCalendarView.OpenDailyPlanningForDay(weekDay);
            planningView.WaitForLoad();
        }
    }
}
