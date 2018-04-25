using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    /// <summary>
    /// Recipes inside Buffets or A La Cartes. (NOT single recipes)
    /// </summary>
    public class NestedRecipe : Recipe
    {
        public NestedRecipe(IWebElement parent, string mealPeriodName) : base(parent, mealPeriodName)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:first-of-type")]
        IWebElement title { get; set; }

        public override string Title => this.title.Text;
        public override string Colour => this.title.GetCssValue("color");
    }
}