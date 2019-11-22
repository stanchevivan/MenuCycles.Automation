using System;
using System.Text.RegularExpressions;
using Fourth.Automation.Framework.Page;
using MenuCycle.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class RecipeRowPostProduction : MenuCyclesBasePage
    {
        public RecipeRowPostProduction(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".type > span")]
        private IWebElement tariffName { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".quantity > span")]
        private IWebElement plannedQuantity { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".requisitioned-quantity > div > input")]
        private IWebElement quantityRequisitioned { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".produced-quantity > div > input")]
        private IWebElement quantityProduced { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sold-quantity .recipe-data__cell")]
        private IWebElement quantitySold { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".no-charge > div > input")]
        private IWebElement noCharge { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".return-stock > div > input")]
        private IWebElement returnToStock { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".wastage > div > input")]
        [FindsBy(How = How.CssSelector, Using = ".wastage > div .display-value")]
        private IWebElement wastage { get; set; }
        [FindsBy(How = How.ClassName, Using = "border-error")]
        private IWebElement BorderError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".requisitioned-quantity > div > .error-content")]
        private IWebElement qtyReqdContextError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".produced-quantity > div > .error-content")]
        private IWebElement qtyProdContextError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sold-quantity > div > .error-content")]
        private IWebElement qtySoldContextError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".no-charge > div > .error-content")]
        private IWebElement noChargeContextError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".return-stock > div > .error-content")]
        private IWebElement returnToStockContextError { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".wastage > div > .error-content")]
        private IWebElement wastageContextError { get; set; }


        public string TariffName => this.tariffName.Text;
        public string PlannedQuantity => this.plannedQuantity.Text;
        public bool IsSoldQtyEnabled => quantitySold.Get().HasClass("input-default");
        public bool IsWastageEnabled => wastage.Get().HasClass("input-default");

        public string QuantityRequisitioned
        {
            get => this.quantityRequisitioned.GetAttribute("value");
            set
            {
                this.quantityRequisitioned.Do(Driver).ClearAndSendKeys(value);
                this.quantityProduced.Do(Driver).FocusOut();
            }
        }

        public string QuantityProduced
        {
            get => this.quantityProduced.GetAttribute("value");
            set
            {
                this.quantityProduced.Do(Driver).ClearAndSendKeys(value);
                this.quantityProduced.Do(Driver).FocusOut();
            }
        }

        public string QuantitySold
        {
            get => this.quantitySold.TagName == "span" ? this.quantitySold.Text : this.quantitySold.GetAttribute("value");
            set
            {
                this.quantitySold.Do(Driver).ClearAndSendKeys(value);
                this.quantitySold.Do(Driver).FocusOut();
            }
        }
        public bool IsQuantitySoldPresent => quantitySold.Get().ElementPresent;

        public string NoCharge
        {
            get => this.noCharge.GetAttribute("value");
            set
            {
                this.noCharge.Do(Driver).ClearAndSendKeys(value);
                this.noCharge.Do(Driver).FocusOut();
            }
        }
        public bool IsNoChargePresent => quantitySold.Get().ElementPresent;

        public string ReturnToStock
        {
            get => this.returnToStock.GetAttribute("value");
            set
            {
                this.returnToStock.Do(Driver).ClearAndSendKeys(value);
                this.returnToStock.Do(Driver).FocusOut();
            }
        }

        public string Wastage
        {
            get => this.wastage.TagName == "div" ? this.wastage.Text : this.wastage.GetAttribute("value");
            set => this.wastage.Do(Driver).ClearAndSendKeys(value);
        }

        public string QtyReqdContextError => qtyReqdContextError.Text;
        public string QtyProdContextError => qtyProdContextError.Text;
        public string QtySoldContextError => qtySoldContextError.Text;
        public string NoChargeContextError => noChargeContextError.Text;
        public string ReturnToStockContextError => returnToStockContextError.Text;
        public string WastageContextualError => wastageContextError.Text;

        // May need another check
        //public bool IsPlannedQuantityWithRedBorder => plannedQuantity.Get().HasClass("border-error");
        //public bool IsReturnToStockWithRedBorder => returnToStock.Get().HasClass("border-error");

        public RecipeModelPostProducton GetDTO()
        {
            return new RecipeModelPostProducton
            {
                PlannedQuantity = this.PlannedQuantity,
                QuantityRequisitioned = this.QuantityRequisitioned,
                QuantityProduced = this.QuantityProduced,
                QuantitySold = this.QuantitySold,
                NoCharge = this.NoCharge,
                ReturnToStock = this.ReturnToStock,
                Wastage = this.Wastage
            };
        }

        public void SetData(RecipeModelPostProducton dto)
        {
            QuantityRequisitioned = dto.QuantityRequisitioned;
            QuantityProduced = dto.QuantityProduced;
            QuantitySold = dto.QuantitySold;
            NoCharge = dto.NoCharge;
            ReturnToStock = dto.ReturnToStock;
        }

        public void VerifyData(RecipeModelPostProducton dto)
        {
            if (dto.PlannedQuantity != null && dto.PlannedQuantity != "^")
            {
                Assert.That(this.PlannedQuantity, Is.EqualTo(dto.PlannedQuantity));
            }

            if (dto.QuantityProduced != null && dto.QuantityProduced != "^")
            {
                Assert.That(this.QuantityProduced, Is.EqualTo(dto.QuantityProduced));
            }

            if (dto.QuantitySold != null && dto.QuantitySold != "^")
            {
                Assert.That(this.QuantitySold, Is.EqualTo(dto.QuantitySold));
            }

            if (dto.NoCharge != null && dto.NoCharge != "^")
            {
                Assert.That(this.NoCharge, Is.EqualTo(dto.NoCharge));
            }

            if (dto.ReturnToStock != null && dto.ReturnToStock != "^")
            {
                Assert.That(this.ReturnToStock, Is.EqualTo(dto.ReturnToStock));
            }

            if (dto.Wastage != null && dto.Wastage != "^")
            {
                Assert.That(this.Wastage, Is.EqualTo(dto.Wastage));
            }
        }
    }
}