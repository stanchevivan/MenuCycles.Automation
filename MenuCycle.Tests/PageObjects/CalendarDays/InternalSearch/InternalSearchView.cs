using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class InternalSearchView : MenuCyclesBasePage
    {
        public InternalSearchView(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".icon-search")]
        private IWebElement InternalSearchIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mc-internal-search-comp .ui-autocomplete-input")]
        private IWebElement InternalSearchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".internal-mc-searchbox-button")]
        private IWebElement InternalSearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".internal-search-results-body-item-container")]
        private IList<IWebElement> searchResults { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".internal-search-results-table")]
        private IWebElement SearchResultsTable { get; set; }

        IList<InternalSearchResultsLine> SearchResults => this.searchResults.Select(p => new InternalSearchResultsLine(p)).ToList();

        public void ClickSearchIcon()
        {
            InternalSearchIcon.Click();
        }

        public void EnterSearchCriteria(string text)
        {
            InternalSearchInput.ClearAndSendKeys(text);
        }

        public void ClickSearchButton()
        {
            InternalSearchButton.Click();

        }

        public void WaitForLoad()
        {
            WaitSpinnerToDisappear();
            Driver.WaitElementToExists(SearchResultsTable);
        }

        public InternalSearchResultsLine GetLine(string recipeName, string weekName)
        {
            return SearchResults.First(x => x.RecipeName == recipeName && x.Week == weekName);
        }
    }
}