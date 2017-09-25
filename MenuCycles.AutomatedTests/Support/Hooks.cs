using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;
using System.Collections.Generic;
using MenuCycleData;
using MenuCycleData.Repositories;

namespace MenuCycles.AutomatedTests.Support
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;
        private ScenarioContext scenarioContext;

        public Hooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            this.objectContainer = container;
            this.objectContainer.RegisterTypeAs<Artefacts, IArtefacts>();
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = DriverFactory.Create();
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            List<MenuCycle> menuCycles;
            if (scenarioContext.TryGetValue(out menuCycles))
            {
                new MenuCycleRepository().DeleteAll(menuCycles);
            }

            List<MenuCycle> recipes;
            if (scenarioContext.TryGetValue(out recipes))
            {
                new MenuCycleRepository().DeleteAll(recipes);
            }

            List<MenuCycle> mealPeriods;
            if (scenarioContext.TryGetValue(out mealPeriods))
            {
                new MenuCycleRepository().DeleteAll(mealPeriods);
            }
            //data.DeleteScenarioData();
        }
    }
}

