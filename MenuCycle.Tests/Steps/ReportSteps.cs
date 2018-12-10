using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static MenuCycle.Tests.PageObjects.ReportsView;

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

        [When(@"Report ""(.*)"" is opened")]
        public void ConsumerFacingReportIsOpened(Reports reportName)
        {
            reportsView.OpenReport(reportName);
            reportsView.WaitReportToLoad();
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

        [Then(@"Verify Include sell price is not checked")]
        public void VerifyWhenIncludeSellPriceIsChecked()
        {
            Assert.IsFalse(consumerFacingReportPage.IsSellPriceSelected);
        }

        [Then(@"Verify Price type dropdown is disabled")]
        public void VerifyPriceTypeDropdownisDisabled()
        {
            Assert.IsFalse(consumerFacingReportPage.IsPriceDropDownEnabled);
        }

        [When(@"Report start date ""(.*)"" is selected")]
        public void WhenDateFromIsSelectedRecipeCardReport(string startDate)
        {
            reportsView.SelectDateFrom(startDate);
        }

        [When(@"Report end date ""(.*)"" is selected")]
        public void WhenDateToIsSelectedRecipeCardReport(string startDate)
        {
            reportsView.SelectDateTo(startDate);
        }

        [When(@"Calories checkbox is checked")]
        public void WhenCaloriesCheckBoxIsChecked()
        {
            consumerFacingReportPage.IncludeCalories();
        }

        [When(@"Kilojoules checkbox is checked")]
        public void WhenKilojoulesCheckBoxIsChecked()
        {
            consumerFacingReportPage.IncludeKilojoules();
        }

        [When(@"Meal periods are selected")]
        public void MealPeriodIsSelected(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                reportsView.SelectMealPeriod(row["MealPeriod"]);
            }
        }

        [When(@"Export CSV and Export PDF buttons are displayed")]
        [Then(@"Export CSV and Export PDF buttons are displayed")]
        public void ButtonsAreDisplayed()
        {
            Assert.IsTrue(consumerFacingReportPage.IsExportCSVButonVisible);
            Assert.IsTrue(consumerFacingReportPage.IsExportPDFButonVisible);
        }

        [When(@"Export CSV and Export PDF buttons are not displayed")]
        public void WhenExportCSVAndExportPDFButtonsAreNotDisplayed()
        {
            Assert.IsFalse(consumerFacingReportPage.IsExportCSVButonVisible);
            Assert.IsFalse(consumerFacingReportPage.IsExportPDFButonVisible);
        }

        [When(@"Export PDF button is clicked")]
        [Then(@"Export PDF button is clicked")]
        public void ExportPdfButtonIsClicked()
        {
            consumerFacingReportPage.UseExportPdfButton();
        }

        [When(@"Export CSV button is clicked")]
        [Then(@"Export CSV button is clicked")]
        public void ExportCsvButtonIsClicked()
        {
            consumerFacingReportPage.UseExportCsvButton();
        }

        [When(@"Report is exported")]
        public void ReportIsExported()
        {
            reportsView.UseExportButton();
        }

        [When(@"Export button is not displayed")]
        public void ExportButtonIsNotDisplayed()
        {
            Assert.IsFalse(reportsView.IsExportButtonVisible);
        }

        [Then(@"Export button is displayed")]
        public void ExportButtonIsDisplayed()
        {
            Assert.IsTrue(reportsView.IsExportButtonVisible);
        }
    }
}