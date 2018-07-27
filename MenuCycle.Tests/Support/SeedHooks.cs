using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Support
{
    //[Binding]
    public sealed class SeedHooks
    {
        readonly ScenarioContext scenarioContext;

        public SeedHooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [AfterScenario]
        [Scope(Tag = "menucycle")]
        public void DeleteMenuCycleAfterScenario()
        {
        }

        [AfterScenario]
        [Scope(Tag = "mealperiod")]
        public void DeleteMealPeriodAfterScenario()
        {
        }

        [AfterScenario]
        [Scope(Tag = "recipe")]
        public void DeleteRecipeAfterScenario()
        {
        }
    }
}

