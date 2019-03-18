using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class NutritionScreenRecipe : MenuCyclesBasePage
    {
        public string MealPeriodName { get; set; }

        public NutritionScreenRecipe(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
            this.MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__small")]
        protected IList<IWebElement> BuffetRecipes { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:last-of-type")]
        private IWebElement title { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-data__row")]
        private IList<IWebElement> RecipeRows { get; set; }

        public IList<RecipeRowNutrition> Rows => RecipeRows.Select(p => new RecipeRowNutrition(p, Driver)).ToList();

        public bool IsBuffet => this.BuffetRecipes.Count > 0;
        public virtual string Title => this.title.Text;

        public RecipeRowNutrition GetFirstRow()
        {
            return Rows[0];
        }
    }
}