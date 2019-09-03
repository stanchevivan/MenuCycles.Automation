using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class ALaCarte : Recipe
    {
        private readonly IArtefacts Artefacts;

        public ALaCarte(IWebElement parent, string mealPeriodName, IWebDriver webDriver, IArtefacts artefacts) : base(parent, mealPeriodName, webDriver, artefacts)
        {
            Artefacts = artefacts;
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        private IList<IWebElement> Items { get; set; }

        public IList<NestedRecipe> Recipes => this.Items.Select(p => new NestedRecipe(p, MealPeriodName, Driver, Artefacts)).ToList().GetRange(1, Items.Count - 1);

        public override string Title => title.Text.Remove(0, 13);

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