using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;
using System.Collections.Generic;
using MenuCycleData;
using MenuCycleData.Repositories;
using MenuCycleData.Generators;
using MenuCycleData.Services;

namespace MenuCycles.AutomatedTests.Support
{
    [Binding]
    public sealed class SeedHooks
    {
        private ScenarioContext scenarioContext;
        private readonly RecipeService recipeService;
        private readonly MealPeriodService mealPeriodService;
        private readonly MenuCycleService menuCycleService;

        public SeedHooks(ScenarioContext scenarioContext, RecipeService recipeService, MealPeriodService mealPeriodService, MenuCycleService menuCycleService)
        {
            this.scenarioContext = scenarioContext;
            this.recipeService = recipeService;
            this.menuCycleService = menuCycleService;
            this.mealPeriodService = mealPeriodService;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IList<MenuCycle> menuCycles;
            if (scenarioContext.TryGetValue(out menuCycles))
            {
                new MenuCycleRepository().DeleteAll(menuCycles);
            }

            IList<MenuCycle> recipes;
            if (scenarioContext.TryGetValue(out recipes))
            {
                new MenuCycleRepository().DeleteAll(recipes);
            }

            IList<MenuCycle> mealPeriods;
            if (scenarioContext.TryGetValue(out mealPeriods))
            {
                this.recipeService.DeleteRecipe(this.scenarioContext.Get<IList<Recipe>>());
                this.mealPeriodService.DeleteMealPeriod(this.scenarioContext.Get<IList<MealPeriod>>());
                this.menuCycleService.DeleteMenuCycle(this.scenarioContext.Get<IList<MenuCycle>>());
            }
            //data.DeleteScenarioData();
        }
    }
}

