using System;
using System.Configuration;
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

        public FourthEngageSteps(FourthApp.Pages.Login fourthAppLogin, FourthApp.Pages.MainPage fourthAppMain,
                                 FourthAppLocalPage fourthAppLocalPage)
        {
            this.fourthAppLogin = fourthAppLogin;
            this.fourthAppMain = fourthAppMain;
            this.fourthAppLocalPage = fourthAppLocalPage;
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
                fourthAppMain.WaitToBeReady();
            }
            else
            {
                fourthAppLogin.PerformLogin(ConfigurationManager.AppSettings["Engage.User"], ConfigurationManager.AppSettings["Engage.Password"], new Uri(ConfigurationManager.AppSettings["Engage.Url"]));
            }
        }

        [Given(@"'(.*)' application is selected")]
        public void GivenApplicationIsSelected(string application)
        {
            if (fourthAppLocalPage.IsMobile)
            {
                fourthAppMain.LeftMenu.OpenMenu();
            }
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
        }
    }
}