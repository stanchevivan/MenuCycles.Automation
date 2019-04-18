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

        [FindsBy(How = How.CssSelector, Using = ".review-body")]
        private IWebElement PageBody { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".summary-box-week")]
        private IWebElement SummaryWeeks { get; set; }

        public bool IsLoaded => SummaryWeeks.Displayed;

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(PageBody);
        }
    }
}