using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class ExpandedRecipe
    {
        public ExpandedRecipe(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".item-name")]
        private IWebElement name { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".menu-recipe-text-cost")]
        private IWebElement cost { get; set; }

        public string Name => this.name.Text;
        public string Cost => this.cost.Text.Replace('•', ' ').Trim();
    }
}
