using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class NestedRecipePostProduction : RecipePostProduction
    {

        public NestedRecipePostProduction(IWebElement parent, string mealPeriodName, IWebDriver webDriver, IArtefacts artefacts) : base(parent, mealPeriodName, webDriver, artefacts)
        {
            PageFactory.InitElements(parent, this);
        }

        public override string Title => base.title.Text;

    }
}