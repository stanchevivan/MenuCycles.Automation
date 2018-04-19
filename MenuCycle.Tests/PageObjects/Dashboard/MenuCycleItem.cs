using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCycleItem
    {
        public MenuCycleItem(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".name_title a")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".name_sub")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".home-button-expand")]
        public IWebElement ActionButton { get; set; }
    }
}
