using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeIntolerance : RecipeDetailsView
    {
        public RecipeIntolerance(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            PageFactory.InitElements(Driver, this);
        }

    }
}
