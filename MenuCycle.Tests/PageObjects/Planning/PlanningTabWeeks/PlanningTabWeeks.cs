using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabWeeks : PlanningView
    {
        public PlanningTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//button[text()='Days']")]
        private IWebElement DaysButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "main")]
        private IWebElement PageContent { get; set; }

        public bool IsPageLoaded => PageContent.Exist();

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