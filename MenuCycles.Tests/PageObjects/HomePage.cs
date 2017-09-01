using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycles.Tests.PageObjects
{
    public class HomePage : BasePage
    {
        #region Constructor
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.WaitIsClickable(BTN_OpenSearch);
        }
        #endregion

        #region PageObjects
        // [FindsBy(How = How.CssSelector, Using = "[data-webelement='ICN_Search']")]
        [FindsBy(How = How.ClassName, Using = "search-icon")]
        private IWebElement BTN_OpenSearch { get; set; }
        [FindsBy(How = How.ClassName, Using = "home-search-button")]
        private IWebElement BTN_Search { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".menucycle-search-container > input")]
        private IWebElement FLD_Search { get; set; }
        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        private IWebElement Loader { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".menuCycleTableBody > div:not([id])")]
        private IList<IWebElement> LST_MenuCycles { get; set; }
        #endregion

        IList<MenuCycle> MenuCycles =>
            LST_MenuCycles.Select(x => new MenuCycle
            {
                NameLink = x.FindElement(By.CssSelector(".nameTitleCell a")),
                Description = x.FindElement(By.CssSelector(".descriptionCell p")).Text,
                Published = Get.HasClass(x, "published-menucycle-row"),
                MoreButton = x.FindElement(By.ClassName("home-button-expand"))
            }).ToList();

        #region Methods
        public HomePage Search(string text)
        {
            BTN_OpenSearch.Click();
            Do.ClearAndSendKeys(FLD_Search, text);
            BTN_Search.Click();
            Driver.WaitElementToDisappear(Loader);

            return this;
        }

        public MenuCyclePage OpenMenuCycle(int index)
        {
            MenuCycles[index - 1].NameLink.Click();

            return new MenuCyclePage(Driver);
        }

        public HomePage GetMenuCyclesInfo()
        {
            System.Console.WriteLine();
            try
            {
                System.Console.WriteLine(MenuCycles.Count + " menu cycles detected:");
            }
            catch (NoSuchElementException)
            {
                System.Console.WriteLine("No menu cycles detected !");
                return this;
            }
            System.Console.WriteLine();

            foreach (var item in MenuCycles)
            {
                System.Console.WriteLine("Name: " + item.Name);
                System.Console.WriteLine("Description: " + item.Description);
                System.Console.WriteLine("Published: " + (item.Published ? "Published" : "Unpublished"));
                System.Console.WriteLine();
            }

            return this;
        }
        #endregion
    }
}
