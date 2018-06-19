using MenuCycle.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class RecipeRow
    {
        public RecipeRow(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".quantity > div > .input-cell")]
        private IWebElement plannedQuantity { get; set; }
        [FindsBy(How = How.ClassName, Using = "cost")]
        private IWebElement costPerUnit { get; set; }
        [FindsBy(How = How.ClassName, Using = "total-cost")]
        private IWebElement totalCosts { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-type")]
        private IWebElement tariffType { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-price-model")]
        private IWebElement priceModel { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".target .input-cell")]
        private IWebElement targetGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-tax")]
        private IWebElement taxPercentage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price > div > input")]
        [FindsBy(How = How.CssSelector, Using = ".sell-price > span")]
        private IWebElement sellPrice { get; set; }
        [FindsBy(How = How.ClassName, Using = "revenue")]
        private IWebElement revenue { get; set; }
        [FindsBy(How = How.ClassName, Using = "actual-gp")]
        private IWebElement actualGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-bin")]
        private IWebElement deleteType { get; set; }
        [FindsBy(How = How.ClassName, Using = "border-error")]
        private IWebElement BorderError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".quantity .text-error")]
        private IWebElement PlannedQtyContextualMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price .text-error")]
        private IWebElement SellPriceContextualMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".target .text-error")]
        private IWebElement TargetContextualMessage { get; set; }

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

        public string Revenue => this.revenue.Text;
        public string ActualGP => this.actualGP.Text;
        public string PlannedQtyContextualErrorMessage => PlannedQtyContextualMessage.Text;
        public string SellPriceContextualErrorMessage => SellPriceContextualMessage.Text;
        public string TargetPercentageContextualErrorMessage => TargetContextualMessage.Text;

        // May need another check
        public bool IsSellPriceEditable => sellPrice.Enabled;
        public bool IsPlannedQuantityWithRedBorder => plannedQuantity.Get().HasClass("border-error");
        public bool SellPriceHasRedBorder => sellPrice.Get().HasClass("border-error");
        public bool IsTargetGPWithRedBorder => targetGP.Get().HasClass("border-error");
        public bool IsDeleteIconPresent => deleteType.Get().ElementPresent;

        public RecipeModel GetDTO()
        {
            return new RecipeModel
            {
                PlannedQuantity = this.PlannedQuantity,
                CostPerUnit = this.CostPerUnit,
                TotalCosts = this.TotalCosts,
                PriceModel = this.PriceModel,
                Target = PriceModel != "Fixed" ? this.Target : null,
                TaxPercentage = this.TaxPercentage,
                SellPrice = this.SellPrice,
                Revenue = this.Revenue,
                ActualGP = this.ActualGP,
                TariffType = this.TariffType
            };
        }

        public void SetData(RecipeModel dto)
        {
            if (dto.PlannedQuantity != null && dto.PlannedQuantity != "^") this.PlannedQuantity = dto.PlannedQuantity;

            if (dto.TariffType != null && dto.TariffType != "^") this.TariffType = dto.TariffType;

            if (dto.PriceModel != null && dto.PriceModel != "^") this.PriceModel = dto.PriceModel;

            if (dto.Target != null && dto.Target != "^")
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

            if (dto.TaxPercentage != null && dto.TaxPercentage != "^") this.TaxPercentage = dto.TaxPercentage;

            if (dto.SellPrice != null && dto.SellPrice != "^")
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
            if (dto.PlannedQuantity != null && dto.PlannedQuantity != "^")
            {
                Assert.That(this.PlannedQuantity, Is.EqualTo(dto.PlannedQuantity));
            }

            if (dto.CostPerUnit != null && dto.CostPerUnit != "^")
            {
                Assert.That(this.CostPerUnit, Is.EqualTo(dto.CostPerUnit));
            }

            if (dto.TotalCosts != null && dto.TotalCosts != "^")
            {
                Assert.That(this.TotalCosts, Is.EqualTo(dto.TotalCosts));
            }

            if (dto.TariffType != null && dto.TariffType != "^")
            {
                Assert.That(this.TariffType, Is.EqualTo(dto.TariffType));
            }

            if (dto.PriceModel != null && dto.PriceModel != "^")
            {
                Assert.That(this.PriceModel, Is.EqualTo(dto.PriceModel));
            }

            if (dto.Target != null && dto.Target != "^")
            {
                Assert.That(this.Target, Is.EqualTo(dto.Target));
            }

            if (dto.TaxPercentage != null && dto.TaxPercentage != "^")
            {
                Assert.That(this.TaxPercentage, Is.EqualTo(dto.TaxPercentage));
            }

            if (dto.SellPrice != null && dto.SellPrice != "^")
            {
                Assert.That(this.SellPrice, Is.EqualTo(dto.SellPrice));
            }

            if (dto.Revenue != null && dto.Revenue != "^")
            {
                Assert.That(this.Revenue, Is.EqualTo(dto.Revenue));
            }

            if (dto.ActualGP != null && dto.ActualGP != "^")
            {
                Assert.That(this.ActualGP, Is.EqualTo(dto.ActualGP));
            }
        }

        // TODO: Need to handle multiple types
        public void DeleteType()
        {
            this.deleteType.Click();
        }
    }
}