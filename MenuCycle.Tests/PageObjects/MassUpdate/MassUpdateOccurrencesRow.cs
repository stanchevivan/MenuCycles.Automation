using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MassUpdateOccurrencesRow : MenuCyclesBasePage
    {
        public MassUpdateOccurrencesRow(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row__cell:nth-of-type(1)")]
        private IWebElement CheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row__cell:nth-of-type(2)")]
        private IWebElement Week { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row__cell:nth-of-type(3)")]
        private IWebElement Day { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row__cell:nth-of-type(4)")]
        private IWebElement MealPeriod { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row__cell:nth-of-type(5)")]
        private IWebElement Menu { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row__cell:nth-of-type(6)")]
        private IWebElement MenuName { get; set; }

        public string WeekNameText => Week.Text;
        public string DayNameText => Day.Text;
        public string MealPeriodNameText => MealPeriod.Text;
        public string MenuText => Menu.Text;
        public string MenuNameText => MenuName.Text;


        public void SelectOccurrence()
        {
            CheckBox.Click();
        }

    }
}
