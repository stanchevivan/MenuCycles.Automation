using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace MenuCycle.Tests
{
    public static class Get_Extension
    {
        public static Get Get(this IWebElement element)
        {
            return new Get(element);
        }
    }

    public class Get
    {
        readonly IWebElement webElement;

        public Get(IWebElement element)
        {
            webElement = element;
        }

        public List<string> Classes()
        {
            return webElement.GetAttribute("class").Split(' ').ToList();
        }

        public bool HasClass(string className)
        {
            return Classes().Contains(className);
        }

        public bool HasAttribute(string attributeName)
        {
            return string.IsNullOrEmpty(webElement.GetAttribute(attributeName));
        }

        public string Text()
        {
            return webElement.Text;
        }

        public bool ElementPresent()
        {
            try
            {
                var t = webElement.TagName;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        public bool ElementDisplayed()
        {
            return webElement.Displayed;
        }

        public bool ElementEnabled()
        {
            return webElement.Enabled;
        }
    }
}
