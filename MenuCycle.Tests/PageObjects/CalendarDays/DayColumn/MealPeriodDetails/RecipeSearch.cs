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

        [FindsBy(How = How.CssSelector, Using = ".recipe-search input")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-btn-text")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHideSearch")]
        public IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".strip-pad .colorstrip-Recipe")]
        public IList<IWebElement> RecipesContainer { get; set; }

        public IList<RecipeItem> Recipes => this.RecipesContainer.Select(p => new RecipeItem(p)).ToList();

        public void SearchRecipeByName(string recipeName)
        {
            SearchBox.SendKeys(recipeName);
            SearchButton.Click();
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void AddRecipe(string recipeName)
        {
            Recipes.First(c => c.Title == recipeName).Add();
        }

        public RecipeItem GetRecipe(string recipeName)
        {
            return Recipes.First(x => x.Title == recipeName);
        }
    }
}