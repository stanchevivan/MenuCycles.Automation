using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    /// <summary>
    /// Recipes inside Buffets or A La Cartes. (NOT single recipes)
    /// </summary>
    public class NestedRecipe : Recipe
    {
        public NestedRecipe(IWebElement parent, string mealPeriodName, IWebDriver webDriver, IArtefacts artefacts) : base(parent, mealPeriodName, webDriver, artefacts)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span")]
        private new IWebElement title { get; set; }

        public override string Colour => this.type.GetCssValue("color");
        public override string Title => this.title.Text;
    }
}