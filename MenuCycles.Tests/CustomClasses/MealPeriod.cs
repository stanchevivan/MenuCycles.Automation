using System.Collections.Generic;
using OpenQA.Selenium;

namespace MenuCycles.Tests.CustomClasses
{
    public class MealPeriod
    {
        public string Title;
        public IList<string> Recipes;
        public IWebElement BTN_Expand;
        public IWebElement BTN_OpenDetails;
    }
}
