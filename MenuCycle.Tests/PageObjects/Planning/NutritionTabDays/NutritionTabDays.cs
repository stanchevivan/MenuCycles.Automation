using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionTabDays : PlanningView
    {
        public NutritionTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "nutrition-meal-period-content")]
        IWebElement PageContent { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiodLoader")]
        IWebElement Loader { get; set; }

        public override void WaitForLoader()
        {
            Driver.WaitElementToExists(PageContent);
            base.WaitForLoader();
        }
    }
}
