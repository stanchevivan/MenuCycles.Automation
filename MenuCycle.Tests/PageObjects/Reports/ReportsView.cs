using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Fourth.Automation.Framework.Extension;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.PageObjects
{
    public class ReportsView : MenuCyclesBasePage
    {
        public ReportsView(IWebDriver webDriver) : base(webDriver)
        {
        }

        public enum Reports
        {
            RecipeCard,
            MenuExtract,
            TrafficLight,
            ConsumerFacing,
            ConsumerFacingCSV,
            MenuCycleCalendar,
            BuyingReport,
            LocalProductionRequirements,
            LocalSalesHistory,
            PerformanceReport,
            AllergenReport,
            LocationGapCheck
        };

        [FindsBy(How = How.ClassName, Using = "reports__content")]
        private IWebElement RightSection { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".icon-report")]
        private IList<IWebElement> ReportsList { get; set; }
        [FindsBy(How = How.Id, Using = "consumerFacingReport")]
        private IWebElement ConsumerFacingReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "recipeCard")]
        private IWebElement RecipeCardReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "trafficLightReport")]
        private IWebElement TrafficLightReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "menuExtractReport")]
        private IWebElement MenuExtractReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "menuCycleCalendarReport")]
        private IWebElement MenuCycleCalendarReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "localProductionRequirements")]
        private IWebElement LocalReqsReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "buyingReport")]
        private IWebElement BuyingReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "localSalesHistoryReport")]
        private IWebElement LocalSalesHistoryReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "performanceReport")]
        private IWebElement PerformanceReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "allergenIntoleranceReport")]
        private IWebElement AllergenReportButton { get; set; }
        [FindsBy(How = How.Id, Using = "locationGapCheckReport")]
        private IWebElement LocationGapCheckReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".icon-report_2")]
        private IWebElement RightSectionIcon { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".report_export-btn")]
        [FindsBy(How = How.XPath, Using = "//button[text()='Export']")]
        private IWebElement ExportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".checkbox-list__content .checkbox-list__item")]
        private IList<IWebElement> MealPeriodsList { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mc-checkbox__checkmark")]
        private IWebElement CheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports__body")]
        private IWebElement ReportBody { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports__content .date-selector_box:first-of-type input")]
        private IWebElement StartDate { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports__content .date-selector_box:last-of-type input")]
        private IWebElement EndDate { get; set; }

        public bool IsPageLoaded => RightSection.Displayed;
        public bool IsExportButtonVisible => ExportButton.Get().ElementPresent;

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(RightSection);
        }

        public void WaitReportToLoad()
        {
            Driver.WaitElementToDisappear(RightSectionIcon);
        }

        public void OpenReport(Reports reportToOpen)
        {
            switch (reportToOpen)
            {
                case Reports.ConsumerFacing:
                    ConsumerFacingReportButton.Do(Driver).ScrollIntoView();
                    ConsumerFacingReportButton.Click();
                    Driver.WaitElementToExists(ReportBody);
                    break;
                case Reports.MenuExtract:
                    MenuExtractReportButton.Do(Driver).ScrollIntoView();
                    MenuExtractReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.RecipeCard:
                    RecipeCardReportButton.Do(Driver).ScrollIntoView();
                    RecipeCardReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.TrafficLight:
                    TrafficLightReportButton.Do(Driver).ScrollIntoView();
                    TrafficLightReportButton.Click();
                    Driver.WaitElementToExists(ExportButton);
                    break;
                case Reports.MenuCycleCalendar:
                    MenuCycleCalendarReportButton.Do(Driver).ScrollIntoView();
                    MenuCycleCalendarReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.BuyingReport:
                    BuyingReportButton.Do(Driver).ScrollIntoView();
                    BuyingReportButton.Click();
                    Driver.WaitElementToExists(ExportButton);
                    break;
                case Reports.LocalProductionRequirements:
                    LocalReqsReportButton.Do(Driver).ScrollIntoView();
                    LocalReqsReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.LocalSalesHistory:
                    LocalSalesHistoryReportButton.Do(Driver).ScrollIntoView();
                    LocalSalesHistoryReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.PerformanceReport:
                    PerformanceReportButton.Do(Driver).ScrollIntoView();
                    PerformanceReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.AllergenReport:
                    AllergenReportButton.Do(Driver).ScrollIntoView();
                    AllergenReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                case Reports.LocationGapCheck:
                    LocationGapCheckReportButton.Do(Driver).ScrollIntoView();
                    LocationGapCheckReportButton.Click();
                    Driver.WaitListItemsLoad(MealPeriodsList);
                    break;
                default:
                    throw new Exception($"No such report found! {reportToOpen}");
            }
        }

        public void UseExportButton()
        {
            ExportButton.Click();
        }

        public void SelectDateFrom(string dateFrom)
        {
            StartDate.Do(Driver).InputDate(dateFrom);
        }

        public void SelectDateTo(string dateTo)
        {
            EndDate.Do(Driver).InputDate(dateTo);
        }

        public void SelectMealPeriod(string mealPeriodName)
        {
            MealPeriodsList.First(m => m.Text == mealPeriodName).FindElement(By.ClassName(CheckBox.Get().Classes[0])).Click();
        }

        /// <summary>
        /// Start reading file from specific line.
        /// </summary>
        public string StartReadingPDFFromLine(string filePath, int line, string reportType)
        {
            string reportText = File.ReadAllText(filePath);

            string[] fromLine = reportText
                                    .Split(Environment.NewLine.ToCharArray())
                                    .Skip(line)
                                    .ToArray();

            string actualOutput = string.Join(Environment.NewLine, fromLine);

            return actualOutput;
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        public void CompareReports(Reports report, string reportType, string reportName)
        {
            string actualReportOutput;
            string expectedReportOutput;

            string currentDirectory = AssemblyDirectory;
            Directory.SetCurrentDirectory(currentDirectory);

            string expectedReportPath = Path.Combine(currentDirectory, "Reports");

            string downloadsPath = Path.Combine(
                  Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                   "Downloads");

            DirectoryInfo actualReportDir = new DirectoryInfo(downloadsPath);
            string actualReport = actualReportDir.GetFiles()
                 .OrderByDescending(f => f.LastWriteTime)
                 .First().ToString();

            string reportPath = "";
            int startFromLine = 0;

            switch (report)
            {
                case Reports.ConsumerFacing:
                    reportPath = "ConsumerFacing";
                    startFromLine = 10;
                    break;
                case Reports.MenuExtract:
                    reportPath = "MenuExtract";
                    startFromLine = 10;
                    break;
                case Reports.RecipeCard:
                    reportPath = "RecipeCard";
                    startFromLine = 10;
                    break;
                case Reports.TrafficLight:
                    reportPath = "TrafficLight";
                    startFromLine = 10;
                    break;
                case Reports.MenuCycleCalendar:
                    reportPath = "MenuCycleCalendar";
                    startFromLine = 10;
                    break;
                case Reports.BuyingReport:
                    reportPath = "BuyingReport";
                    startFromLine = 0;
                    break;
                case Reports.LocalProductionRequirements:
                    reportPath = "LocalProductionRequirements";
                    startFromLine = 0;
                    break;
                case Reports.LocalSalesHistory:
                    reportPath = "LocalSalesHistory";
                    startFromLine = 1;
                    break;
                case Reports.PerformanceReport:
                    reportPath = "PerformanceReport";
                    startFromLine = 2;
                    break;
                case Reports.AllergenReport:
                    reportPath = "AllergenReport";
                    startFromLine = 10;
                    break;
                case Reports.LocationGapCheck:
                    reportPath = "LocationGapCheck";
                    startFromLine = 1;
                    break;
            }

            string expectedPath = Path.Combine(expectedReportPath, reportPath, reportName);
            expectedReportOutput = StartReadingPDFFromLine(expectedPath, startFromLine, reportType);

            Directory.SetCurrentDirectory(Path.Combine(
              Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads"));

            actualReportOutput = StartReadingPDFFromLine(actualReport, startFromLine, reportType);

            Assert.AreEqual(expectedReportOutput, actualReportOutput);
        }
    }
}