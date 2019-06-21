using System.Configuration;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using MenuCycle.Tests.PageObjects;
using MenuCycle.Tests.Support;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class FourthEngageSteps
    {
        FourthApp.Pages.Login fourthAppLogin;
        FourthApp.Pages.MainPage fourthAppMain;
        FourthApp.Pages.SalesforceLoginPage salesforceLoginPage;
        FourthAppLocalPage fourthAppLocalPage;
        LogInAs logInAs;
        ToastNotification toastNotification;
        ScenarioContext scenarioContext;
        MenuCyclesBasePage menuCyclesBasePage;

        ConfigurationReader config;

        public FourthEngageSteps(FourthApp.Pages.Login fourthAppLogin,
                                 FourthApp.Pages.MainPage fourthAppMain,
                                 FourthApp.Pages.SalesforceLoginPage salesforceLoginPage,
                                 FourthAppLocalPage fourthAppLocalPage,
                                 LogInAs logInAs,
                                 ToastNotification toastNotification,
                                 ScenarioContext scenarioContext,
                                 MenuCyclesBasePage menuCyclesBasePage)
        {
            this.fourthAppLogin = fourthAppLogin;
            this.fourthAppMain = fourthAppMain;
            this.fourthAppLocalPage = fourthAppLocalPage;
            this.logInAs = logInAs;
            this.toastNotification = toastNotification;
            this.scenarioContext = scenarioContext;
            this.menuCyclesBasePage = menuCyclesBasePage;
            this.salesforceLoginPage = salesforceLoginPage;
        }

        [Given(@"Fourth Engage Dashboard is open")]
        public void GivenFourthEngageDashboarIsOpen()
        {
            if (fourthAppLocalPage.IsMobile)
            {
                if (fourthAppLogin.UserNameInput.Get().ElementDisplayed)
                {
                    fourthAppLogin.PerformLogin(ConfigurationManager.AppSettings["Engage.User"], ConfigurationManager.AppSettings["Engage.Password"]);
                    fourthAppLocalPage.SwitchToNativeContext();
                    fourthAppLocalPage.ClickNoButton();
                    fourthAppLocalPage.SwitchToWebViewContext();
                }
            }

            if (!fourthAppLocalPage.IsMobile)
            {
                fourthAppLocalPage.OpenUrl();
                fourthAppLogin.WaitForPageToLoad();
                fourthAppLogin.UserNameInput.ClearAndSendKeys(ConfigurationManager.AppSettings["Engage.User"]);
                fourthAppLogin.PasswordInput.ClearAndSendKeys(ConfigurationManager.AppSettings["Engage.Password"]);
                fourthAppLogin.SignInButton.Click();
                //fourthAppLogin.PerformLogin(ConfigurationManager.AppSettings["Engage.User"], ConfigurationManager.AppSettings["Engage.Password"], new Uri(ConfigurationManager.AppSettings["Engage.Url"]));
            }

            fourthAppMain.WaitToBeReady();
        }

        [Given(@"'(.*)' application is selected")]
        public void GivenApplicationIsSelected(string application)
        {
            if (fourthAppMain.LeftMenu.HamburguerMenu.Location.X <= 50)
            {
                fourthAppMain.LeftMenu.HamburguerMenu.Click();
            }

            fourthAppLocalPage.ScrollToAllApplications();
            fourthAppMain.OpenApp(application);
            fourthAppLocalPage.WaitNumberOfTabsIs(2);
            // Because on small window size MC opens in a new background tab, we need to switch to it
            fourthAppLocalPage.SwitchToTab(2);

            fourthAppLocalPage.SwitchToNativeContext();

            menuCyclesBasePage.MaximizeWindow();
            logInAs.WaitPageToLoad();
        }

        [Given(@"'(.*)' application is open")]
        public void GivenApplicationIsOpen(string application)
        {
            if (!fourthAppMain.NotificationItemButton.Get().ElementPresent)
            {
                GivenFourthEngageDashboarIsOpen();
            }

            GivenApplicationIsSelected(application);
            menuCyclesBasePage.MaximizeWindow();
            logInAs.WaitPageToLoad();
        }

        [Given(@"Menu Cycles app is open on ""(.*)"" with FourthApp ""(.*)""")]
        public void MenuCycleAppIsOpenOnWith(string environment, bool withFA = true)
        {
            if (withFA)
            {
                if (!fourthAppMain.NotificationItemButton.Get().ElementPresent)
                {
                    GivenFourthEngageDashboarIsOpenOn(environment);
                }

                GivenApplicationIsSelected("Menu Cycles");
            }
            else
            {
                config = new ConfigurationReader(environment);
                salesforceLoginPage.PerformLogin(config.User, config.Password, new System.Uri(config.URL_Salesforce));

                menuCyclesBasePage.MaximizeWindow();
                logInAs.WaitPageToLoad();
            }
        }

        [Given(@"Fourth App is open on ""(.*)""")]
        public void GivenFourthEngageDashboarIsOpenOn(string environment)
        {
            config = new ConfigurationReader(environment);

            if (fourthAppLocalPage.IsMobile)
            {
                if (fourthAppLogin.UserNameInput.Get().ElementDisplayed)
                {
                    fourthAppLogin.PerformLogin(config.User, config.Password);
                    fourthAppLocalPage.SwitchToNativeContext();
                    fourthAppLocalPage.ClickNoButton();
                    fourthAppLocalPage.SwitchToWebViewContext();
                }
            }

            if (!fourthAppLocalPage.IsMobile)
            {
                fourthAppLocalPage.OpenUrl(config.URL);
                fourthAppLogin.WaitForPageToLoad();
                fourthAppLogin.PerformLogin(config.User, config.Password);
            }

            fourthAppMain.WaitToBeReady();
        }
    }
}