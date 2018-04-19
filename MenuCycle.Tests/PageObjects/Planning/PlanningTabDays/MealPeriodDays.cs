using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MealPeriodDays
    {
        public MealPeriodDays(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "icon-chevron-up")]
        IWebElement CollapseArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-chevron-down")]
        IWebElement ExpandArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__name")]
        IWebElement MealPeriodName { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-main")]
        IWebElement MealPeriodMain { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-wrapper")]
        IWebElement Wrapper { get; set; }

        public string Name => MealPeriodName.Text;
        public string Colour => Wrapper.GetCssValue("background-color");
        public bool IsExpanded => MealPeriodMain.Get().ElementPresent();

        public void Expand()
        {
            ExpandArrow.Click();
        }

        public void Collapse()
        {
            CollapseArrow.Click();
        }
    }
}
