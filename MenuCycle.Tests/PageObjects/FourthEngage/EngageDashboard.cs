using System.Collections.Generic;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class EngageDashboard : BasePage
    {
        public EngageDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='left-buttons']")]
        public IWebElement LeftSideMenuButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#applications ion-item[target]")]
        public IList<IWebElement> TopThreeApplicationsList { get; set; }

        [FindsBy(How = How.Id, Using = "applications-all-apps")]
        public IWebElement AllApplicationsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#apps-popup .app")]
        public IList<IWebElement> AllApplications { get; set; }

        [FindsBy(How = How.ClassName, Using = "backdrop")]
        public IWebElement Backdrop { get; set; }
        

        public void WaitPageToLoad()
        {
            Driver.WaitIsClickable(LeftSideMenuButton);
            Driver.WaitIsClickable(AllApplicationsButton);
            Driver.WaitListItemsLoad(TopThreeApplicationsList);
            Driver.WaitElementToDisappear(Backdrop);
        }

        public void SelectApplication(string option)
        {
            WaitPageToLoad();
            AllApplicationsButton.Click();
            AllApplications.ElementByText(option).Click();
        }
    }
}
