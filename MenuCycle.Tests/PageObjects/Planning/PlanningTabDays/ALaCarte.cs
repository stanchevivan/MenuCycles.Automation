using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class ALaCarte : Recipe
    {
        public ALaCarte(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(parent, mealPeriodName, webDriver)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        private IList<IWebElement> Items { get; set; }

        public IList<NestedRecipe> Recipes => this.Items.Select(p => new NestedRecipe(p, MealPeriodName, Driver)).ToList().GetRange(1, Items.Count - 1);

        public override string Type => new Recipe(Items[0], MealPeriodName, Driver).Type;
        public override string Title => new Recipe(Items[0], MealPeriodName, Driver).Title;

        public NestedRecipe GetRecipe(string title)
        {
            if (!Recipes.Any(x => x.Title == title))
            {
                throw new System.Exception($"No such recipe {title}");
            }
            return Recipes.First(x => x.Title == title);
        }

        public NestedRecipe GetRecipe(string title, string tariffType)
        {
            if (!Recipes.Any(x => x.Title == title && x.GetFirstRow().TariffType == tariffType))
            {
                throw new System.Exception($"No such recipe {title}, tariff {tariffType}");
            }
            return Recipes.First(x => x.Title == title && x.GetFirstRow().TariffType == tariffType);
        }
    }
}