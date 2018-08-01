using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DayColumn
    {
        public string DayName;

        public DayColumn(IWebElement parent, string dayName)
        {
            this.DayName = dayName;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-container-div")]
        private IList<IWebElement> MealPeriodCardContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "gap-day-text-in-dailyview-width-manager-text")]
        private IWebElement GapDayText { get; set; }

        public IList<MealPeriodCard> MealPeriodCards => this.MealPeriodCardContainer.Select(p => new MealPeriodCard(p)).ToList();
        public bool IsGapDay => GapDayText.Displayed;

        public MealPeriodCard GetMealPeriodCard(string mealPeriodName)
        {
            return MealPeriodCards.First(x => x.Name == mealPeriodName);
        }
    }
}