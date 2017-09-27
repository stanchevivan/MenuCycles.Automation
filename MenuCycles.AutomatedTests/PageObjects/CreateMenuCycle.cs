using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Reporting;
using MenuCycleData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

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

        public void Create(MenuCycle menuCycle, Group group)
        {

            MenuName.SendKeys(menuCycle.Name);
            Description.SendKeys(menuCycle.Description);
            NextButton.Click();

            SelectNonServingDays(menuCycle.NonServingDays);
            NextButton.Click();

            SearchAndSelectOffer(group.Name);
            CreateButton.Click();
        }

        internal void SelectNonServingDays(int daysOfWeekList)
        {
            if (daysOfWeekList == 0)
            {
                return;
            }

            if (daysOfWeekList < 64)
            {
                DaysOfWeek.ElementByText(((NonServingDays)daysOfWeekList).ToString()).FindElement(By.CssSelector("label")).Click();
            }
            //TODO: Implement logic to when more than one day of the week is selected.
        }

        internal void SearchAndSelectOffer(string offer)
        {
            Driver.WaitIsClickable(SearchGroup);
            SearchGroup.SendKeys(offer);
            SearchGroupButton.Click();
            OffersList.ElementByText(offer).FindElement(By.CssSelector("label")).Click();
        }
        public enum NonServingDays
        {
            None = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
    }
}
