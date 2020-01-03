using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class ReviewPage : MenuCyclesBasePage
    {
        public ReviewPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".review")]
        private IWebElement PageBody { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".review__recipes_box")]
        private IWebElement SummaryRecipes { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'review-destinations')]")]
        private IWebElement SelectDestinations { get; set; }

        public bool IsLoaded => SummaryRecipes.Displayed;

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(PageBody);
        }

        public void ClickSelectDestinationsBtn()
        {
            SelectDestinations.Click();
        }
    }
}