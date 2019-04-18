using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class WeeklyDayContainer
    {
        public bool IsNonServingDay;

        public WeeklyDayContainer(IWebElement parent, bool isNonServingDay)
        {
            PageFactory.InitElements(parent, this);
            IsNonServingDay = isNonServingDay;
        }

        [FindsBy(How = How.ClassName, Using = "weekly-mealperiod-container")]
        private IList<IWebElement> WeeklyMealPeriodContainer { get; set; }

        public void ClickMealPeriod(string name)
        {
            WeeklyMealPeriodContainer.First(x => x.Text == name).Click();
        }
    }
}

