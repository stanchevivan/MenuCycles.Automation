using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static MenuCycle.Tests.PageObjects.ReportsView;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class ReportSteps
    {
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ReportsView reportsView;
        readonly ConsumerFacingReportPage consumerFacingReportPage;
        readonly ModalDialogPage modalDialogPage;


        public ReportSteps(ScenarioContext scenarioContext, ToastNotification notification, ReportsView reportsView, ConsumerFacingReportPage consumerFacingReportPage, ModalDialogPage modalDialogPage)
        {
            this.notification = notification;
            this.reportsView = reportsView;
            this.consumerFacingReportPage = consumerFacingReportPage;
            this.modalDialogPage = modalDialogPage;
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
        //Locations checkboxes uses the same selector as the meal periods
        [When(@"Locations are selected")]
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
        [Then(@"Report is exported")]
        public void ReportIsExported()
        {
            reportsView.UseExportButton();
        }

        [When(@"Export button is not displayed")]
        public void ExportButtonIsNotDisplayed()
        {
            Assert.IsFalse(reportsView.IsExportButtonVisible);
        }

        [Then(@"Verify Export button is displayed")]
        public void ExportButtonIsDisplayed()
        {
            Assert.IsTrue(reportsView.IsExportButtonVisible);
        }

        [When(@"Checkbox for Select All is selected")]
        public void WhenCheckboxForSelectAllIsSelected()
        {
            modalDialogPage.ClickSelectAll();
        }

        [When(@"Done button is selected")]
        public void WhenDoneButtonIsSelected()
        {
            modalDialogPage.UseApplyButton();
        }
    }
}