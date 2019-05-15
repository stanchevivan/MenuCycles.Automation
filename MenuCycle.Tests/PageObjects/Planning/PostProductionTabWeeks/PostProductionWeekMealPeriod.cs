using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionWeekMealPeriod : MenuCyclesBasePage
    {
        public PostProductionWeekMealPeriod(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = ".day-data__columns-row > div:nth-of-type(2)")]
        private IWebElement mealPeriod_QtyReq { get; set; }
        [FindsBy(How = How.ClassName, Using = ".day-data__columns-row > div:nth-of-type(3)")]
        private IWebElement mealPeriod_QtyProd { get; set; }
        [FindsBy(How = How.ClassName, Using = ".day-data__columns-row > div:nth-of-type(4)")]
        private IWebElement mealPeriod_QtySold { get; set; }
        [FindsBy(How = How.ClassName, Using = ".day-data__columns-row > div:nth-of-type(5)")]
        private IWebElement mealPeriod_NoChargeApplied { get; set; }
        [FindsBy(How = How.ClassName, Using = ".day-data__columns-row > div:nth-of-type(6)")]
        private IWebElement mealPeriod_ReturnToStock { get; set; }
        [FindsBy(How = How.ClassName, Using = ".day-data__columns-row > div:nth-of-type(7)")]
        private IWebElement mealPeriod_Wastage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__data-radius > span")]
        private IWebElement MealPeriodName { get; set; }

        public string MealPeriodNameText => MealPeriodName.Text;

        public string MealPeriodTotalQtyRequisitioned => mealPeriod_QtyReq.Text;
        public string MealPeriodTotalQtyProd => mealPeriod_QtyProd.Text;
        public string MealPeriodTotalQtySold => mealPeriod_QtySold.Text;
        public string MealPeriodTotalNoChargeApplied => mealPeriod_NoChargeApplied.Text;
        public string MealPeriodTotalReturnToStock => mealPeriod_ReturnToStock.Text;
        public string MealPeriodTotalWastage => mealPeriod_Wastage.Text;
    }
}