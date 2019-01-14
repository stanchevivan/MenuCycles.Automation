using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DailyMealPeriodPostProduction : MenuCyclesBasePage
    {
        IWebElement parent_MealPeriodWrapper;

        public DailyMealPeriodPostProduction(IWebElement parent, IWebDriver webDriver) : base(webDriver)
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
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__covers__input")]
        private IWebElement Covers { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-content")]
        private IList<IWebElement> Items{ get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement PlannedQuantityText { get; set; }

        public string Name => MealPeriodName.Text;
        public string Colour => parent_MealPeriodWrapper.GetCssValue("background-color");
        public bool IsExpanded => CollapseArrow.Get().ElementPresent;
        public string NumberOfCovers { get => Covers.GetAttribute("value"); set => Covers.Do(Driver).ClearAndSendKeys(value); }
        public string PlannedQuantity => PlannedQuantityText.Text;

        public IList<RecipePostProduction> Recipes => this.Items
                                            .Where(p => !new RecipePostProduction(p, this.Name, Driver).IsBuffet)
                                            .Select(p => new RecipePostProduction(p, this.Name, Driver)).ToList();
        public IList<BuffetPostProduction> Buffets => this.Items
                                            .Where(p => new BuffetPostProduction(p, this.Name, Driver).IsBuffet)
                                            .Select(p => new BuffetPostProduction(p, this.Name, Driver)).ToList();

        public RecipePostProduction GetRecipe(string title)
        {
            if (!Recipes.Any(a => a.Title == title))
            {
                throw new System.Exception($"Recipe {title} not found !");
            }

            return this.Recipes.First(a => a.Title == title);
        }

        public BuffetPostProduction GetBuffet(string name)
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