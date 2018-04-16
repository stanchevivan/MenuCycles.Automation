using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabWeeks : BasePage
    {
        public PlanningTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "planning-switch-day ")]
        private IWebElement DaysButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "weekly-summary-content")]
        private IWebElement PageContent { get; set; }

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(PageContent);
        }

        public void SwitchToDailyView()
        {
            DaysButton.Click();
        }
    }
}
