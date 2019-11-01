using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Fourth.Automation.Framework.Extension;using NUnit.Framework;
using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects{    public class ReportsView : MenuCyclesBasePage    {        public ReportsView(IWebDriver webDriver) : base(webDriver)        {        }

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
            LocatioGapCheck
        };        [FindsBy(How = How.ClassName, Using = "reports-main-right")]        private IWebElement RightSection { get; set; }        [FindsBy(How = How.CssSelector, Using = ".icon-report")]        private IList<IWebElement> ReportsList { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_consumer-facing")]
        private IWebElement ConsumerFacingReportButton { get; set; }        [FindsBy(How = How.CssSelector, Using = ".main-heading_recipe-card")]
        private IWebElement RecipeCardReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_traff")]
        private IWebElement TrafficLightReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_menu-extract")]
        private IWebElement MenuExtractReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_menu-cycle-calendar")]
        private IWebElement MenuCycleCalendarReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_requirements")]
        private IWebElement LocalReqsReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_buying")]
        private IWebElement BuyingReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_local")]
        private IWebElement LocalSalesHistoryReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_performance-report")]
        private IWebElement PerformanceReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_allergen")]
        private IWebElement AllergenReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_location-gap-check")]
        private IWebElement LocationGapCheckReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".icon-report_2")]
        private IWebElement RightSectionIcon { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports-main-right > div:not(.hidden) .clickable")]
        private IWebElement ExportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports-main-right > div:not(.hidden) .radio")]
        private IList<IWebElement> MealPeriodsList { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".squaredOne")]
        private IWebElement CheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports-main-right > div:not(.hidden) .timing-data-box:first-of-type input")]
        private IWebElement StartDate { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".reports-main-right > div:not(.hidden) .timing-data-box:last-of-type input")]
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
                    Driver.WaitListItemsLoad(MealPeriodsList);
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
                case Reports.LocatioGapCheck:
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
        /// Start reading PDF file from specific line.
        /// </summary>
        public string StartReadingPDFFromLine(string filePath, int line, string reportType)
        {
            string reportText = File.ReadAllText(filePath);

            if (reportType.ToLower() == "pdf")
            {
                string[] fromLine = reportText
                                        .Split(Environment.NewLine.ToCharArray())
                                        .Skip(line)
                                        .ToArray();

                string actualOutput = string.Join(Environment.NewLine, fromLine);

                return actualOutput;
            }

            return reportText;
        }

        public void CompareReports(Reports report, string reportType)
        {
            int startFromLine = 10;
            string expectedOutput;

            string expectedReportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Documents/MenuCycleReports");

            string downloadsPath = Path.Combine(
                  Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                  "Downloads");

            DirectoryInfo directory = new DirectoryInfo(downloadsPath);
            string actualReport = directory.GetFiles()
                 .OrderByDescending(f => f.LastWriteTime)
                 .First().ToString();

            var actualOutput = StartReadingPDFFromLine(actualReport, startFromLine, reportType);

            switch (report)
            {
                case Reports.ConsumerFacing:
                    //string consumerFacingPDF = "/Users/MPetkov/Projects/Fourth.MenuCycles.Automation/Reports/ConsumerReportPdf.pdf";
                    string consumerFacingPDF = expectedReportPath + "/ConsumerReportPdf.pdf";

                    expectedOutput = StartReadingPDFFromLine(consumerFacingPDF, startFromLine, reportType);

                    Assert.AreEqual(expectedOutput, actualOutput);
                    break;

                case Reports.ConsumerFacingCSV:
                    //string consumerFacingCSV = "/Users/MPetkov/Projects/Fourth.MenuCycles.Automation/Reports/ConsumerReportCsv.csv";
                    string consumerFacingCSV = expectedReportPath + "/ConsumerReportCsv.csv";

                    expectedOutput = StartReadingPDFFromLine(consumerFacingCSV, startFromLine, reportType);

                    Assert.AreEqual(expectedOutput, actualOutput);
                    break;

                case Reports.MenuExtract:
                    break;
                case Reports.RecipeCard:
                    break;
                case Reports.TrafficLight:
                    break;
                case Reports.MenuCycleCalendar:
                    break;
                case Reports.BuyingReport:
                    break;
                case Reports.LocalProductionRequirements:
                    break;
                case Reports.LocalSalesHistory:
                    break;
                case Reports.PerformanceReport:
                    break;
                case Reports.AllergenReport:
                    break;
                case Reports.LocatioGapCheck:
                    break;
            }
        }
    }}