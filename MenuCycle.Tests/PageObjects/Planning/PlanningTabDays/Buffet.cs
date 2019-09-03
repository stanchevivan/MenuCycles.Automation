using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class Buffet : Recipe
    {
        private readonly IArtefacts Artefacts;

        public Buffet(IWebElement parent, string mealPeriodName, IWebDriver webDriver, IArtefacts artefacts) : base(parent, mealPeriodName, webDriver, artefacts)
        {
            Artefacts = artefacts;
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        protected  IList<IWebElement> Items { get; set; }

        public IList<NestedRecipe> Recipes => this.Items.Select(p => new NestedRecipe(p, MealPeriodName, Driver, Artefacts)).ToList().GetRange(1, Items.Count - 1);

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