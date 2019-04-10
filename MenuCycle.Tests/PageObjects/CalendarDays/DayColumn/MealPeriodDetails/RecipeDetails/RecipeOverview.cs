using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeOverview : RecipeDetailsView
    {
        public RecipeOverview(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-overview-row-section > div")]
        private IList<IWebElement> ingredients { get; set; }
        [FindsBy(How = How.ClassName, Using = "showRecipeDetail")]
        private IWebElement DetailedView { get; set; }
        [FindsBy(How = How.ClassName, Using = "modal-backdrop-mp")]
        private IWebElement Backdrop { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-overview-detail-row-footer .overview-desccription-col-cost")]
        private IWebElement TotalCost { get; set; }


        public IList<Ingredient> Ingredients => ingredients.Select(p => new Ingredient(p)).ToList();

        public string TotalCostText => TotalCost.Text;

        public void WaitForLoad()
        {
            // TODO: delete commented backdrop wait if not needed
            //Driver.WaitElementToDisappear(Backdrop);
            Driver.WaitElementToExists(DetailedView);
        }

    }
}
