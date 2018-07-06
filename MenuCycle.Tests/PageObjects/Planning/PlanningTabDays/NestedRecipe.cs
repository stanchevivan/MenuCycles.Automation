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
        public override string Colour => this.type.GetCssValue("color");
    }
}