using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class MenuCycleItem : BasePage
    {
        public MenuCycleItem(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".name_title a")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".name_sub")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".home-button-expand")]
        public IWebElement ActionButton { get; set; }
    }
}
