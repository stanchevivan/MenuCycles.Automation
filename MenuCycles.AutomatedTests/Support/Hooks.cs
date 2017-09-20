using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;
using System.Collections.Generic;
using MenuCyclesData;
using MenuCyclesData.DatabaseDataModel;

namespace MenuCycles.AutomatedTests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;
        private ScenarioContext scenarioContext;
        private Seeding data;

        public Hooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            this.objectContainer = container;
            this.objectContainer.RegisterTypeAs<Artefacts, IArtefacts>();
            this.scenarioContext = scenarioContext;
            this.data = new Seeding();
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
            List<MenuCycle> list = new List<MenuCycle>();
            if (scenarioContext.TryGetValue(out list))
            {
                data.DeleteScenarioData(list);
            }
        }
    }
}

