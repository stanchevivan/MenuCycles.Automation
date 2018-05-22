using MenuCycle.Tests.Models;
using NUnit.Framework;
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

        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:first-of-type")]
        protected IWebElement type { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-header__title > span:last-of-type")]
        private IWebElement title { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".quantity > .recipe-data__cell")]
        private IWebElement plannedQuantity { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".cost > .recipe-data__text-cell")]
        private IWebElement costPerUnit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".total-cost > .recipe-data__text-cell")]
        private IWebElement totalCosts { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-type")]
        private IWebElement tariffType { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-price-model")]
        private IWebElement priceModel { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".target > *")]
        private IWebElement targetGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-tax")]
        private IWebElement taxPercentage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price > *")]
        private IWebElement sellPrice { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".revenue > .recipe-data__text-cell")]
        private IWebElement revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".actual-gp > .recipe-data__text-cell")]
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

        public string PlannedQuantity 
        { 
            get => this.plannedQuantity.GetAttribute("value"); 
            set => this.plannedQuantity.Do().ClearAndSendKeys(value);
        }

        public string CostPerUnit => this.costPerUnit.Text;

        public string TotalCosts => this.totalCosts.Text.Replace("-", string.Empty);

        public string TariffType
        {
            get => new SelectElement(this.tariffType).SelectedOption.Text.Trim();
            set => new SelectElement(this.tariffType).SelectByText(value);
        }
        public string PriceModel
        {
            get => new SelectElement(this.priceModel).SelectedOption.Text.Trim();
            set => new SelectElement(this.priceModel).SelectByText(value);
        }
        public string Target 
        { 
            get => this.targetGP.TagName == "span" ? this.targetGP.Text : this.targetGP.GetAttribute("value");
            set => this.targetGP.Do().ClearAndSendKeys(value);
        }
        public bool IsTargetGPPresent => targetGP.Get().ElementPresent;

        public string TaxPercentage
        {
            get => new SelectElement(this.taxPercentage).SelectedOption.Text.Trim();
            set => new SelectElement(this.taxPercentage).SelectByText(value);
        }

        public string SellPrice
        { 
            get => this.sellPrice.TagName == "span" ? this.sellPrice.Text : this.sellPrice.GetAttribute("value");
            set => this.sellPrice.Do().ClearAndSendKeys(value);
        }

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
                Type = this.Type,
                RecipeTitle = this.Title,
                PlannedQuantity = this.PlannedQuantity,
                CostPerUnit = this.CostPerUnit,
                TotalCosts = this.TotalCosts,
                PriceModel = this.PriceModel,
                Target = this.Target,
                TaxPercentage = this.TaxPercentage,
                SellPrice = this.SellPrice,
                Revenue = this.Revenue,
                ActualGP = this.ActualGP,
                TariffType = this.TariffType
            };
        }

        public void SetData(RecipeModel dto)
        {
            if (!string.IsNullOrEmpty(dto.PlannedQuantity)) this.PlannedQuantity = dto.PlannedQuantity;

            if (!string.IsNullOrEmpty(dto.TariffType)) this.TariffType = dto.TariffType;

            if (!string.IsNullOrEmpty(dto.PriceModel)) this.PriceModel = dto.PriceModel;

            if (!string.IsNullOrEmpty(dto.Target))
            {
                if (this.PriceModel == "GP" || this.PriceModel == "Markup")
                {
                    this.Target = dto.Target;
                }
                else
                {
                    throw new System.Exception($"Price model is {this.PriceModel} (Target field is not present)!");
                }
            }

            if (!string.IsNullOrEmpty(dto.TaxPercentage)) this.TaxPercentage = dto.TaxPercentage;

            if (!string.IsNullOrEmpty(dto.SellPrice))
            {
                if (this.PriceModel == "Fixed")
                {
                    this.SellPrice = dto.SellPrice;
                }
                else
                {
                    throw new System.Exception($"Price model is {this.PriceModel} (Sell Price field is not present)!");
                }
            }
        }

        public void VerifyData(RecipeModel dto)
        {
            if (!string.IsNullOrEmpty(dto.PlannedQuantity))
            {
                Assert.That(this.PlannedQuantity, Is.EqualTo(dto.PlannedQuantity));
            }

            if (!string.IsNullOrEmpty(dto.CostPerUnit))
            {
                Assert.That(this.CostPerUnit, Is.EqualTo(dto.CostPerUnit));
            }

            if (!string.IsNullOrEmpty(dto.TotalCosts))
            {
                Assert.That(this.TotalCosts, Is.EqualTo(dto.TotalCosts));
            }

            if (!string.IsNullOrEmpty(dto.TariffType))
            {
                Assert.That(this.TariffType, Is.EqualTo(dto.TariffType));
            }

            if (!string.IsNullOrEmpty(dto.PriceModel))
            {
                Assert.That(this.PriceModel, Is.EqualTo(dto.PriceModel));
            }

            if (!string.IsNullOrEmpty(dto.Target))
            {
                Assert.That(this.Target, Is.EqualTo(dto.Target));
            }

            if (!string.IsNullOrEmpty(dto.TaxPercentage))
            {
                Assert.That(this.TaxPercentage, Is.EqualTo(dto.TaxPercentage));
            }

            if (!string.IsNullOrEmpty(dto.SellPrice))
            {
                Assert.That(this.SellPrice, Is.EqualTo(dto.SellPrice));
            }

            if (!string.IsNullOrEmpty(dto.Revenue))
            {
                Assert.That(this.Revenue, Is.EqualTo(dto.Revenue));
            }

            if (!string.IsNullOrEmpty(dto.ActualGP))
            {
                Assert.That(this.ActualGP, Is.EqualTo(dto.ActualGP));
            }
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