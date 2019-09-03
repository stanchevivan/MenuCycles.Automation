using System;
using System.Configuration;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclesBasePage : BasePage
    {
        private readonly IArtefacts Artefacts;

        public MenuCyclesBasePage(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = "#loader")]        private IWebElement Loader { get; set; }

        public bool IsMobile => Driver.IsMobile();

        public bool IsiOS => Driver.IsIos();

        public void WaitSpinnerToDisappear()
        {
            Driver.WaitElementToDisappear(Loader);
        }

        public void WaitSpinnerToAppear()
        {
            Driver.WaitElementToExists(Loader);
        }

        public void SwitchToNativeContext()
        {
            //Driver.AsMobile().SwitchToContext("NATIVE_APP");
            Driver.AsMobile().SwitchToNativeContext();

        }

        public void SwitchToWebViewContext()
        {
            Driver.AsMobile().SwitchToWebViewContext();
        }

        public bool IsHorizontalScrollPresent()
        {
            return (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return document.documentElement.scrollWidth>document.documentElement.clientWidth;");
        }

        public bool IsVerticalScrollPresent()
        {
            return (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return document.documentElement.scrollHeight>document.documentElement.clientHeight;");
        }

        public void CloseMenuCyclesApp()
        {
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
        }

        public void MaximizeWindow()
        {
            Driver.Manage().Window.Maximize();
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

        public void Wait(IWebElement element)
        {
            Driver.WaitIsClickable(element);
        }

        public void RefreshBrowser()
        {
            Driver.Navigate().Refresh();
        }
    }
}
