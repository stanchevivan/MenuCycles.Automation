using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MealPeriodWeeks
    {
        public MealPeriodWeeks(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

    }
}
