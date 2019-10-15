using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MassUpdateOccurrencesCard : MenuCyclesBasePage
    {
        public MassUpdateOccurrencesCard(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".search-results-row")]
        private IList <IWebElement> Rows { get; set; }


        public IList<MassUpdateOccurrencesRow> OccurrancesRows => this.Rows.Select(p => new MassUpdateOccurrencesRow(p, Driver)).ToList();

    }
}
