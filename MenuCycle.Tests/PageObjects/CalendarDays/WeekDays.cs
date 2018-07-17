using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class WeekDays
    {
        public WeekDays(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-calendar-heading")]
        private IWebElement name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mealPeriodButtons")]
        private IWebElement MealPeriodButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning")]
        private IWebElement DailyPlanningButton { get; set; }

        public string Name => name.Text;

        public void UseMealPeriodButton()
        {
            MealPeriodButton.Click();
        }
    }
}
