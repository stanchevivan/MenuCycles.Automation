using System;
using System.Collections.Generic;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class CreateMenuCycle : MenuCyclesBasePage
    {
        public CreateMenuCycle(IWebDriver webDriver) : base(webDriver)
        {
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

        [FindsBy(How = How.CssSelector, Using = ".radio:not([style='display: none;'])")]
        public IList<IWebElement> OffersList { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label.colorfill")]
        public IList<IWebElement> NonServingDaysCheckBox { get; set; }

        public bool IsPageOpen => MenuName.Exist();

        internal void SearchAndSelectOffer(string offer)
        {
            Driver.WaitIsClickable(SearchGroup);
            SearchGroup.ClearAndSendKeys(offer);
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
        }

        public void WaitPageLoad()
        {
            Driver.WaitElementToExists(MenuName);
        }

        public void UseNextButton()
        {
            NextButton.Click();
        }

        public void UseCreateButton()
        {
            NextButton.Click();
        }

        public void UseCancelButton()
        {
            CancelButton.Click();
        }

        public void SelectGAPDays(IList<string> days)
        {
            //foreach (var item in NonServingDaysCheckBox)
            //{
            //    if (item.Selected)
            //    {
            //        item.Click();
            //    }
            //}

            foreach (var day in days)
            {
                ChooseGAPDay(day);
            }
        }

        private void ChooseGAPDay(string day)
        {
            int dayIndex =
            day.ToUpper() switch
            {
                "MONDAY" => 0,
                "TUESDAY" => 1,
                "WEDNESDAY" => 2,
                "THURSDAY" => 3,
                "FRIDAY" => 4,
                "SATURDAY" => 5,
                "SUNDAY" => 6,
                _ => throw new Exception($"Invalid day {day} !"),
            };

            //if (!NonServingDaysCheckBox[dayIndex].Selected)
            //{
            NonServingDaysCheckBox[dayIndex].Click();
            //}
        }

        public void WaitGAPDaysToAppear()
        {
            Driver.WaitListItemsLoad(NonServingDaysCheckBox);
        }
    }
}