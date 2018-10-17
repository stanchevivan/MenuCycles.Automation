using System.Collections;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Fourth.Automation.Framework.Extension;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycle.Tests.PageObjects
{
    public class MealPeriodWeeklyCard
    {
        public MealPeriodWeeklyCard(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "weekly-mealperiod-container")]
        private IList<IWebElement> WeeklyMealPeriod { get; set; }

    }
}
