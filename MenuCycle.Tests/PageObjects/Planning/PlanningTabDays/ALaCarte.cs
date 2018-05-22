using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class ALaCarte : Recipe
    {
        public ALaCarte(IWebElement parent, string mealPeriodName) : base(parent, mealPeriodName)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        IList<IWebElement> Items { get; set; }

        public IList<NestedRecipe> Recipes => this.Items.Select(p => new NestedRecipe(p, MealPeriodName)).ToList().GetRange(1, Items.Count - 1);

        public override string Type => new Recipe(Items[0], MealPeriodName).Type;
        public override string Title => new Recipe(Items[0], MealPeriodName).Title;

        public NestedRecipe GetRecipe(string title)
        {
            if (!Recipes.Any(x => x.Title == title))
            {
                throw new System.Exception($"No such recipe {title}");
            }
            return Recipes.First(x => x.Title == title);
        }
    }
}