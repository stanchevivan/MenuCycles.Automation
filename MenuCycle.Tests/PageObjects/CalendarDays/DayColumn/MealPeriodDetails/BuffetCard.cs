using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class BuffetCard : RecipeCard
    {
        public BuffetCard(IWebElement parent) : base(parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".expandMenu")]
        private IWebElement expandArrow { get; set; }
        [FindsBy(How = How.CssSelector, Using = ":root .menu-expand:not([style='display: none;']) .menu-recipe-expand")]
        private IList<IWebElement> expandedRecipes { get; set; }

        public IList<ExpandedRecipe> ExpandedRecipes => this.expandedRecipes.Select(x => new ExpandedRecipe(x)).ToList();

        public void Expand()
        {
            System.Threading.Thread.Sleep(9000);
            expandArrow.Click();
        }
    }
}
