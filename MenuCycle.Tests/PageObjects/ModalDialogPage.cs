using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Text.RegularExpressions;

namespace MenuCycle.Tests.PageObjects
{
    public class ModalDialogPage : BasePage
    {
        readonly IArtefacts Artefacts;
        public ModalDialogPage(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".modal-dialog-body")]
        [FindsBy(How = How.CssSelector, Using = "modal-dialog-engine__description > p")]
        private IWebElement Message { get; set; }
        [FindsBy(How = How.CssSelector, Using = "modal-dialog-engine__title > span")]
        private IWebElement Title { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-default__text' and text()='Yes']")]
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-default__text' and text()='Apply']")]
        [FindsBy(How = How.CssSelector, Using = ".modal-button.yes")]
        private IWebElement YesButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-default__text' and text()='No']")]
        private IWebElement NoButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "displayed-count")]
        private IWebElement recipeCountMessage { get; set; }

        public string RecipeCount => Regex.Match(recipeCountMessage.Text, "\\d+").Value;

        public void UseYesButton()
        {
            YesButton.Click();
        }

        public void UseApplyButton()
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

        public void WaitRecipeCountToAppear()
        {
            Driver.WaitElementToExists(recipeCountMessage);
        }
    }
}