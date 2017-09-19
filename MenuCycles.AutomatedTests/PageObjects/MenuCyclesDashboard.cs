using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class MenuCyclesDashboard : BasePage
    {
        public MenuCyclesDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='borbot clickable']")]
        public IWebElement Create { get; set; }

        public void CreateMenuCycle()
        {
            Driver.WaitElementAndClick(Create);
        }
    }
}
