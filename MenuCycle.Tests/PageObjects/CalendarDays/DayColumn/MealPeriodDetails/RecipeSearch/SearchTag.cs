using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class SearchTag
    {
        public SearchTag(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".tagit-close")]
        private IWebElement closeButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".tagit-label")]
        private IWebElement searchText { get; set; }

        public string Text => searchText.Text;

        public void Close()
        {
            closeButton.Click();
        }
    }
}