using System.Linq;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclesBasePage : BasePage
    {
        public MenuCyclesBasePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public bool IsHorizontalScrollPresent()
        {
            return (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return document.documentElement.scrollWidth>document.documentElement.clientWidth;");
        }

        public bool IsVerticalScrollPresent()
        {
            return (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return document.documentElement.scrollHeight>document.documentElement.clientHeight;");
        }

        public void CloseMenuCycles()
        {
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
        }
    }
}
