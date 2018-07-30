using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class CreateMenuCycle : BasePage
    {
        readonly IArtefacts Artefacts;
        public CreateMenuCycle(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = "div[class*='name-form_name'] textarea")]
        public IWebElement MenuName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class*='name-form_description'] textarea")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".gap-day-item")]
        public IList<IWebElement> DaysOfWeek { get; set; }

        [FindsBy(How = How.Id, Using = "offers-search")]
        public IWebElement SearchGroup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class='group-serach-button']")]
        public IWebElement SearchGroupButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class*='offers-list']")]
        public IList<IWebElement> OffersList { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement CancelButton { get; set; }

<<<<<<< HEAD
        public void Create()
        {

=======
        [FindsBy(How = How.ClassName, Using = "radio")]
        public IList<IWebElement> NonServingDaysCheckBox { get; set; }

        internal void SearchAndSelectOffer(string offer)
        {
            Driver.WaitIsClickable(SearchGroup);
            SearchGroup.SendKeys(offer);
            SearchGroupButton.Click();
            OffersList.ElementByText(offer).FindElement(By.CssSelector("label")).Click();
        }

        public void InputMenuCycleName(string name)
        {
            MenuName.ClearAndSendKeys(name);
        }

        public void InputMenuCycleDescription(string description)
        {
            Description.ClearAndSendKeys(description);
>>>>>>> PageObjects for creation of menu cycle
        }

        public void WaitPageLoad()
        {
            Driver.WaitElementToExists(MenuName);
        }

        public void UseNextButton()
        {
            NextButton.Click();
        }

        public void UseCancelButton()
        {
            CancelButton.Click();
        }
    }
}