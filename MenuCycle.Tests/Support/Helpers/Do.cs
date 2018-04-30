using OpenQA.Selenium;

namespace MenuCycle.Tests
{
    public static class Do_Extension
    {
        public static Do Do(this IWebElement element)
        {
            return new Do(element);
        }
    }

    public class Do
    {
        private IWebElement webElement;

        public Do(IWebElement element)
        {
            webElement = element;
        }

        public void Click()
        {
            webElement.Click();
        }

        public void JavaClick(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", webElement);
        }

        public void HighlightAndClick(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.border='3px solid lightgreen'", webElement);
            System.Threading.Thread.Sleep(200);
            webElement.Click();
        }

        public void ClearAndSendKeys(string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public void Clear()
        {
            webElement.Clear();
        }
    }
}