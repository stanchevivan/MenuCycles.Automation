using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MealPeriodDays
    {
        public MealPeriodDays(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "icon-chevron-up")]
        private IWebElement CollapseArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-chevron-down")]
        private IWebElement ExpandArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__name")]
        private IWebElement MealPeriodName { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-main")]
        private IWebElement MealPeriodMain { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-wrapper")]
        private IWebElement Wrapper { get; set; }

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
