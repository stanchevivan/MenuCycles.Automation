// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MenuCycle.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Performance Tests")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    [NUnit.Framework.CategoryAttribute("Performance")]
    public partial class PerformanceTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Performance.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Performance Tests", "    Feature for Performance Tests", ProgrammingLanguage.CSharp, new string[] {
                        "QAI",
                        "Performance"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Initial load of menu cycles list")]
        [NUnit.Framework.CategoryAttribute("TC35430")]
        [NUnit.Framework.TestCaseAttribute("QAI", null, Category="QAI")]
        public virtual void InitialLoadOfMenuCyclesList(string environment, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35430"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Initial load of menu cycles list", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.When("Measure performance of load menu cycles list for \"100\" repetitions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Central user search recipes")]
        [NUnit.Framework.CategoryAttribute("TC35434")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation Performance Testing", "", "WEDNESDAY", "LUNCH", null, Category="QAI")]
        public virtual void CentralUserSearchRecipes(string environment, string menuCycle, string recipe, string day, string mealPeriod, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35434"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Central user search recipes", @__tags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
    testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
    testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
    testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.And(string.Format("Measure performance of recipe search for \"100\" repetitions on \"{0}\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open planning screen")]
        [NUnit.Framework.CategoryAttribute("TC35443")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation Performance Testing", "WEDNESDAY", null, Category="QAI")]
        public virtual void OpenPlanningScreen(string environment, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35443"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open planning screen", @__tags);
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
    testRunner.When(string.Format("Measure performance of Open planning screen for \"20\" repetitions on \"{0}\"", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open nutrition screen")]
        [NUnit.Framework.CategoryAttribute("TC35444")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation Performance Testing", "WEDNESDAY", null, Category="QAI")]
        public virtual void OpenNutritionScreen(string environment, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35444"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open nutrition screen", @__tags);
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
        testRunner.And("Measure performance of Open nutrition screen for \"20\" repetitions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open calendar weeks")]
        [NUnit.Framework.CategoryAttribute("TC35445")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation Performance Testing", null, Category="QAI")]
        public virtual void OpenCalendarWeeks(string environment, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35445"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open calendar weeks", @__tags);
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.When("Measure performance of Open weekly calendar view for \"20\" repetitions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open menu cycle with 1800 items")]
        [NUnit.Framework.CategoryAttribute("TC35439")]
        [NUnit.Framework.TestCaseAttribute("QAI", "SE001", "Winter Breakfast Menu", null, Category="QAI")]
        public virtual void OpenMenuCycleWith1800Items(string environment, string location, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35439"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open menu cycle with 1800 items", @__tags);
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
    testRunner.When(string.Format("Measure performance of Open menu cycle for \"10\" repetitions for \"{0}\"", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open menu cycle with 4000 items in one week")]
        [NUnit.Framework.CategoryAttribute("TC39657")]
        [NUnit.Framework.TestCaseAttribute("QAI", "SE001", "4000 items - Do not use", null, Category="QAI")]
        public virtual void OpenMenuCycleWith4000ItemsInOneWeek(string environment, string location, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC39657"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open menu cycle with 4000 items in one week", @__tags);
#line 77
this.ScenarioSetup(scenarioInfo);
#line 78
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 79
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.When(string.Format("Measure performance of Open menu cycle for \"10\" repetitions for \"{0}\"", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
