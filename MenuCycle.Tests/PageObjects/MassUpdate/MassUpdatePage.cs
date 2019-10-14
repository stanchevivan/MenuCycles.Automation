﻿using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace MenuCycle.Tests.PageObjects.MassUpdate
{
    public class MassUpdatePage : MenuCyclesBasePage
    {
        public MassUpdatePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".search-bar__input")]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-bar__button")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-utility-bar__message")]
        private IWebElement SearchResultsMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-card")]
        private IList<IWebElement> SearchResultCard { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".occurrences-card")]
        private IList<IWebElement> OccurrencesCard { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-header .mc-checkbox__checkmark")]
        private IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mass-update__message")]
        private IWebElement NoResultsMessage { get; set; }


        public IList<MassUpdateSearchResultCard> ResultCards => this.SearchResultCard.Select(p => new MassUpdateSearchResultCard(p, Driver)).ToList();
        public string ResultMessageText => SearchResultsMessage.Text;
        public string NoResultMessageText => NoResultsMessage.Text;

        public MassUpdateSearchResultCard GetResultCard(string name)
        {
            if (!ResultCards.Any(x => x.RecipeName == name.ToUpper()))
            {
                throw new Exception($"Recipe {name} not found !");
            }
            return ResultCards.First(x => x.RecipeName == name.ToUpper());
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
    }
}
