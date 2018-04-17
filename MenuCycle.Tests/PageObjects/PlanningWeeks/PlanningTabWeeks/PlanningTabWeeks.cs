using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabWeeks : DailyPlanningView
    {
        public PlanningTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "planning-switch-day")]
        private IWebElement DaysButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "weekly-summary-content")]
        private IWebElement PageContent { get; set; }

        public override void WaitForLoad()
        {
            Driver.WaitElementToExists(PageContent);
            base.WaitForLoader();
        }

        public void SwitchToDailyView()
        {
            DaysButton.Click();
        }
    }
}
