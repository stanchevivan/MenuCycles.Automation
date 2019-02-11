using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class BuffetPostProduction : RecipeRowPostProduction
    {
        public string MealPeriodName;

        public BuffetPostProduction(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(parent, webDriver)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        private  IList<IWebElement> Items { get; set; }

        public IList<RecipePostProduction> Recipes => this.Items.Select(p => new RecipePostProduction(p, MealPeriodName, Driver)).ToList().GetRange(1, Items.Count - 1);

        public string Title => new RecipePostProduction(Items[0], MealPeriodName, Driver).Title;

        public RecipePostProduction GetRecipe(string title)
        {
            if (!Recipes.Any(x => x.Title == title))
            {
                throw new System.Exception($"No such recipe {title}");
            }
            return Recipes.First(x => x.Title == title);
        }
    }
}