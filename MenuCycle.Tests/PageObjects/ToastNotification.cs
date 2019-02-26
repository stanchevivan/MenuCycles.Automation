using System;
using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class ToastNotification : BasePage
    {
        readonly IArtefacts Artefacts;
        public ToastNotification(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        private IWebElement Message { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        private IList<IWebElement> Messages { get; set; }
        [FindsBy(How = How.ClassName, Using = "toast-close-button")]
        private IWebElement CloseButton { get; set; }

        public void ValidateToastMessage(string expectedMessage)
        {
            WaitToAppear();

            var notificationMessages = Messages.Select(x => x.Text).ToList();
            Assert.That(notificationMessages, Has.Member(expectedMessage));
            Artefacts.TakeScreenshot();
        }

        public void WaitToDisappear()
        {
            Driver.WaitElementToDisappear(Message);
        }

        public void CloseNotification()
        {
            if (CloseButton.Exist())
            {
                CloseButton.Click();
            }
        }

        public void WaitToAppear()
        {
            Driver.WaitElementToExists(Message);
        }

        public void WaitToAppearAndDisapear()
        {
            Driver.WaitElementToExists(Message);
            CloseNotification();
            Driver.WaitElementToDisappear(Message);
        }
    }
}