using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class WeekDays : BasePage
    {
        public WeekDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-calendar-heading")]
        public IWebElement WeekDayName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mealPeriodButtons")]
        public IWebElement MealPeriodButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning")]
        public IWebElement DailyPlanningButton { get; set; }
    }
}
