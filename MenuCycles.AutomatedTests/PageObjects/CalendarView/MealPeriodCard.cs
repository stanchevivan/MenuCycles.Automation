using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class MealPeriodCard : BasePage
    {
        public MealPeriodCard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-title")]
        public IWebElement MealPeriodName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-item-contain > div > div")]
        public IList<IWebElement> Recipes { get; set; }
    }
}
