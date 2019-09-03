using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeNutrition : RecipeDetailsView
    {
        public RecipeNutrition(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            PageFactory.InitElements(Driver, this);
        }

    }
}
