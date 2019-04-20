using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionTabWeeks : PlanningView
    {
        public PostProductionTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

    }
}