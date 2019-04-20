using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionTabWeeks : PlanningView
    {
        public NutritionTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }
    }
}
