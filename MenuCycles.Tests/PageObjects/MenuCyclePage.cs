using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Page;
using MenuCycles.Tests.CustomClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycles.Tests.PageObjects
{
    public class MenuCyclePage : BasePage
    {
        #region Constructor
        public MenuCyclePage(IWebDriver webDriver) : base(webDriver)
        {
            LST_Days.Select(mealPeriod => new MealPeriod
            {
                BTN_Expand = mealPeriod.FindElement(By.ClassName("daily-item-item-contain")),
                BTN_OpenDetails = mealPeriod.FindElement(By.ClassName("daily-item-title")),
                Recipes = mealPeriod.FindElements(By.CssSelector(".daily-item-item-contain > div > div")).Select(recipy => recipy.Text).ToList(),
                Title = mealPeriod.FindElement(By.ClassName("daily-item-title")).Text,
            });
        }
        #endregion

        #region PageObjects
        [FindsBy(How = How.ClassName, Using = "daily-table-div")]
        private IList<IWebElement> LST_Days { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-item-container-div")]
        private IWebElement Meal { get; set; }
        #endregion

        public IDictionary<string, MealPeriod> Days;
        public IList<IList<MealPeriod>> DaysList = new List<>;

        #region Methods
        public MenuCyclePage GetDaysInfo()
        {
            foreach (var day in DaysList)
            {
                foreach (var mealPeriod in day)
                {
                    System.Console.WriteLine(mealPeriod.Title);
                    foreach (var recipy in mealPeriod.Recipes)
                    {
                        System.Console.WriteLine(recipy);
                    }
                }
            }

            return this;
        }
        #endregion
    }
}
