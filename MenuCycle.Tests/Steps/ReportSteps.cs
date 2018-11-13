using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class ReportSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly ReportsView reportsView;
        readonly ConsumerFacingReportPage consumerFacingReportPage;
        readonly MenuCyclesDashboard menuCyclesDashboard;
        readonly LogInAs logInAs;

        public ReportSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView,
            RecipeSearch recipeSearch, ToastNotification notification,
                           ModalDialogPage modalDialogPage, ReportsView reportsView, ConsumerFacingReportPage consumerFacingReportPage, MenuCyclesDashboard menuCyclesDashboard, LogInAs logInAs)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.reportsView = reportsView;
            this.consumerFacingReportPage = consumerFacingReportPage;
            this.menuCyclesDashboard = menuCyclesDashboard;
            this.logInAs = logInAs;

            this.scenarioContext = scenarioContext;
        }

        [Then(@"Reports page is correctly loaded")]
        public void ReportsPageIsCorrectlyLoaded()
        {
            Assert.IsTrue(reportsView.IsPageLoaded);
        }

        [Then(@"Consumer facing report price type dropdown is visible")]
        public void ConsumerFacingReportPriceTypeDropdownIsVisible()
        {
            Assert.IsTrue(consumerFacingReportPage.IsPriceDropDownVisible);
        }

        [When(@"Consumer facing report is opened")]
        public void ConsumerFacingReportIsOpened()
        {
            reportsView.OpenReport(ReportsView.Reports.ConsumerFacing);
            consumerFacingReportPage.WaitPageToLoad();
        }

        [When(@"Location name is clicked")]
        public void LocationNameIsClicked()
        {
            menuCyclesDashboard.ClickLocationName();
            logInAs.WaitPageToLoad();
        }

        [When(@"Include sell price is checked")]
        public void WhenIncludeSellPriceIsChecked()
        {
            consumerFacingReportPage.IncludeSellPrice();
        }

        [Then(@"Verify Include sell price is checked")]
        public void VerifyWhenIncludeSellPriceIsChecked()
        {
            Assert.IsTrue(consumerFacingReportPage.IsSellPriceSelected);
        }

        [Then(@"Verify Price type dropdown is disabled")]
        public void VerifyPriceTypeDropdownisDisabled()
        {
            Assert.IsFalse(consumerFacingReportPage.IsPriceDropDownEnabled);
        }
    }
}