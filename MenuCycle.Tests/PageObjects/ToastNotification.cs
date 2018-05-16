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
        [FindsBy(How = How.ClassName, Using = "toast-close-button")]
        private IWebElement CloseButton { get; set; }

        public void ValidateToastMessage(string expected)
        {
            Driver.WaitElementToExists(Message);
            Assert.AreEqual(expected, Message.Text);
            Artefacts.TakeScreenshot();
        }

        public void WaitToDisappear()
        {
            Driver.WaitElementToDisappear(Message);
        }

        public void CloseNotification()
        {
            CloseButton.Click();
        }
    }
}
