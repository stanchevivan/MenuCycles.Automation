using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class NestedRecipePostProduction : RecipePostProduction
    {

        public NestedRecipePostProduction(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(parent, mealPeriodName, webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        public override string Title => base.title.Text;

    }
}