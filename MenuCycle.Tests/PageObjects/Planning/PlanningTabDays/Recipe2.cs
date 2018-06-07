using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class Recipe2
    {
        public string MealPeriodName { get; set; }

        public Recipe2(IWebElement parent, string mealPeriodName)
        {
            PageFactory.InitElements(parent, this);
            this.MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:first-of-type")]
        protected IWebElement type { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:last-of-type")]
        private IWebElement title { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".update-prices > span:nth-of-type(2)")]
        private IWebElement updatePrices { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-data__row")]
        private IList<IWebElement> itemLines { get; set; }

        public IList<ItemLine> Lines => this.itemLines.Select(p => new ItemLine(p)).ToList();

        public virtual string Type => this.type.Text;
        public virtual string Title => this.title.Text;
        public virtual string Colour => this.type.GetCssValue("color");

        public void AddType()
        {
            this.type.Click();
        }

        public void UpdatePrices()
        {
            this.updatePrices.Click();
        }

        public ItemLine GetLine(string type)
        {
            return Lines.First(x => x.TariffType == type);
        }

        public ItemLine GetLine()
        {
            return Lines.First();
        }
    }
}