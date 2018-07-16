using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Fourth.Automation.Framework.Extension;

namespace MenuCycle.Tests.PageObjects
{
    public class MealPeriodDetails : MenuCyclesBasePage
    {
        public MealPeriodDetails(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".addRecipeBtnText")]
        private IWebElement addRecipesButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".colorstrip")]
        private IList<IWebElement> cards { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiodLoaderMP")]
        private IWebElement Loader { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".deleteMP")]
        private IWebElement deleteButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".copyMP")]
        private IWebElement copyButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#saveBtn")]
        private IWebElement saveButton { get; set; }

        //TODO: Remove ExpandedRecipes from this class and use BuffetCard/ALaCarteCart ExpandedRecipes
        [FindsBy(How = How.CssSelector, Using = ".menu-expand[style=\"display: block;\"] .menu-recipe-expand")]
        private IList<IWebElement> expandedRecipes { get; set; }
        public IList<ExpandedRecipe> ExpandedRecipes => this.expandedRecipes.Select(x => new ExpandedRecipe(x)).ToList();


        public IList<RecipeCard> RecipeCards => this.cards
                                                    .Where(p => new RecipeCard(p).Type == "Recipe")
                                                    .Select(p => new RecipeCard(p)).ToList();

        public IList<ALaCarteCard> ALaCarteCards => this.cards
                                                        .Where(p => new ALaCarteCard(p).Type == "A La Carte")
                                                        .Select(p => new ALaCarteCard(p)).ToList();

        public void WaitForLoad()
        {
            Driver.WaitElementToDisappear(Loader);
        }

        public IList<BuffetCard> BuffetCards => this.cards
                                                    .Where(p => new BuffetCard(p).Type == "Buffet")
                                                    .Select(p => new BuffetCard(p)).ToList();

        public void AddRecipe()
        {
            addRecipesButton.Click();
        }

        public void Save()
        {
            saveButton.Click();
        }

        public void Copy()
        {
            copyButton.Click();
        }

        public void Delete()
        {
            deleteButton.Click();
        }

        public RecipeCard GetRecipeCard(string recipeName)
        {
            return RecipeCards.First(x => x.Name == recipeName);
        }

        public BuffetCard GetBuffetCard(string buffetName)
        {
            return BuffetCards.First(x => x.Name == buffetName);
        }
    }
}