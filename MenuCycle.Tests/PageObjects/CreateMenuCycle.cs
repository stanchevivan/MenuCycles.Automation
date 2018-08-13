using System;
using System.Collections.Generic;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class CreateMenuCycle : BasePage
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

        [FindsBy(How = How.CssSelector, Using = ".radio")]
        public IList<IWebElement> NonServingDaysCheckBox { get; set; }

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
            foreach (var item in NonServingDaysCheckBox)
            {
                if (item.Selected)
                {
                    item.Click();
                }
            }

            foreach (var day in days)
            {
                ChooseGAPDay(day);
            }
        }

        private void ChooseGAPDay(string day)
        {
            int dayIndex = 99;

            switch (day.ToUpper())
            {
                case "MONDAY":
                    dayIndex = 0;
                    break;
                case "TUESDAY":
                    dayIndex = 1;
                    break;
                case "WEDNESDAY":
                    dayIndex = 2;
                    break;
                case "THURSDAY":
                    dayIndex = 3;
                    break;
                case "FRIDAY":
                    dayIndex = 4;
                    break;
                case "SATURDAY":
                    dayIndex = 5;
                    break;
                case "SUNDAY":
                    dayIndex = 6;
                    break;
                default:
                    throw new Exception($"Invalid day {day} !");
            }

            if (!NonServingDaysCheckBox[dayIndex].Selected)
            {
                NonServingDaysCheckBox[dayIndex].Click();
            }
        }

        public void WaitGAPDaysToAppear()
        {
            Driver.WaitListItemsLoad(NonServingDaysCheckBox);
        }
    }
}