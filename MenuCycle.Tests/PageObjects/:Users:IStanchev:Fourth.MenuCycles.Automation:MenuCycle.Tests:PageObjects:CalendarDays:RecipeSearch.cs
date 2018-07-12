using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeSearch : MenuCyclesBasePage
    {
        public RecipeSearch(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "search-btn")]
        private IWebElement searchButton { get; set; }

        public void WaitForLoad()
        {
            
        }

        public void UseSearchButton()
        {
            searchButton.Click();
        }
    }
}
