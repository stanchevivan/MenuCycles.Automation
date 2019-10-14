using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.MassUpdate
{
    public class MassUpdateSearchResultCard : MenuCyclesBasePage
    {
        public MassUpdateSearchResultCard(IWebElement parent,IWebDriver webDriver) : base(webDriver)
        {
			PageFactory.InitElements(parent, this);
		}

		[FindsBy(How = How.CssSelector, Using = ".search-results-card__cell:last-of-type")]
        private IWebElement RecipeCardName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-card__cell .mc-checkbox")]
        private IWebElement RecipeCardCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-card .search-results-card__arrow-icon")]
        private IWebElement OccurrencesArrow { get; set; }

        public string RecipeName => RecipeCardName.Text;

        public void ClickOccurencesArrow()
        {
            OccurrencesArrow.Click();
        }

        public void SelectRecipeCard()
        {
            if (!RecipeCardCheckbox.Selected)
            {
                RecipeCardCheckbox.Click();
            }
        }

        public void DeselectRecipeCard()
        {
            if (RecipeCardCheckbox.Selected)
            {
                RecipeCardCheckbox.Click();
            }
        }
    }
}
