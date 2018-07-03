using System;
using System.Configuration;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class FourthAppLocalPage : BasePage
    {
        public FourthAppLocalPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "input[id *= username]")]
        private IWebElement UserName { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type=password]")]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type=submit]")]
        private IWebElement SignInButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[2]")]
        [FindsBy(How = How.Id, Using = "No")]
        private IWebElement MessageNoButton { get; set; }

        public bool IsMobile => Driver.IsMobile();

        public bool IsiOS => Driver.IsIos();

        public void SwitchToNativeContext()
        {
            //Driver.AsMobile().SwitchToContext("NATIVE_APP");
            Driver.AsMobile().SwitchToNativeContext();
           
        }

        public void Wait(IWebElement element)
        {
            Driver.WaitIsClickable(element);
        }

        public void WaitMainPageToLoad(IWebElement allApplicationsButton)
        {
            Driver.WaitIsClickable(allApplicationsButton);
        }

        public void SwitchToWebViewContext()
        {
            Driver.AsMobile().SwitchToWebViewContext();
        }

        public void ClickNoButton()
        {
            Driver.WaitElementAndClick(MessageNoButton);
            Driver.WaitElementToDisappear(MessageNoButton);
        }
    }
}
