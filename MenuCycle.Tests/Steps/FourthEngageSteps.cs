using System;
using System.Configuration;
using Fourth.Automation.Framework.Extension;
using MenuCycle.Tests.PageObjects;
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
        ToastNotification toastNotification;

        public FourthEngageSteps(FourthApp.Pages.Login fourthAppLogin, FourthApp.Pages.MainPage fourthAppMain,
                                 FourthAppLocalPage fourthAppLocalPage, LogInAs logInAs, ToastNotification toastNotification)
        {
            this.fourthAppLogin = fourthAppLogin;
            this.fourthAppMain = fourthAppMain;
            this.fourthAppLocalPage = fourthAppLocalPage;
            this.logInAs = logInAs;
            this.toastNotification = toastNotification;
        }

        [Given(@"Fourth Engage Dashboard is open")]
        public void GivenFourthEngageDashboarIsOpen()
        {
            if (fourthAppLocalPage.IsMobile)
            {
                if (!fourthAppLocalPage.IsiOS || fourthAppLogin.UserNameInput.Get().ElementDisplayed)
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
            //if (fourthAppMain.LeftMenu.HamburguerMenu.Location.X <= 50)
            //{
            //    fourthAppMain.LeftMenu.HamburguerMenu.Click();
            //}

            fourthAppLocalPage.ScrollToAllApplications();
            fourthAppMain.OpenApp(application);
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
            toastNotification.WaitToAppearAndDisapear();
        }
    }
}