using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DayColumn
    {
        public DayColumn(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-container-div")]
        private IList<IWebElement> MealPeriodCardContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "gap-day-text-in-dailyview-width-manager-text")]
        private IWebElement GapDayText { get; set; }

        [FindsBy(How = How.TagName, Using = "table")]
        private IWebElement DailyCalendarTable { get; set; }

        public IList<MealPeriodCard> MealPeriodCards => this.MealPeriodCardContainer.Select(p => new MealPeriodCard(p)).ToList();
        public bool IsGapDay => GapDayText.Displayed;
        public string DayName
        {
            get
            {
                var classes = DailyCalendarTable.Get().Classes;

                return new Dictionary<string, string>
                {
                    { "calanderDay0","MONDAY" },
                    { "calanderDay1","TUESDAY"},
                    { "calanderDay2","WEDNESDAY"},
                    { "calanderDay3","THURSDAY"},
                    { "calanderDay4","FRIDAY" },
                    { "calanderDay5","SATURDAY"},
                    { "calanderDay6","SUNDAY" }
                }
                .First(x => classes.Contains(x.Key)).Value;
            }
        }

        public MealPeriodCard GetMealPeriodCard(string mealPeriodName)
        {
            return MealPeriodCards.First(x => x.Name == mealPeriodName);
        }
    }
}