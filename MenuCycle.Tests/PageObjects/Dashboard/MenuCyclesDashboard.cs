using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

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
        public IList<IWebElement> MenuCycles { get; set; }

        public void CreateMenuCycleClick()
        {
            Driver.WaitElementAndClick(CreateMenuCycleButton);
        }

        public void SelectMenuCycleByName(string menuCycleName)
        {
            Driver.WaitListItemsLoad(MenuCycles);
            MenuCycles.ToPageObjectList<MenuCycleItem>(Driver)
                .Find(v => v.Name.Text == menuCycleName).Name.Click();
        }
    }
}
