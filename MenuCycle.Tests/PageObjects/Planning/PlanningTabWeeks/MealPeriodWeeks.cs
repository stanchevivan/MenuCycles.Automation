using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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
