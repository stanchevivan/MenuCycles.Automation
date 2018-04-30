using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class Recipe
    {
        public string MealPeriodName { get; set; }

        public Recipe(IWebElement parent, string mealPeriodName)
        {
            PageFactory.InitElements(parent, this);
            this.MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-header__title-type")]
        IWebElement type { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:last-of-type")]
        IWebElement title { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(1) > *")]
        IWebElement plannedQuantity { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(2) > *")]
        IWebElement costPerUnit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(3) > *")]
        IWebElement totalCosts { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(4) > *")]
        IWebElement tariffType { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(5) > *")]
        IWebElement priceModel { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(6) > *")]
        IWebElement targetGP { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(7) > *")]
        IWebElement taxPercentage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(8) > *")]
        IWebElement sellPrice { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(9) > *")]
        IWebElement revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(10) > *")]
        IWebElement actualGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-bin")]
        IWebElement deleteType { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".update-prices > span:nth-of-type(2)")]
        IWebElement updatePrices { get; set; }

        public virtual string Type => this.type.Text;
        public virtual string Title => this.title.Text;
        public virtual string Colour => this.type.GetCssValue("color");

        public string PlannedQuantity { get => this.plannedQuantity.GetAttribute("value"); set => this.plannedQuantity.SendKeys(value); }

        public string CostPerUnit => this.costPerUnit.Text;

        public string TotalCosts => this.totalCosts.Text.Replace("-", string.Empty);

        public string TariffType { 
            get => new SelectElement(this.tariffType).SelectedOption.Text;
            set => new SelectElement(this.tariffType).SelectByText(value); }
        public string PriceModel {
            get => new SelectElement(this.priceModel).SelectedOption.Text;
            set => new SelectElement(this.priceModel).SelectByText(value);
        }
        public string TargetGP { get => this.targetGP.GetAttribute("value"); set => this.targetGP.SendKeys(value); }
        public string TaxPercentage {
            get => new SelectElement(this.taxPercentage).SelectedOption.Text;
            set => new SelectElement(this.taxPercentage).SelectByText(value);
        }
        public string SellPrice { get => this.sellPrice.GetAttribute("value"); set => this.sellPrice.SendKeys(value); }

        public string Revenue => this.revenue.Text;
        public string ActualGP => this.actualGP.Text;

        public void AddType()
        {
            this.type.Click();
        }

        // TODO: Need to handle multiple types
        public void DeleteType()
        {
            this.deleteType.Click();
        }

        public void UpdatePrices()
        {
            this.updatePrices.Click();
        }
    }
}