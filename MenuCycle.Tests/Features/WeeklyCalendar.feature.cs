// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Weekly Calendar")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    public partial class WeeklyCalendarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WeeklyCalendar.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Weekly Calendar", "Weekly Calendar Feature", ProgrammingLanguage.CSharp, new string[] {
                        "QAI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy and Delete week in Weekly Calendar view")]
        [NUnit.Framework.CategoryAttribute("TC33038")]
        [NUnit.Framework.CategoryAttribute("TC31075")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Automation Menu Cycle", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CopyAndDeleteWeekInWeeklyCalendarView(string environment, string withFA, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC33038",
                    "TC31075"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy and Delete week in Weekly Calendar view", null, @__tags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.When("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
        testRunner.And("Week \"Week 1\" is copied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
        testRunner.And("Verify notification message \"Week Successfully Added.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
        testRunner.And("Week \"Week 2\" is copied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
        testRunner.And("Verify notification message \"Week Successfully Added.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
        testRunner.And("Delete button is clicked for week \"Week 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.Then("Verify notification message \"Week Successfully Removed.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
        testRunner.And("Delete button is clicked for week \"Week 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
        testRunner.And("Verify notification message \"Week Successfully Removed.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Empty weeks are not present in the calendar weekly view")]
        [NUnit.Framework.CategoryAttribute("TC37776")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Automation Copy Delete", "LUNCH", "Monday", "703Reggae Raggae Mayonnaise", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void EmptyWeeksAreNotPresentInTheCalendarWeeklyView(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipeName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC37776"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty weeks are not present in the calendar weekly view", null, @__tags);
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.When("new week is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
        testRunner.And("new week is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
        testRunner.And(string.Format("Meal period \"{0}\" is created for \"{1}\"", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
        testRunner.And(string.Format("Recipe \"{0}\" is added", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
        testRunner.And("Meal period is saved with notification \"Meal Period Saved successfully\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
        testRunner.And("meal period detailed view is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                        "WEEK 1",
                        "WEEK 3"});
#line 40
        testRunner.And("Verify caledar weeks contains weeks:", ((string)(null)), table116, "And ");
#line 42
        testRunner.And("Week \"WEEK 3\" is copied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
        testRunner.Then("Verify notification message \"Week Successfully Added.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                        "WEEK 1",
                        "WEEK 3",
                        "WEEK 4"});
#line 44
        testRunner.And("Verify caledar weeks contains weeks:", ((string)(null)), table117, "And ");
#line 46
        testRunner.And("Delete button is clicked for week \"Week 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.Then("Verify notification message \"Week Successfully Removed.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                        "WEEK 1",
                        "WEEK 3"});
#line 49
        testRunner.And("Verify caledar weeks contains weeks:", ((string)(null)), table118, "And ");
#line 51
        testRunner.And("Delete button is clicked for week \"Week 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
        testRunner.Then("Verify notification message \"Week Successfully Removed.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                        "WEEK 1"});
#line 54
        testRunner.And("Verify caledar weeks contains weeks:", ((string)(null)), table119, "And ");
#line 56
        testRunner.When("Daily Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
    testRunner.Then("Verify next week arrow is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open meal period from the weekly view")]
        [NUnit.Framework.CategoryAttribute("TC37973")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "Dangelo", "MONDAY", "WEEK 2", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void OpenMealPeriodFromTheWeeklyView(string environment, string withFA, string menuCycle, string mealPeriod, string day, string weekName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC37973"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open meal period from the weekly view", null, @__tags);
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 66
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
    testRunner.Given(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
    testRunner.When("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
        testRunner.And(string.Format("meal period \"{0}\" in day \"{1}\" for week \"{2}\" is opened", mealPeriod, day, weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
    testRunner.Then(string.Format("Verify meal period details for \"{0} {1}\" is open", weekName, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("NaN is not displayed for Week title")]
        [NUnit.Framework.CategoryAttribute("TC38017")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void NaNIsNotDisplayedForWeekTitle(string environment, string withFA, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38017"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("NaN is not displayed for Week title", null, @__tags);
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 80
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
    testRunner.When("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
        testRunner.And("Daily Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
    testRunner.Then("Verify week name is \"WEEK 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GAP days are indicated in weekly view")]
        [NUnit.Framework.CategoryAttribute("TC38017")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Automation Menu Cycle", "Saturday", "Week 1", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void GAPDaysAreIndicatedInWeeklyView(string environment, string withFA, string menuCycle, string day, string week, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38017"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GAP days are indicated in weekly view", null, @__tags);
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 94
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
    testRunner.When("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
    testRunner.Then(string.Format("Verify day \"{0}\" in week \"{1}\" is GAP day", day, week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
