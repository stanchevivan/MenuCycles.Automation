using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeSearch : BasePage
    {
        readonly IArtefacts Artefacts;

        public RecipeSearch(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-search .ui-autocomplete-input")]
        private IWebElement SearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-btn-text")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHideSearch")]
        private IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".strip-pad .colorstrip-Recipe")]
        private IList<IWebElement> RecipeSearchContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mealperiod-scroll .colorstrip-Recipe")]
        private IList<IWebElement> RecipeDetailedViewContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".tagit-choice")]
        private IList<IWebElement> searchTags { get; set; }

        public IList<RecipeItem> Recipes => this.RecipeSearchContainer.Select(p => new RecipeItem(p)).ToList();
        public IList<RecipeItem> DetailedViewRecipes => this.RecipeDetailedViewContainer.Select(p => new RecipeItem(p)).ToList();
        public IList<SearchTag> SearchTags => this.searchTags.Select(p => new SearchTag(p)).ToList();

        public void SearchRecipeByName(string recipeName)
        {
            ClearAllSearchTags();
            SearchBox.SendKeys(recipeName);
            SearchButton.Click();
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void AddRecipe(string recipeName)
        {
            Recipes.First(c => c.Title == recipeName).Add();
        }

        public RecipeItem GetRecipeFromSearch(string recipeName)
        {
            return Recipes.First(x => x.Title == recipeName);
        }

        public RecipeItem GetRecipeFromDetailedView(string recipeName)
        {
            return DetailedViewRecipes.First(x => x.Title == recipeName);
        }

        public void ClearAllSearchTags()
        {
            foreach (var searchTag in SearchTags)
            {
                searchTag.Close();
            }
        }
    }
}