﻿using System;
using System.Collections.Generic;
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

        [FindsBy(How = How.ClassName, Using = "location-name-container")]
        public IList<IWebElement> Locations { get; set; }

        [FindsBy(How = How.ClassName, Using = "location-name-text")]
        public IWebElement LocationName { get; set; }

        [FindsBy(How = How.ClassName, Using = "location-search-box")]
        public IWebElement LocationSearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.login-box.locations-vis")]
        private IWebElement LocationAnimationBox { get; set; }

        public void SearchLocation(string text)
        {
            LocationSearchBox.Click();
            LocationSearchBox.ClearAndSendKeys(text);
            Driver.WaitIsClickable(LocationName);
        }

        public void SelectLocation(string locationName)
        {
            Locations.First(x => x.Text == locationName).Click();
        }

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
            Driver.WaitElementAndClick(Central);
        }

        public void LogAsLocal()
        {
            Driver.WaitElementAndClick(Local);
            Driver.WaitIsClickable(LocationSearchBox);
            System.Threading.Thread.Sleep(1000);
        }

        public void LogAsNoUser()
        {
            Driver.WaitElementToExists(HomePage);
        }

        public void WaitPageToLoad()
        {
            if (Driver.IsMobile())
            {
                Driver.AsMobile().SwitchToWebViewContext();
            }
        }

        void ResumeToastNotification()
        {
            Driver.WaitElementAndClick(ToastMessageCloseButton);
        }
    }
}
