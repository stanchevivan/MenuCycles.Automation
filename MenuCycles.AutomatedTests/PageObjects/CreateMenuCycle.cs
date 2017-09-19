using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Reporting;
using MenuCycles.AutomatedTests.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class CreateMenuCycle : BasePage
    {
        private readonly IArtefacts Artefacts;
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

        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        public IWebElement ToastMessage { get; set; }

        public void ValidateToastMessage(string expected)
        {
            Driver.WaitElementToExists(ToastMessage);
            Assert.AreEqual(expected, ToastMessage.Text);
            Artefacts.TakeScreenshot();
        }

        public void Create(MenuCycle mc)
        {
            MenuName.SendKeys(mc.Name);
            Description.SendKeys(mc.Description);
            NextButton.Click();

            SelectNonServingDays(mc.NonServingDays);
            NextButton.Click();

            SearchAndSelectOffer(mc.Group);
            CreateButton.Click();
        }

        internal void SelectNonServingDays(List<DayOfWeek> daysOfWeekList)
        {
            if (daysOfWeekList != null && daysOfWeekList.Count > 0)
            {
                foreach (var item in daysOfWeekList)
                {
                    DaysOfWeek.ElementByText(item.ToString()).FindElement(By.CssSelector("label")).Click();
                }
            }
        }

        internal void SearchAndSelectOffer(string offer)
        {
            Driver.WaitIsClickable(SearchGroup);
            SearchGroup.SendKeys(offer);
            SearchGroupButton.Click();
            OffersList.ElementByText(offer).FindElement(By.CssSelector("label")).Click();
        }
    }
}
