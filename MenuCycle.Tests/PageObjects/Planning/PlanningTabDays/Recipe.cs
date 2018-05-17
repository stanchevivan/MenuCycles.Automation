using MenuCycle.Tests.Models;
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
        private IWebElement type { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:last-of-type")]
        private IWebElement title { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(1) > *")]
        private IWebElement plannedQuantity { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(2) > *")]
        private IWebElement costPerUnit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(3) > *")]
        private IWebElement totalCosts { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(4) > *")]
        private IWebElement tariffType { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(5) > *")]
        private IWebElement priceModel { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(6) > *")]
        private IWebElement targetGP { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(7) > *")]
        private IWebElement taxPercentage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(8) > *")]
        private IWebElement sellPrice { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(9) > *")]
        private IWebElement revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-data__row > div:nth-of-type(10) > *")]
        private IWebElement actualGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-bin")]
        private IWebElement deleteType { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".update-prices > span:nth-of-type(2)")]
        private IWebElement updatePrices { get; set; }
        [FindsBy(How = How.ClassName, Using = "border-error")]
        private IWebElement BorderError { get; set; }

        public virtual string Type => this.type.Text;
        public virtual string Title => this.title.Text;
        public virtual string Colour => this.type.GetCssValue("color");

        public string PlannedQuantity { get => this.plannedQuantity.GetAttribute("value"); set => this.plannedQuantity.Do().ClearAndSendKeys(value); }

        public string CostPerUnit => this.costPerUnit.Text;

        public string TotalCosts => this.totalCosts.Text.Replace("-", string.Empty);

        public string TariffType
        {
            get => new SelectElement(this.tariffType).SelectedOption.Text;
            set => new SelectElement(this.tariffType).SelectByText(value);
        }
        public string PriceModel
        {
            get => new SelectElement(this.priceModel).SelectedOption.Text;
            set => new SelectElement(this.priceModel).SelectByText(value);
        }
        public string TargetGP { get => this.targetGP.GetAttribute("value"); set => this.targetGP.Do().ClearAndSendKeys(value); }
        public bool IsTargetGPPresent => targetGP.Get().ElementPresent;

        public string TaxPercentage
        {
            get => new SelectElement(this.taxPercentage).SelectedOption.Text;
            set => new SelectElement(this.taxPercentage).SelectByText(value);
        }

        public string SellPrice { get => this.sellPrice.GetAttribute("value"); set => this.sellPrice.Do().ClearAndSendKeys(value); }

        // May need another check
        public bool IsSellPriceEditable => sellPrice.Enabled;

        public string Revenue => this.revenue.Text;
        public string ActualGP => this.actualGP.Text;

        public bool IsPlannedQuantityWithRedBorder => plannedQuantity.Get().HasClass("border-error");
        public bool SellPriceHasRedBorder => sellPrice.Get().HasClass("border-error");

        public RecipeModel GetDTO()
        {
            return new RecipeModel
            {
                MealPeriodName = this.MealPeriodName,
                RecipeTitle = this.Title,
                PlannedQuantity = this.PlannedQuantity,
                CostPerUnit = this.CostPerUnit,
                TotalCosts = this.TotalCosts,
                Type = this.Type,
                PriceModel = this.PriceModel,
                TargetGP = this.TargetGP,
                TaxPercentage = this.TaxPercentage,
                SellPrice = this.SellPrice,
                Revenue = this.Revenue,
                ActualGP = this.ActualGP
            };
        }

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