using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Mobile;

namespace MenuCycles.Tests.PageObjects
{
    public class FourthLoginPage : BasePage
    {
        #region Constructor
        public FourthLoginPage(IWebDriver webDriver) : base(webDriver) {}
        #endregion

        #region PageObjects
        [FindsBy(How = How.Name, Using = "j_id0:j_id1:j_id15:username")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "j_id0:j_id1:j_id15:j_id23")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "j_id0:j_id1:j_id15:submit")]
        private IWebElement SignIn { get; set; }
        #endregion

        #region Methods
        public FourthLoginPage Open()
        {
            if (!Driver.IsMobile())
                Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["WebSite.Url"]);
            WaitPageToLoad();

            return new FourthLoginPage(Driver);
        }

        public FourthHomePage PerformLogin()
        {
            UserName.ClearAndSendKeys(ConfigurationManager.AppSettings["User"]);
            Password.ClearAndSendKeys(ConfigurationManager.AppSettings["Password"]);
            SignIn.Click();
            Driver.WaitElementToDisappear(Password);

            return new FourthHomePage(Driver);
        }

        public void WaitPageToLoad()
        {
            Driver.WaitIsClickable(UserName);
        }
        #endregion
    }
}
