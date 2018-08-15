﻿using System;
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
        [FindsBy(How = How.ClassName, Using = "mealperiod-save-btn")]
        private IWebElement saveButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "colorstrip-Recipe")]
        private IWebElement RecipeCard { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#slidingDiv .recipes-box-head-text .closeSlider.clickable")]
        private IWebElement CrossButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-scroll .colorstrip-Recipe")]
        private IList<IWebElement> RecipeDetailedViewContainer { get; set; }
        [FindsBy(How = How.ClassName, Using = "modal-backdrop-mp")]
        private IWebElement Backdrop { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".select-meal-box .custom-searchbox > div")]
        public IWebElement MealPeriodDropDown { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".custom-searchbox-options .clickable")]
        public IList<IWebElement> MealPeriods { get; set; }

        public IList<RecipeItem> Recipes => this.RecipeDetailedViewContainer.Select(p => new RecipeItem(p)).ToList();


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
            Driver.WaitElementToDisappear(Backdrop);
        }

        public void WaitForSaveButtonToBeEnabled()
        {
            Driver.WaitElementToExists(saveButton);
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

        public void UseCrossButton()
        {
            CrossButton.Click();
        }

        public RecipeItem GetRecipeFromDetailedView(string recipeName)
        {
            return Recipes.First(x => x.Title == recipeName);
        }

        public void OpenRecipeDetailedView(string recipeName)
        {
            GetRecipeFromDetailedView(recipeName).OpenRecipeDetailedView();
        }

        public void SelectMealPeriod(string mealPeriodName)
        {
            MealPeriodDropDown.Click();
            MealPeriods.ElementByText(mealPeriodName.ToUpper()).Click();
        }
    }
}