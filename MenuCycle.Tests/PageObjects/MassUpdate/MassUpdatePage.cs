﻿using System;
using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using MenuCycle.Tests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace MenuCycle.Tests.PageObjects
{
    public class MassUpdatePage : MenuCyclesBasePage
    {
        public MassUpdatePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        [FindsBy(How = How.CssSelector, Using = ".tagify__input")]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-bar__button")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-utility-bar__message")]
        private IWebElement SearchResultsMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-card")]
        private IList<IWebElement> SearchResultCard { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".occurrences-card")]
        private IList<IWebElement> OccurrencesCard { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".occurrences-card")]
        private IWebElement OccurrencesCardTest { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-header .mc-checkbox__checkmark")]
        private IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mass-update__message")]
        private IWebElement NoResultsMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-utility-bar__button")]
        private IWebElement UpdatePriceButton { get; set; }

        //[FindsBy(How = How.CssSelector, Using = ".update-prices-container__wrapper")]
        //private IList<IWebElement> UpdatePrices { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".occurrences-card__spinner")]
        private IWebElement OccurrencesSpinner { get; set; }

      //  public IList<UpdatePrices> UpdatePriceWindow => this.UpdatePrices.Select(p => new UpdatePrices(p, Driver)).ToList();

        public IList<MassUpdateSearchResultCard> ResultCards
        {
            get
            {
                var cards = this.SearchResultCard.Select(p => new MassUpdateSearchResultCard(p, Driver)).ToList();
                List<MassUpdateSearchResultCard> ExpandedCards = cards.Where(x => x.IsExpanded).ToList();
                for (int i = 0; i < ExpandedCards.Count; i++)
                {
                    ExpandedCards[i].AssociateOccurrence(OccurrencesCard[i]);
                }
                return cards;
            }
        }

        public string ResultMessageText => SearchResultsMessage.Text;
        public string NoResultMessageText => NoResultsMessage.Text;

        public MassUpdateSearchResultCard GetRecipe(string name)
        {
            if (!ResultCards.Any(x => x.RecipeName.ToUpper() == name.ToUpper()))
            {
                throw new Exception($"Recipe {name} not found !");
            }
            return ResultCards.First(x => x.RecipeName.ToUpper() == name.ToUpper());
        }

        public void WaitForPageToLoad()
        {
            Driver.WaitElementToExists(SearchInput);
        }

        public void EnterKeywordInSearch(string text)
        {
            SearchInput.SendKeys(text);
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

        public void SelectAllRecipes()
        {
            if (!SelectAllCheckbox.Selected)
            {
                SelectAllCheckbox.Click();
            }
        }

        public void DeselectAllRecipes()
        {
            if (SelectAllCheckbox.Selected)
            {
                SelectAllCheckbox.Click();
            }
        }

        public void SelectUpdatePriceButton()
        {
            UpdatePriceButton.Click();
        }

        public void WaitForOccurrencesToLoad()
        {
            Driver.WaitElementToDisappear(OccurrencesSpinner);
        }
    }
}
