using System;
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
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly ReportsView reportsView;
        readonly WeeklyCalendarView weeklyCalendarView;

        public MenuCycleSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, LogInAs logInAs,
            MenuCyclesDashboard menuCycleDashboard, CreateMenuCycle createMenuCycle, MenuCycleDailyCalendarView menuCycleDailyCalendarView, RecipeSearch recipeSearch, ToastNotification notification,
                              ModalDialogPage modalDialogPage, ReportsView reportsView, WeeklyCalendarView weeklyCalendarView)
        {
            this.logInAs = logInAs;
            this.menuCycleDashboard = menuCycleDashboard;
            this.createMenuCycle = createMenuCycle;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.planningView = dailyPlanningView;
            this.modalDialogPage = modalDialogPage;
            this.reportsView = reportsView;
            this.weeklyCalendarView = weeklyCalendarView;

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
            menuCycleDailyCalendarView.WaitPageLoad();
        }

        [Given(@"Menu Cycle ""(.*)"" is searched")]
        [When(@"Menu Cycle ""(.*)"" is searched")]
        [Then(@"Menu Cycle ""(.*)"" is searched")]
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
            menuCycleDailyCalendarView.WaitPageLoad();
            menuCycleDailyCalendarView.OpenDailyPlanningForDay(weekDay);
            planningView.WaitForLoad();
        }

        [When(@"Calendar view is opened")]
        [Then(@"Calendar view is opened")]
        public void CalendardViewIsOpened()
        {
            Assert.IsTrue(menuCycleDailyCalendarView.IsCalendarViewOpen);
        }

        [Given(@"Menu Cycle is created with following data")]
        [When(@"Menu Cycle is created with following data")]
        public void GivenMenuCycleIsCreatedWithFollowingData(Table table)
        {
            string name = table.Rows[0]["MenuCycleName"];
            string description = table.Rows[0]["Description"];
            List<string> gapDays = table.Rows[0]["GapDays"].Split(',').ToList();
            string usergroup = table.Rows[0]["Usergroup"];

            menuCycleDashboard.UseCreateMenuCycleButton();
            createMenuCycle.WaitPageLoad();
            createMenuCycle.InputMenuCycleName(name);
            createMenuCycle.InputMenuCycleDescription(description);
            createMenuCycle.UseNextButton();
            createMenuCycle.WaitGAPDaysToAppear();
            createMenuCycle.SelectGAPDays(gapDays);
            createMenuCycle.UseNextButton();
            createMenuCycle.SearchAndSelectOffer(usergroup);
            createMenuCycle.UseCreateButton();

            menuCycleDailyCalendarView.WaitPageLoad();
        }

        [When(@"Menu Cycle ""(.*)"" is edited to")]
        public void GivenMenuCycleIsEditedToTheFollowingData(string oldName, Table table)
        {
            string newName = table.Rows[0]["MenuCycleName"];
            string description = table.Rows[0]["Description"];
            //List<string> gapDays = table.Rows[0]["GapDays"].Split(',').ToList(); // Not editing GAP days. Checkboxes state can't be read. Need more investigation

            menuCycleDashboard.GetMenuCycle(oldName)
                              .UseActionButton()
                              .UseEditbutton();
            createMenuCycle.WaitPageLoad();
            createMenuCycle.InputMenuCycleName(newName);
            createMenuCycle.InputMenuCycleDescription(description);
            createMenuCycle.UseNextButton();
            createMenuCycle.WaitGAPDaysToAppear();
            //createMenuCycle.SelectGAPDays(gapDays);
            createMenuCycle.UseNextButton();

            menuCycleDailyCalendarView.WaitPageLoad();
        }

        [When(@"Menu Cycle ""(.*)"" is copied")]
        public void CopyMenuCycle(string menuCycleName)
        {
            menuCycleDashboard.GetMenuCycle(menuCycleName)
                              .UseActionButton()
                              .UseCopyButton();

            menuCycleDashboard.WaitPageLoad();
            notification.WaitToAppear();
            //notification.CloseNotification();
            notification.WaitToDisappear();
        }

        [When(@"Menu Cycle ""(.*)"" is deleted")]
        public void DeleteMenuCycle(string menuCycleName)
        {
            var mc = menuCycleDashboard.GetMenuCycle(menuCycleName);
            mc
                .UseActionButton()
                .UseDeleteButton();

            modalDialogPage.WaitToAppear();
            modalDialogPage.UseYesButton();

            menuCycleDashboard.WaitPageLoad();

            notification.WaitToAppear();
            //notification.CloseNotification();
            notification.WaitToDisappear();
        }

        [Then(@"Verify search results contain no menu cycles")]
        public void VerifySearchResultsContainNoMenuCycles()
        {
            Assert.IsEmpty(menuCycleDashboard.MenuCycles);
        }

        [When(@"Verify GAP days in calendar view are")]
        [Then(@"Verify GAP days in calendar view are")]
        public void VerifyGapDaysInCalendarViewAre(Table table)
        {
            var expectedGapDays = table.Rows.Select(x => x[0].ToUpper());
            var actualGapDays = menuCycleDailyCalendarView.CalendarColumns.Where(x => x.IsGapDay).Select(x => x.DayName);

            Assert.That(actualGapDays, Is.EqualTo(expectedGapDays));
        }

        [When(@"Reports page is opened")]
        public void WhenReportPageIsOpened()
        {
            menuCycleDailyCalendarView.WaitPageLoad();
            menuCycleDailyCalendarView.UseDailyReportButton();
            reportsView.WaitForLoad();
            planningView.WaitForBackdropToDisappear();
        }

        [Then(@"Reports page is correctly loaded")]
        public void ReportsPageIsCorrectlyLoaded()
        {
            Assert.IsTrue(reportsView.IsPageLoaded);
        }

        [When(@"Weekly Calendar is opened")]
        public void WeeksTabIsOpened()
        {
            menuCycleDailyCalendarView.WaitPageLoad();
            menuCycleDailyCalendarView.OpenWeeksTab();
            weeklyCalendarView.WaitForLoad();
            planningView.WaitForBackdropToDisappear();
        }
    }
}