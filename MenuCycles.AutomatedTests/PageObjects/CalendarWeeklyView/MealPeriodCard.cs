using Fourth.Automation.Framework.Page;
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
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-item-contain > div > div")]
        public IList<IWebElement> Recipes { get; set; }
    }
}
