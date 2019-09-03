using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DailyMealPeriod : MenuCyclesBasePage
    {
        IWebElement parent_MealPeriodWrapper;
        private readonly IArtefacts Artefacts;

        public DailyMealPeriod(IWebElement parent, IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
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
        [FindsBy(How = How.ClassName, Using = "mealperiod-covers__input")]
        private IWebElement Covers { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-wrapper")]
        private IList<IWebElement> Items{ get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__row > .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement PlannedQuantityText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__row > .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement TotalCostText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__row > .mealperiod-total__column:nth-of-type(9) > span:last-of-type")]
        private IWebElement RevenueText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__row > .mealperiod-total__column:nth-of-type(10) > span:last-of-type")]
        private IWebElement ActualGPText { get; set; }

        public string Name => MealPeriodName.Text;
        public string Colour => parent_MealPeriodWrapper.GetCssValue("background-color");
        public bool IsExpanded => CollapseArrow.Get().ElementPresent;
        public string NumberOfCovers { get => Covers.GetAttribute("value"); set => Covers.Do(Driver).ClearAndSendKeys(value); }
        public string PlannedQuantity => PlannedQuantityText.Text;
        public string TotalCost => TotalCostText.Text;
        public string Revenue => RevenueText.Text;
        public string ActualGP => ActualGPText.Text;

        public IList<Recipe> Recipes => this.Items
                                            .Where(p => new Recipe(p, this.Name, Driver, Artefacts).Type == "RECIPE")
                                            .Select(p => new Recipe(p, this.Name, Driver, Artefacts)).ToList();
        public IList<Buffet> Buffets => this.Items
                                            .Where(p => new Buffet(p, this.Name, Driver, Artefacts).Type == "BUFFET")
                                            .Select(p => new Buffet(p, this.Name, Driver, Artefacts)).ToList();
        public IList<ALaCarte> ALaCartes => this.Items
                                                .Where(p => new ALaCarte(p, this.Name, Driver, Artefacts).Type == "A LA CARTE")
                                                .Select(p => new ALaCarte(p, this.Name, Driver, Artefacts)).ToList();

        public Recipe GetRecipe(string title)
        {
            if (!Recipes.Any(a => a.Title == title))
            {
                throw new System.Exception($"Recipe {title} not found !");
            }

            return this.Recipes.First(a => a.Title == title);
        }

        public RecipeRow GetRecipeRowWithTariffType(string recipeTitle, string tariffType)
        {
            if (string.IsNullOrEmpty(tariffType))
            {
                return GetRecipe(recipeTitle).GetFirstRow();
            }

            return GetRecipe(recipeTitle).GetTariffTypeRow(tariffType);
        }

        public ALaCarte GetALaCarte(string name)
        {
            return this.ALaCartes.First(a => a.Title == name);
        }

        public Buffet GetBuffet(string name)
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