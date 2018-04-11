using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclePlanningView : BasePage
    {
        public MenuCyclePlanningView(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".mainheader__period > span:first-of-type")]
        private IWebElement HeaderDayText { get; set; }

        public void WaitPageToLoad()
        {
            Driver.WaitElementToExists(HeaderDayText);
        }

        public string GetHeaderText()
        {
            return HeaderDayText.Text;
        }
    }
}