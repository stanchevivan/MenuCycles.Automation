using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System;
using NUnit.Framework;
using Fourth.Automation.Framework.Reporting;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class ToastNotification : BasePage
    {
        private readonly IArtefacts Artefacts;
        public ToastNotification(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        public IWebElement ToastMessage { get; set; }

        public void ValidateToastMessage(string expected)
        {
            Driver.WaitElementToExists(ToastMessage);
            Assert.AreEqual(expected, ToastMessage.Text);
            Artefacts.TakeScreenshot();
        }
    }
}
