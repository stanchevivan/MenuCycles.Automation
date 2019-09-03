using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionDayRow : MenuCyclesBasePage
    {
        IWebElement parent_DaysWrapper;
        private readonly IArtefacts Artefacts;

        public PostProductionDayRow(IWebElement parent, IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            this.parent_DaysWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".day-data__name > span")]
        private IWebElement DayName { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(2)")]
        private IWebElement dailyTotal_QtyReq { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(3)")]
        private IWebElement dailyTotal_QtyProd { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(4)")]
        private IWebElement dailyTotal_QtySold { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(5)")]
        private IWebElement dailyTotal_NoChargeApplied { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(6)")]
        private IWebElement dailyTotal_ReturnToStock { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(7)")]
        private IWebElement dailyTotal_Wastage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__row .day-data__columns-row")]
        private IList<IWebElement> DayMealPeriodsRows { get; set; }

        public IList<PostProductionWeekMealPeriod> MealPeriodsRows => this.DayMealPeriodsRows.Select(p => new PostProductionWeekMealPeriod(p, Driver, Artefacts)).ToList();

        public string PostProductionDayName => DayName.Text;

        public string DailyTotalQtyRequisitioned => dailyTotal_QtyReq.Text;
        public string DailyTotalQtyProduced => dailyTotal_QtyProd.Text;
        public string DailyTotalQtySold => dailyTotal_QtySold.Text;
        public string DailyTotalNoChargeApplied => dailyTotal_NoChargeApplied.Text;
        public string DailyTotalReturnToStock => dailyTotal_ReturnToStock.Text;
        public string DailyTotalWastage => dailyTotal_Wastage.Text;

        public PostProductionWeekMealPeriod GetMealPeriod(string name)
        {
            if (!MealPeriodsRows.Any(x => x.Name == name))
            {
                throw new System.Exception($"Meal Period {name} not found !");
            }
            return MealPeriodsRows.First(x => x.Name == name);
        }
    }
}