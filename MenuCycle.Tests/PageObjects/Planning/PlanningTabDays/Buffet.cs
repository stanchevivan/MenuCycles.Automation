﻿using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.Planning.PlanningTabDays
{
    public class Buffet : Recipe
    {
        public Buffet(IWebElement parent, string mealPeriodName, IWebDriver webDriver) : base(parent, mealPeriodName, webDriver)
        {
            PageFactory.InitElements(parent, this);
            MealPeriodName = mealPeriodName;
        }

        [FindsBy(How = How.ClassName, Using = "recipe-card")]
        protected  IList<IWebElement> Items { get; set; }

        public IList<NestedRecipe> Recipes => this.Items.Select(p => new NestedRecipe(p, MealPeriodName, Driver)).ToList().GetRange(1, Items.Count - 1);

        public NestedRecipe GetRecipe(string title)
        {
            if (!Recipes.Any(x => x.Title == title))
            {
                throw new System.Exception($"No such recipe {title}");
            }
            return Recipes.First(x => x.Title == title);
        }
    }
}