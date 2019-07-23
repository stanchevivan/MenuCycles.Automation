namespace MenuCycle.Tests.Support
{
    using TechTalk.SpecFlow;

    //[Binding]
    public sealed class SeedHooks
    {
        private readonly ScenarioContext scenarioContext;

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