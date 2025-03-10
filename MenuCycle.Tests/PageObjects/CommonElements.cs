﻿using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class CommonElements : BasePage
    {
        public CommonElements(IWebDriver webDriver) : base(webDriver)
        {
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