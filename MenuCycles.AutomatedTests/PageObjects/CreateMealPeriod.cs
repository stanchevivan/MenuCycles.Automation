using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class CreateMealPeriod : BasePage
    {
        private readonly IArtefacts Artefacts;

        public CreateMealPeriod(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".select-meal-box .custom-searchbox > div")]
        public IWebElement MealPeriodDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".custom-searchbox-options .clickable")]
        public IList<IWebElement> MealPeriods { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".addRecipeBtnText")]
        public IWebElement AddRecipeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".addRecipeBtnText")]
        public IWebElement CloseSearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#slidingDiv .closeSlider")]
        public IWebElement CloseWindowButton { get; set; }

        [FindsBy(How = How.Id, Using = "saveBtn")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHideMP")]
        public IWebElement SpinningWheel { get; set; }

        public void SelectMealPeriod(string mealPeriodName)
        {
            MealPeriodDropDown.Click();
            MealPeriods.ElementByText(mealPeriodName.ToUpper()).Click();
        }

        public void AddRecipe()
        {
            Driver.WaitElementAndClick(AddRecipeButton);
        }

        public void SaveAndCloseMealPeriod()
        {
            SaveMealPeriod();
            Driver.WaitElementToDisappear(SpinningWheel);
            CloseMealPeriod();
        }

        public void SaveMealPeriod()
        {
            Driver.WaitElementAndClick(SaveButton);
        }

        public void CloseMealPeriod()
        {
            Driver.WaitElementAndClick(CloseWindowButton);
        }
    }
}
