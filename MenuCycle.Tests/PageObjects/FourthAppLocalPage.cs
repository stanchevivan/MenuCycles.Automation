using System;
using System.Configuration;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

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
        [FindsBy(How = How.Id, Using = "applications-all-apps")]
        private IWebElement AllApplications { get; set; }

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

        public void ScrollToAllApplications()
        {
            AllApplications.Do(Driver).ScrollIntoView();
        }

        public void SwitchToTab(int index)
        {
            if (Driver is OpenQA.Selenium.Chrome.ChromeDriver)
            {
                if (((OpenQA.Selenium.Chrome.ChromeDriver)Driver).WindowHandles.Count < 2)
                {
                    Driver.WaitNewWindowOpen();
                }
                Driver.SwitchTo().Window(Driver.WindowHandles[index - 1]);
            }
        }

        public void OpenUrl()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Engage.Url"]);
            if (Driver is OpenQA.Selenium.Safari.SafariDriver)
            {
                ((OpenQA.Selenium.Safari.SafariDriver)Driver).Manage().Window.Maximize();
            }
        }

        public void OpenUrl(string URL)
        {
            Driver.Navigate().GoToUrl(URL);

            if (Driver is OpenQA.Selenium.IE.InternetExplorerDriver) // || Driver is OpenQA.Selenium.Chrome.ChromeDriver)
            {
                Driver.Manage().Window.Maximize();
            }

            if (Driver is OpenQA.Selenium.Safari.SafariDriver)
            {
                ((OpenQA.Selenium.Safari.SafariDriver)Driver).Manage().Window.Maximize();
            }

        }

        public void WaitNumberOfTabsIs(int number)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until<bool>((d) => Driver.WindowHandles.Count == number);
        }
    }
}
