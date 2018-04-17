using System.Configuration;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class EngageLogin : BasePage
    {
        public EngageLogin(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Username']")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='password']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Sign In']")]
        public IWebElement SignInButton { get; set; }

        public void OpenLoginPage()
        {
            OpenLoginPageUsing(ConfigurationManager.AppSettings["Engage.Url"]);
        }

        public void PerformLogin()
        {
            PerformLoginUsing(ConfigurationManager.AppSettings["Engage.User"], ConfigurationManager.AppSettings["Engage.Password"]);
        }

        public void OpenLoginPageUsing(string url)
        {
            Driver.Navigate().GoToUrl(url);
            WaitPageToLoad();
        }

        public void PerformLoginUsing(string user, string password)
        {
            UserName.ClearAndSendKeys(user);
            Password.ClearAndSendKeys(password);
            SignInButton.Click();
        }

        public void WaitPageToLoad()
        {
            Driver.WaitIsClickable(UserName);
            Driver.WaitIsClickable(Password);
        }
    }
}
