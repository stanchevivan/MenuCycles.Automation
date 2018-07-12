using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class ALaCarteCard : RecipeCard
    {
        public ALaCarteCard(IWebElement parent) : base(parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".expandMenu")]
        private IWebElement expandArrow { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".menu-recipe-expand")]
        private IList<IWebElement> expandedRecipes { get; set; }

        public IList<ExpandedRecipe> ExpandedRecipes => this.expandedRecipes.Select(x => new ExpandedRecipe(x)).ToList();
    }
}
