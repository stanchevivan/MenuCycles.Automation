using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class MenuCyclesDashboard : BasePage
    {
        public MenuCyclesDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='borbot clickable']")]
        public IWebElement Create { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuCycleTableBody .home-div-row")]
        public IList<IWebElement> MenuCyclesList { get; set; }

        public void CreateMenuCycleClick()
        {
            Driver.WaitElementAndClick(Create);
        }

        public void SelectMenuCycleByName(string name)
        {
            Driver.WaitListItemsLoad(MenuCyclesList);
            var list = MenuCyclesList.ToPageObjectList<MenuCycleItem>(Driver);
            list.Find(v => v.Name.Text == name).Name.Click();
        }
    }
}
