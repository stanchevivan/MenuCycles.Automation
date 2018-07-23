using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;

namespace MenuCycle.Tests
{
    public static class Do_Extension
    {
        public static Do Do(this IWebElement element, IWebDriver driver)
        {
            return new Do(element, driver);
        }
    }

    public class Do : BasePage
    {
        readonly IWebElement webElement;

        public Do(IWebElement element, IWebDriver webDriver) : base(webDriver)
        {
            webElement = element;
        }

        public void Click()
        {
            webElement.Click();
        }

        public void JavaScriptClick()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", webElement);
        }

        public void HighlightAndClick()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].style.border='3px solid lightgreen'", webElement);
            System.Threading.Thread.Sleep(200);
            webElement.Click();
        }

        public void FocusOut()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].blur();", webElement);
        }

        public void FocusIn()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].focus();", webElement);
        }

        public void ClearAndSendKeys(string text)
        {
            // webElement.Clear();
            JavaScriptClear();
            webElement.SendKeys(text);
        }

        public void SendKeys(string text)
        {
            webElement.SendKeys(text);
        }

        public void JavaScriptClear()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].value='';", webElement);
            ((IJavaScriptExecutor)Driver).ExecuteScript("$(arguments[0]).change();", webElement);
        }
    }
}