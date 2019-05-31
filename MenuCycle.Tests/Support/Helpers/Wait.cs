using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;

namespace MenuCycle.Tests
{
    public static class Wait_Extension
    {
        public static Wait Wait(this IWebElement element, IWebDriver driver)
        {
            return new Wait(element, driver);
        }
    }

    public class Wait : BasePage
    {
        readonly IWebElement webElement;

        public Wait(IWebElement element, IWebDriver webDriver) : base(webDriver)
        {
            webElement = element;
        }

        public void ForAnimationToEnd()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript(@"arguments[0].height=='700'", webElement);
        }
    }
}