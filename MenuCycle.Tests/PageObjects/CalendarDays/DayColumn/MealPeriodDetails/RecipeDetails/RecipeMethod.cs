using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeMethod : RecipeDetailsView
    {
        public RecipeMethod(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            PageFactory.InitElements(Driver, this);
        }

    }
}
