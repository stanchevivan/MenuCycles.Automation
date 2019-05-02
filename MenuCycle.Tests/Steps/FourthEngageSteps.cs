using System.Configuration;
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
        FourthAppLocalPage fourthAppLocalPage;
        LogInAs logInAs;
        MenuCyclesDashboard menuCyclesDashboard;
        ToastNotification toastNotification;
        ScenarioContext scenarioContext;

        public FourthEngageSteps(FourthApp.Pages.Login fourthAppLogin,
                                 FourthApp.Pages.MainPage fourthAppMain,
                                 FourthAppLocalPage fourthAppLocalPage,
                                 LogInAs logInAs,
                                 ToastNotification toastNotification,
                                 ScenarioContext scenarioContext,
                                 MenuCyclesDashboard menuCyclesDashboard)
        {
            this.fourthAppLogin = fourthAppLogin;
            this.fourthAppMain = fourthAppMain;
            this.fourthAppLocalPage = fourthAppLocalPage;
            this.logInAs = logInAs;
            this.toastNotification = toastNotification;
            this.scenarioContext = scenarioContext;
            this.menuCyclesDashboard = menuCyclesDashboard;
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
          
            // Because on small window size MC opens in a new background tab, we need to switch to it
            fourthAppLocalPage.SwitchToTab(2);

            fourthAppLocalPage.SwitchToNativeContext();
        }

        [Given(@"'(.*)' application is open")]
        public void GivenApplicationIsOpen(string application)
        {
            if (!fourthAppMain.NotificationItemButton.Get().ElementPresent)
            {
                GivenFourthEngageDashboarIsOpen();
            }

            GivenApplicationIsSelected(application);
            logInAs.WaitPageToLoad();
        }

        [Given(@"Menu Cycle app is open on ""(.*)""")]
        public void MenuCyclesAppIsOpenOn(string environment)
        {
            if (!fourthAppMain.NotificationItemButton.Get().ElementPresent)
            {
                GivenFourthEngageDashboarIsOpenOn(environment);
            }

            GivenApplicationIsSelected("Menu Cycles");
            logInAs.WaitPageToLoad();
        }

        [Given(@"Fourth App is open on ""(.*)""")]
        public void GivenFourthEngageDashboarIsOpenOn(string environment)
        {
            ConfigurationReader config = new ConfigurationReader(environment);

            if (!fourthAppLogin.UserNameInput.Get().ElementPresent)
            {
                fourthAppLocalPage.OpenUrl(config.URL);
                fourthAppLogin.WaitForPageToLoad();
            }

            fourthAppLogin.PerformLogin(config.User, config.Password);
            fourthAppMain.WaitToBeReady();
        }
    }
}