using System;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class CommonElements : BasePage
    {
        readonly IArtefacts Artefacts;
        public CommonElements(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.XPath, Using = "//button/span[text()='Expand all']")]
        private IWebElement ExpandAllButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//button/span[text()='Collapse all']")]
        private IWebElement CollapseAllButton { get; set; }

        public void UseExpandAllButton()
        {
            ExpandAllButton.Click();
        }

        public void UseCollapseAllButton()
        {
            CollapseAllButton.Click();
        }
    }
}