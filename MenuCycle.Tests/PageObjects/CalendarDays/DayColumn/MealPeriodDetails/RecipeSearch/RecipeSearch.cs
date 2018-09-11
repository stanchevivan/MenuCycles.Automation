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

        [FindsBy(How = How.CssSelector, Using = ".tagit-choice")]
        private IList<IWebElement> searchTags { get; set; }

        [FindsBy(How = How.ClassName, Using = "colorstrip-Buffet")]
        private IList<IWebElement> BuffetSearchContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "no-search-results")]
        private IWebElement NoResult { get; set; }

        public IList<RecipeItem> Recipes => this.RecipeSearchContainer.Select(p => new RecipeItem(p)).ToList();
        public IList<BuffetItem> Buffets => this.BuffetSearchContainer.Select(p => new BuffetItem(p)).ToList();
        public IList<SearchTag> SearchTags => this.searchTags.Select(p => new SearchTag(p)).ToList();

        public string NoResultText => NoResult.Text;

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

        public void AddBuffet(string buffetName)
        {
            Buffets.First(c => c.Title == buffetName).Add();

        }

        public RecipeItem GetRecipeFromSearch(string recipeName)
        {
            return Recipes.First(x => x.Title == recipeName);
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