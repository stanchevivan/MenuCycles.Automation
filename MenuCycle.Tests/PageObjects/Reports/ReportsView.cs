using System;
using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;namespace MenuCycle.Tests.PageObjects{    public class ReportsView : MenuCyclesBasePage    {        public ReportsView(IWebDriver webDriver) : base(webDriver)        {        }

        public enum Reports
        {
            RecipeCard,
            MenuExtract,
            TrafficLight,
            ConsumerFacing,
        };        [FindsBy(How = How.ClassName, Using = "reports-main-right")]        private IWebElement RightSection { get; set; }        [FindsBy(How = How.CssSelector, Using = ".icon-report")]        private IList<IWebElement> ReportsList { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_consumer-facing")]
        private IWebElement ConsumerFacingReportButton { get; set; }        [FindsBy(How = How.CssSelector, Using = ".main-heading_recipe-card")]
        private IWebElement RecipeCardReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_traff")]
        private IWebElement TrafficLightReportButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-heading_menu-extract")]
        private IWebElement MenuExtractReportButton { get; set; }
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
            Driver.WaitElementToDisappear(RightSection);
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
                    break;
                case Reports.MenuExtract:
                    MenuExtractReportButton.Do(Driver).ScrollIntoView();
                    MenuExtractReportButton.Click();
                    break;
                case Reports.RecipeCard:
                    RecipeCardReportButton.Do(Driver).ScrollIntoView();
                    RecipeCardReportButton.Click();
                    break;
                case Reports.TrafficLight:
                    TrafficLightReportButton.Do(Driver).ScrollIntoView();
                    TrafficLightReportButton.Click();
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
    }}