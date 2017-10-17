using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycle.Tests.PageObjects
{
    public class MealPeriodCard
    {
        public MealPeriodCard(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-title")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-item-contain > div > div")]
        public IList<IWebElement> Recipes { get; set; }
    }
}
