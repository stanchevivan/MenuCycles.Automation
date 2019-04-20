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
    }
}