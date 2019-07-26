using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    /// <summary>
    /// Recipes inside Buffets or A La Cartes. (NOT single recipes)
    /// </summary>
    public class NestedRecipe : Recipe
    {
        public NestedRecipe(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(parent, mealPeriodName, webDriver)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span")]
        private IWebElement title { get; set; }

        public override string Colour => this.type.GetCssValue("color");
        public override string Title => this.title.Text;
    }
}