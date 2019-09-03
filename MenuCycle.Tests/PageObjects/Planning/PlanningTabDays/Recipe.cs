using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class Recipe : MenuCyclesBasePage
    {
        public string MealPeriodName { get; set; }

        public Recipe(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
            this.MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:first-of-type")]
        protected IWebElement type { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title")]
        protected IWebElement title { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".update-prices")]
        private IWebElement updatePrices { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".add-type")]
        private IWebElement addTypeButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-data__row")]
        private IList<IWebElement> RecipeRows { get; set; }

        public virtual IList<RecipeRow> Rows => RecipeRows.Select(p => new RecipeRow(p, Driver)).ToList();

        public virtual string Type => this.type.Text;
        public virtual string Title => this.title.Text.Remove(0, 9);
        public virtual string Colour => this.type.GetCssValue("color");

        public void AddType()
        {
            this.addTypeButton.Click();
        }

        public virtual RecipeRow GetFirstRow()
        {
            return Rows.First();
        }

        public RecipeRow GetTariffTypeRow(string tariffType)
        {
            return Rows.First(x => x.TariffType == tariffType);
        }

        public Recipe UseUpdatePricesButton()
        {
            this.updatePrices.Click();

            return this;
        }
    }
}