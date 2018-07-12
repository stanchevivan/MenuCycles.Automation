using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeItem
    {
        public RecipeItem(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
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

        public void Add()
        {
            ActionButton.Click();
        }
    }
}
