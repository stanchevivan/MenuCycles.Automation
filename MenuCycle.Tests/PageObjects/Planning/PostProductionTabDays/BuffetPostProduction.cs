using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class BuffetPostProduction : RecipeRowPostProduction
    {
        public string MealPeriodName;
        private readonly IArtefacts Artefacts;

        public BuffetPostProduction(IWebElement parent, string mealPeriodName, IWebDriver webDriver, IArtefacts artefacts) : base(parent, webDriver, artefacts)
        {
            Artefacts = artefacts;
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-card")]
        private  IList<IWebElement> Items { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title")]
        protected IWebElement title { get; set; }

        public IList<NestedRecipePostProduction> Recipes => this.Items.Select(p => new NestedRecipePostProduction(p, MealPeriodName, Driver, Artefacts)).ToList().GetRange(1, Items.Count - 1);

        public string Title => this.title.Text.Remove(0, 9);

        public NestedRecipePostProduction GetRecipe(string title)
        {
            if (!Recipes.Any(x => x.Title == title))
            {
                throw new System.Exception($"No such recipe {title}");
            }
            return Recipes.First(x => x.Title == title);
        }
    }
}