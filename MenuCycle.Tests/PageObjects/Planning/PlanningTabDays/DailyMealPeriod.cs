using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DailyMealPeriod
    {
        IWebElement parent_MealPeriodWrapper;

        public DailyMealPeriod(IWebElement parent)
        {
            this.parent_MealPeriodWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "icon-chevron-up")]
        IWebElement CollapseArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-chevron-down")]
        IWebElement ExpandArrow { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__name")]
        IWebElement MealPeriodName { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-main")]
        IWebElement MealPeriodMain { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-header__covers-input")]
        IWebElement Covers { get; set; }
        [FindsBy(How = How.ClassName, Using = "recipe-content")]
        IList<IWebElement> Items{ get; set; }

        public string Name => MealPeriodName.Text;
        public string Colour => parent_MealPeriodWrapper.GetCssValue("background-color");
        public bool IsExpanded => MealPeriodMain.Get().ElementPresent();
        public string NumberOfCovers => Covers.GetAttribute("value");

        public IList<Recipe> Recipes => this.Items.Where(p => new Recipe(p, this.Name).Type == "RECIPE").Select(p => new Recipe(p, this.Name)).ToList();
        public IList<Buffet> Buffets => this.Items.Where(p => new Buffet(p, this.Name).Type == "BUFFET").Select(p => new Buffet(p, this.Name)).ToList();
        public IList<ALaCarte> ALaCartes => this.Items.Where(p => new ALaCarte(p, this.Name).Type == "A LA CARTE").Select(p => new ALaCarte(p, this.Name)).ToList();

        public Recipe GetRecipe(string name)
        {
            return this.Recipes.First(a => a.Title == name);
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
