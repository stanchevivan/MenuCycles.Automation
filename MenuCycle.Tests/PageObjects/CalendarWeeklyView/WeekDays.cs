using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class WeekDays : BasePage
    {
        public WeekDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-calendar-heading")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mealPeriodButtons")]
        public IWebElement MealPeriodButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning")]
        public IWebElement DailyPlanningButton { get; set; }
    }
}
