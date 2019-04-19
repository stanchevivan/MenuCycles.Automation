using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class InternalSearchResultsLine
    {
        public InternalSearchResultsLine(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-name")]
        private IWebElement recipeName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".week")]
        private IWebElement week { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day")]
        private IWebElement day { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mealperiod")]
        private IWebElement mealperiod { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menu")]
        private IWebElement menu { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuName")]
        private IWebElement menuName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".view-item")]
        private IWebElement ViewLink { get; set; }

        public string RecipeName => recipeName.Text;
        public string Week => week.Text;
        public string Day => day.Text;
        public string MealPeriod => mealperiod.Text;
        public string Menu => menu.Text;
        public string MenuName => menuName.Text;

        public void ViewRecipe()
        {
            ViewLink.Click();
        }
    }
}
