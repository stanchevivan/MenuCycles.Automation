using System.Collections.Generic;
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

    }
}

