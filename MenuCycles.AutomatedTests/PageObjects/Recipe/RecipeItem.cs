using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class RecipeItem : BasePage
    {
        public RecipeItem(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-name-underline")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".item-type")]
        public IWebElement Type { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".cost-value")]
        public IWebElement Price { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".add-item-button-text")]
        [FindsBy(How = How.CssSelector, Using = ".recipe-bin")]
        public IWebElement ActionButton { get; set; }
    }
}
