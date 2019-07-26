using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class RecipePostProduction : Recipe
    {

        public RecipePostProduction(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(parent, mealPeriodName, webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__small")]
        protected IList<IWebElement> BuffetRecipes { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-data__row")]
        private IList<IWebElement> RecipeRows { get; set; }

        public new IList<RecipeRowPostProduction> Rows => RecipeRows.Select(p => new RecipeRowPostProduction(p, Driver)).ToList();

        public bool IsBuffet => this.BuffetRecipes.Count > 0;

        public new RecipeRowPostProduction GetFirstRow()
        {
            return Rows[0];
        }

        public RecipeRowPostProduction GetRow(string tariffName)
        {
            return Rows.First(x => x.TariffName == tariffName);
        }
    }
}