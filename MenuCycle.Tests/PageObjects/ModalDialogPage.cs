using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class ModalDialogPage : BasePage
    {
        readonly IArtefacts Artefacts;
        public ModalDialogPage(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.ClassName, Using = "modal-dialog-engine__description > p")]
        private IWebElement Message { get; set; }
        [FindsBy(How = How.ClassName, Using = "modal-dialog-engine__title > span")]
        private IWebElement Title { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-default__text' and text()='Yes']")]
        private IWebElement YesButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-default__text' and text()='No']")]
        private IWebElement NoButton { get; set; }

        public void UseYesButton()
        {
            YesButton.Click();
        }

        public void UseNoButton()
        {
            NoButton.Click();
        }

        public void WaitToDisappear()
        {
            Driver.WaitElementToDisappear(Message);
        }

        public void WaitToAppear()
        {
            Driver.WaitElementToExists(Message);
        }
    }
}
