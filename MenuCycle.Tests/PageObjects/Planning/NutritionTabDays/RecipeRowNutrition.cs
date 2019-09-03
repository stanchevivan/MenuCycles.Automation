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
    public class RecipeRowNutrition : MenuCyclesBasePage
    {
        public RecipeRowNutrition(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".quantity > span")]
        private IWebElement plannedQuantity { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mix > span")]
        private IWebElement mixPercent { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".energy-kj > span")]
        private IWebElement energyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".energy-kcal > span")]
        private IWebElement energyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".fat > span")]
        private IWebElement fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".saturated-fat > span")]
        private IWebElement saturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sugar > span")]
        private IWebElement sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".salt > span")]
        private IWebElement salt { get; set; }

        public string PlannedQuantity => this.plannedQuantity.Text;
        public string MixPercentage => this.mixPercent.Text;
        public string EnergyKJ => this.energyKJ.Text;
        public string EnergyKCAL => this.energyKCAL.Text;
        public string Fat => this.fat.Text;
        public string SaturatesFat => this.saturatedFat.Text;
        public string Sugar => this.sugar.Text;
        public string Salt => this.salt.Text;

        public RecipeModelNutrition GetDTO()
        {
            return new RecipeModelNutrition
            {
                PlannedQuantity = this.PlannedQuantity,
                MixPercent = this.MixPercentage,
                EnergyKJ = this.EnergyKJ,
                EnergyKCAL = this.EnergyKCAL,
                Fat = this.Fat,
                SaturatesFat = this.SaturatesFat,
                Sugar = this.Sugar,
                Salt = this.Salt
            };
        }

        public void VerifyData(RecipeModelNutrition dto)
        {
            if (dto.PlannedQuantity != null && dto.PlannedQuantity != "^")
            {
                Assert.That(this.PlannedQuantity, Is.EqualTo(dto.PlannedQuantity));
            }

            if (dto.MixPercent != null && dto.MixPercent != "^")
            {
                Assert.That(this.MixPercentage, Is.EqualTo(dto.MixPercent));
            }

            if (dto.EnergyKJ != null && dto.EnergyKJ != "^")
            {
                Assert.That(this.EnergyKJ, Is.EqualTo(dto.EnergyKJ));
            }

            if (dto.EnergyKCAL != null && dto.EnergyKCAL != "^")
            {
                Assert.That(this.EnergyKCAL, Is.EqualTo(dto.EnergyKCAL));
            }

            if (dto.Fat != null && dto.Fat != "^")
            {
                Assert.That(this.Fat, Is.EqualTo(dto.Fat));
            }

            if (dto.SaturatesFat != null && dto.SaturatesFat != "^")
            {
                Assert.That(this.SaturatesFat, Is.EqualTo(dto.SaturatesFat));
            }

            if (dto.Sugar != null && dto.Sugar != "^")
            {
                Assert.That(this.Sugar, Is.EqualTo(dto.Sugar));
            }

            if (dto.Salt != null && dto.Salt != "^")
            {
                Assert.That(this.Salt, Is.EqualTo(dto.Salt));
            }
        }
    }
}