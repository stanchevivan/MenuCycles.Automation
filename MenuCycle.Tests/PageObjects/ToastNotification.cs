using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using Fourth.Automation.Framework.Reporting;

namespace MenuCycle.Tests.PageObjects
{
    public class ToastNotification : BasePage
    {
        private readonly IArtefacts Artefacts;
        public ToastNotification(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        public IWebElement Message { get; set; }

        public void ValidateToastMessage(string expected)
        {
            Driver.WaitElementToExists(Message);
            Assert.AreEqual(expected, Message.Text);
            Artefacts.TakeScreenshot();
        }
    }
}
