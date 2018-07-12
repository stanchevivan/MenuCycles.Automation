using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    // TODO: public IWebElements => private
    public class MealPeriodCard
    {
        IWebElement parent;

        public MealPeriodCard(IWebElement parent)
        {
            this.parent = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-title")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-item-contain > div > div")]
        public IList<IWebElement> Recipes { get; set; }

        public void OpenMealPeriodDetails()
        {
            Name.Click();
        }

        public string Colour => parent.GetCssValue("background-color");
    }
}
