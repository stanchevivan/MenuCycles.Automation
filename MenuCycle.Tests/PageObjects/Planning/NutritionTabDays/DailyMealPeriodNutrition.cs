using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DailyMealPeriodNutrition : MenuCyclesBasePage
    {
        private readonly IArtefacts Artefacts;
        IWebElement parent_MealPeriodWrapper;

        public DailyMealPeriodNutrition(IWebElement parent, IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            Artefacts = artefacts;
            this.parent_MealPeriodWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "icon-chevron-up")]
        private IWebElement CollapseArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-chevron-down")]
        private IWebElement ExpandArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__name")]
        private IWebElement MealPeriodName { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__covers__input")]
        private IWebElement Covers { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-wrapper")]
        private IList<IWebElement> Items { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement mealPeriod_plannedQtyText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement mealPeriod_energyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement mealPeriod_EnergyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement mealPeriod_Fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(6) > span:last-of-type")]
        private IWebElement mealPeriod_SaturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(7) > span:last-of-type")]
        private IWebElement mealPeriod_Sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(8) > span:last-of-type")]
        private IWebElement mealPeriod_Salt { get; set; }

        public string Name => MealPeriodName.Text;
        public string Colour => parent_MealPeriodWrapper.GetCssValue("background-color");
        public bool IsExpanded => CollapseArrow.Get().ElementPresent;
        public bool IsNumberOfCoversPresent => Covers.Get().ElementPresent;

        public string MealPeriodPlannedQtyTotal => mealPeriod_plannedQtyText.Text;
        public string MealPeriodEnergyKJTotal => mealPeriod_energyKJ.Text;
        public string MealPeriodEnergyKCALTotal => mealPeriod_EnergyKCAL.Text;
        public string MealPeriodFatTotal => mealPeriod_Fat.Text;
        public string MealPeriodSaturatedFatTotal => mealPeriod_SaturatedFat.Text;
        public string MealPeriodSugarTotal => mealPeriod_Sugar.Text;
        public string MealPeriodSaltTotal => mealPeriod_Salt.Text;


        public IList<NutritionScreenRecipe> Recipes => this.Items
                                            .Where(p => new NutritionScreenRecipe(p, this.Name, Driver, Artefacts).Type == "RECIPE")
                                            .Select(p => new NutritionScreenRecipe(p, this.Name, Driver, Artefacts)).ToList();
        public IList<BuffetNutrition> Buffets => this.Items
                                            .Where(p => new NutritionScreenRecipe(p, this.Name, Driver, Artefacts).Type == "BUFFET")
                                            .Select(p => new BuffetNutrition(p, this.Name, Driver, Artefacts)).ToList();
        public IList<ALaCarteNutrition> ALaCartes => this.Items
                                    .Where(p => new NutritionScreenRecipe(p, this.Name, Driver, Artefacts).Type == "A LA CARTE")
                                    .Select(p => new ALaCarteNutrition(p, this.Name, Driver, Artefacts)).ToList();

        public NutritionScreenRecipe GetRecipe(string title)
        {
            if (!Recipes.Any(a => a.Title == title))
            {
                throw new System.Exception($"Recipe {title} not found !");
            }

            return this.Recipes.First(a => a.Title == title);
        }

        public BuffetNutrition GetBuffet(string name)
        {
            return this.Buffets.First(a => a.Title == name);
        }

        public void Expand()
        {
            ExpandArrow.Click();
        }

        public void Collapse()
        {
            CollapseArrow.Click();
        }
    }
}