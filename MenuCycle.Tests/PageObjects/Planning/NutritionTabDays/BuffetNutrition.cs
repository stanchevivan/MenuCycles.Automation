using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class BuffetNutrition : NutritionScreenRecipe
    {
        private readonly IArtefacts Artefacts;
        public BuffetNutrition(IWebElement parent, string mealPeriodName, IWebDriver webdriver, IArtefacts artefacts) : base(parent, mealPeriodName, webdriver, artefacts)
        {
            PageFactory.InitElements(webdriver, parent);
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        private  IList<IWebElement> Items { get; set; }

        public IList<NutritionScreenRecipe> Recipes => this.Items.Select(p => new NutritionScreenRecipe(p, MealPeriodName, Driver, Artefacts)).ToList().GetRange(1, Items.Count - 1);

        public NutritionScreenRecipe GetRecipe(string title)
        {
            if (!Recipes.Any(x => x.Title == title))
            {
                throw new System.Exception($"No such recipe {title}");
            }
            return Recipes.First(x => x.Title == title);
        }
    }
}