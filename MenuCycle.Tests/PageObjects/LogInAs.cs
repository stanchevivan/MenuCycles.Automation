using System;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class LogInAs : BasePage
    {
        public LogInAs(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='central-text']")]
        public IWebElement Central { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class='login-option-local']")]
        public IWebElement Local { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] button[class='toast-close-button']")]
        public IWebElement ToastMessageCloseButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "home-screen-table")]
        public IWebElement HomePage { get; set; }

        public void LogAs(string userType)
        {
            switch (userType.ToLower())
            {
                case "central":
                    LogAsCentral();
                    break;
                case "local":
                    LogAsLocal();
                    break;
                case "nouser":
                    LogAsNoUser();
                    break;
                default:
                    throw new Exception("User type " + userType + " does not exist");
            }
        }
        public void LogAsCentral()
        {
            WaitPageToLoad();
            Driver.WaitElementAndClick(Central);
        }

        public void LogAsLocal()
        {
            WaitPageToLoad();
            Driver.WaitElementAndClick(Local);
        }

        public void LogAsNoUser()
        {
            Driver.WaitElementToExists(HomePage);
        }

        public void WaitPageToLoad()
        {
            Driver.AsMobile().SwitchToWebViewContext();
            //ResumeToastNotification();
            Driver.WaitIsClickable(Central);
            Driver.WaitIsClickable(Local);
        }

        void ResumeToastNotification()
        {
            Driver.WaitElementAndClick(ToastMessageCloseButton);
        }
    }
}
