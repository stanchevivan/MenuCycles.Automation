using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class RecipeSearch : BasePage
    {
        private readonly IArtefacts Artefacts;

        public RecipeSearch(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-search input")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-btn-text")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".recipe-search input")]
        public IList<IWebElement> MealPeriodList { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHideSearch")]
        public IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".strip-pad .colorstrip-Recipe")]
        public IList<IWebElement> RecipesList { get; set; }

        public void SearchRecipeByName(string recipeName)
        {
            SearchTextBox.SendKeys(recipeName);
            SearchButton.Click();
            Driver.WaitElementToDisappear(SpinningWheel);
            List<RecipeItem> recipes = RecipesList.ToPageObjectList<RecipeItem>(Driver);
            recipes.Find(c => c.Title.Text == recipeName).ActionButton.Click();
        }
    }
}
