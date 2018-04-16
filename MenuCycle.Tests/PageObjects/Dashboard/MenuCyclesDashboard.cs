using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclesDashboard : BasePage
    {
        public MenuCyclesDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='borbot clickable']")]
        public IWebElement CreateMenuCycleButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuCycleTableBody .home-div-row")]
        public IList<IWebElement> MenuCyclesContainer { get; set; }

        public IList<MenuCycleItem> MenuCycles => this.MenuCyclesContainer.Select(p => new MenuCycleItem(p)).ToList();

        public void CreateMenuCycleClick()
        {
            Driver.WaitElementAndClick(CreateMenuCycleButton);
        }

        public void SelectMenuCycleByName(string menuCycleName)
        {
            Driver.WaitListItemsLoad(MenuCyclesContainer);
            MenuCycles.First(v => v.Name.Text == menuCycleName).Name.Click();
        }
    }
}
