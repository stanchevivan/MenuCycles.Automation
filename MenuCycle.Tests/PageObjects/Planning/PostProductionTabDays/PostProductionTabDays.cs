using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionTabDays : PlanningView
    {
        public PostProductionTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "planning-post-production-navigation-tabs")]
        private IWebElement PostProductionNavTabs { get; set; }

        public override void WaitForLoad()
        {
            Driver.WaitElementToExists(PostProductionNavTabs);
            base.WaitForLoader();
        }
    }
}
