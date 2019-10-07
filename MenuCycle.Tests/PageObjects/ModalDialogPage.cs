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
        public ModalDialogPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "#calendarModalDialog .modal-dialog-body")]
        [FindsBy(How = How.CssSelector, Using = ".modal-dialog-body")]
        [FindsBy(How = How.CssSelector, Using = ".modal-dialog-engine__description > p")]
        private IWebElement Message { get; set; }
        [FindsBy(How = How.CssSelector, Using = "modal-dialog-engine__title > span")]
        private IWebElement Title { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".btn-confirm")]
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