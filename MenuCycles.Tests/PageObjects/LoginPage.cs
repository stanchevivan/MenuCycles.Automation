using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Mobile;

namespace MenuCycles.Tests.PageObjects
{
    public class LoginPage : BasePage
    {
        #region Constructor
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageToLoad();
        }
        #endregion

        #region PageObjects
        [FindsBy(How = How.ClassName, Using = "login-option-central")]
        private IWebElement BTN_Central { get; set; }
        [FindsBy(How = How.Name, Using = "login-option-local")]
        private IWebElement BTN_Local { get; set; }
        #endregion

        #region Methods
        /// Only for local build
        public LoginPage Open()
        {
            if (!Driver.IsMobile())
                Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["WebSite.Url"]);
            WaitPageToLoad();

            return this;
        }

        public void WaitPageToLoad()
        {
            Driver.WaitIsClickable(BTN_Central);
        }

        public HomePage LoginAsCentralUser()
        {
            Do.Click(BTN_Central);

            return new HomePage(Driver);
        }
        #endregion
    }
}
