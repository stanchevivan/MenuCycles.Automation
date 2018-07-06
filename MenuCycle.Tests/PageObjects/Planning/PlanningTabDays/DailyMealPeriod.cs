using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DailyMealPeriod :MenuCyclesBasePage
    {
        IWebElement parent_MealPeriodWrapper;

        public DailyMealPeriod(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            this.parent_MealPeriodWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "icon-chevron-up")]
        private IWebElement CollapseArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-chevron-down")]
        private IWebElement ExpandArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__name")]
        private IWebElement MealPeriodName { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__covers-input")]
        private IWebElement Covers { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-content")]
        private IList<IWebElement> Items{ get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__content > div:nth-of-type(1) > span:last-of-type")]
        private IWebElement PlannedQuantityText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__content > div:nth-of-type(2) > span:last-of-type")]
        private IWebElement TotalCostText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__content > div:nth-of-type(3) > span:last-of-type")]
        private IWebElement RevenueText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__content > div:nth-of-type(4) > span:last-of-type")]
        private IWebElement ActualGPText { get; set; }

        public string Name => MealPeriodName.Text;
        public string Colour => parent_MealPeriodWrapper.GetCssValue("background-color");
        public bool IsExpanded => CollapseArrow.Get().ElementPresent;
        public string NumberOfCovers { get => Covers.GetAttribute("value"); set => Covers.Do(Driver).ClearAndSendKeys(value); }
        public string PlannedQuantity => PlannedQuantityText.Text;
        public string TotalCost => TotalCostText.Text;
        public string Revenue => RevenueText.Text;
        public string ActualGP => ActualGPText.Text;

        public IList<Recipe> Recipes => this.Items.Where(p => new Recipe(p, this.Name, Driver).Type == "RECIPE").Select(p => new Recipe(p, this.Name, Driver)).ToList();
        public IList<Buffet> Buffets => this.Items.Where(p => new Buffet(p, this.Name, Driver).Type == "BUFFET").Select(p => new Buffet(p, this.Name, Driver)).ToList();
        public IList<ALaCarte> ALaCartes => this.Items.Where(p => new ALaCarte(p, this.Name, Driver).Type == "A LA CARTE").Select(p => new ALaCarte(p, this.Name, Driver)).ToList();

        public Recipe GetRecipe(string title)
        {
            if (!Recipes.Any(a => a.Title == title))
            {
                throw new System.Exception($"Recipe {title} not found !");
            }

            return this.Recipes.First(a => a.Title == title);
        }

        public RecipeRow GetRecipeWithTariffType(string recipeTitle, string tariffType)
        {
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