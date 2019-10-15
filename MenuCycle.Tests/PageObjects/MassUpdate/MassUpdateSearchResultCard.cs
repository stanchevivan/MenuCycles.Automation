using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MassUpdateSearchResultCard : MenuCyclesBasePage
    {
        public MassUpdateSearchResultCard(IWebElement parent,IWebDriver webDriver) : base(webDriver)
        {
			PageFactory.InitElements(parent, this);
		}

		[FindsBy(How = How.CssSelector, Using = ".search-results-card__side-left .search-results-card__cell:last-of-type")]
        private IWebElement RecipeCardName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-card__cell .mc-checkbox")]
        private IWebElement RecipeCardCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-results-card .search-results-card__arrow-icon")]
        private IWebElement OccurrencesArrow { get; set; }

        private IWebElement occurrencesCard { get; set; }

        public MassUpdateOccurrencesCard OccurrencesCard => new MassUpdateOccurrencesCard(occurrencesCard, Driver);

        public string RecipeName => RecipeCardName.Text;

        public bool IsExpanded => OccurrencesArrow.Get().HasClass("icon-chevron-up");

        public void AssociateOccurrence(IWebElement occurrenceCard)
        {
            this.occurrencesCard = occurrenceCard;
        }

        public MassUpdateOccurrencesRow GetRow(string weekName, string weekDay, string mealPeriod)
        {
            return OccurrencesCard.OccurrancesRows.First(x => x.WeekNameText == weekName
            && x.DayNameText == weekDay
            && x.MealPeriodNameText == mealPeriod);
        }

        public void ClickArrow()
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
