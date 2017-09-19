using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class EngageDashboard : BasePage
    {
        public EngageDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='left-buttons']")]
        public IWebElement LeftSideMenuButton { get; set; }

        [FindsBy(How = How.Id, Using = "applications-all-apps")]
        public IWebElement AllApplicationsItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[id='apps-popup'] a[ng-click*='openAppFromModal']")]
        public IList<IWebElement> AllApplicationsList { get; set; }

        public void WaitPageToLoad()
        {
            Driver.WaitIsClickable(LeftSideMenuButton);
            Driver.WaitIsClickable(AllApplicationsItem);
            AllApplicationsItem.WaitMovementToEnd();
        }

        public void SelectApplication(string option)
        {
            WaitPageToLoad();
            AllApplicationsItem.Click();
            AllApplicationsList.ElementByText(option).Click();
        }
    }
}
