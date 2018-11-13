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
        };        [FindsBy(How = How.ClassName, Using = "reports-main-right")]        private IWebElement RightSection { get; set; }        [FindsBy(How = How.ClassName, Using = "icon-report")]        private IList<IWebElement> ReportsList { get; set; }        public bool IsPageLoaded => RightSection.Displayed;        public void WaitForLoad()
        {
            Driver.WaitElementToExists(RightSection);
        }
        public void OpenReport(Reports reportName)
        {
            switch (reportName)
            {
                case Reports.ConsumerFacing:
                    ReportsList.First(r => r.Text == "Consumer Facing Report").Click();
                    break;
                case Reports.MenuExtract:
                    ReportsList.First(r => r.Text == "Menu Extract Report").Click();
                    break;
            }
        }
    }}