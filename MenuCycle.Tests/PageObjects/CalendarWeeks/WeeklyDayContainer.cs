using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class WeeklyDayContainer
    {
        public bool IsGAPDay;

        public WeeklyDayContainer(IWebElement parent, bool isNonServingDay)
        {
            PageFactory.InitElements(parent, this);
            IsGAPDay = isNonServingDay;
        }

        [FindsBy(How = How.ClassName, Using = "weekly-mealperiod-container")]
        private IList<IWebElement> WeeklyMealPeriodContainer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='GAP DAY']")]
        private IWebElement GAPDayLabel { get; set; }

        public bool IsGAPDayLabelPresent => GAPDayLabel.Get().ElementPresent;
        public IList<string> MealPeriodNames => WeeklyMealPeriodContainer.Select(x => x.Text).ToList();

        public void ClickMealPeriod(string name)
        {
            WeeklyMealPeriodContainer.First(x => x.Text == name).Click();
        }
    }
}

