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
    [NUnit.Framework.DescriptionAttribute("Daily Calendar")]
    public partial class DailyCalendarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DailyCalendar.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Daily Calendar", "\tDaily Calendar Feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Daily Calendar view is switched for central user")]
        [NUnit.Framework.CategoryAttribute("TC34368")]
        [NUnit.Framework.CategoryAttribute("TC34367")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "Sunday", null, Category="QAI")]
        public virtual void DailyCalendarViewIsSwitchedForCentralUser(string environment, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC34368",
                    "TC34367"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Daily Calendar view is switched for central user", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
    testRunner.When("daily calendar view is switched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
        testRunner.And(string.Format("Verify day \"{0}\" is visible", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
        testRunner.And("daily calendar view is switched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.Then(string.Format("Verify day \"{0}\" is not visible", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Daily Calendar view is switched for local user")]
        [NUnit.Framework.CategoryAttribute("TC34370")]
        [NUnit.Framework.CategoryAttribute("TC34369")]
        [NUnit.Framework.TestCaseAttribute("QAI", "SE001", "Local User Testing", "SUN 5 AUG", null, Category="QAI")]
        public virtual void DailyCalendarViewIsSwitchedForLocalUser(string environment, string location, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC34370",
                    "TC34369"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Daily Calendar view is switched for local user", @__tags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.When(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
        testRunner.And("daily calendar view is switched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And(string.Format("Verify day \"{0}\" is visible", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
        testRunner.And("daily calendar view is switched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.Then(string.Format("Verify day \"{0}\" is not visible", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Review page is opened")]
        [NUnit.Framework.CategoryAttribute("TC37976")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", null, Category="QAI")]
        public virtual void ReviewPageIsOpened(string environment, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC37976"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Review page is opened", @__tags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.When("daily review page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
    testRunner.Then("Verify review page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to meal period details from internal search")]
        [NUnit.Framework.CategoryAttribute("TC37976")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "004Baked Beans", "Week 1", "Sunday", null, Category="QAI")]
        public virtual void NavigateToMealPeriodDetailsFromInternalSearch(string environment, string menuCycle, string recipeName, string weekName, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC37976"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to meal period details from internal search", @__tags);
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.When("search in Menu Cycle for \" \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
        testRunner.And(string.Format("view recipe \"{0}\" in week \"{1}\"", recipeName, weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
    testRunner.Then(string.Format("Verify meal period details for \"{0} {1}\" is open", weekName, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User is redirected to the week from which he opened the Planning screen")]
        [NUnit.Framework.CategoryAttribute("TC38603")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation - Multiple weeks", "WEEK 2", "Monday", null, Category="QAI")]
        public virtual void UserIsRedirectedToTheWeekFromWhichHeOpenedThePlanningScreen(string environment, string menuCycle, string weekName, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38603"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User is redirected to the week from which he opened the Planning screen", @__tags);
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And(string.Format("week \"{0}\" is opened", weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
        testRunner.And(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
    testRunner.When("Cancel button is clicked and calendar view has loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
    testRunner.Then(string.Format("Verify week name is \"{0}\"", weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User is redirected to the week from which he opened the Review page")]
        [NUnit.Framework.CategoryAttribute("TC38604")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation - Multiple weeks", "WEEK 2", null, Category="QAI")]
        public virtual void UserIsRedirectedToTheWeekFromWhichHeOpenedTheReviewPage(string environment, string menuCycle, string weekName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38604"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User is redirected to the week from which he opened the Review page", @__tags);
#line 77
this.ScenarioSetup(scenarioInfo);
#line 78
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 79
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And(string.Format("week \"{0}\" is opened", weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
        testRunner.And("daily review page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
    testRunner.When("Cancel button is clicked and calendar view has loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
    testRunner.Then(string.Format("Verify week name is \"{0}\"", weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User is redirected to the week from which he opened the Reports page")]
        [NUnit.Framework.CategoryAttribute("TC38605")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Automation - Multiple weeks", "WEEK 2", null, Category="QAI")]
        public virtual void UserIsRedirectedToTheWeekFromWhichHeOpenedTheReportsPage(string environment, string menuCycle, string weekName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38605"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User is redirected to the week from which he opened the Reports page", @__tags);
#line 92
this.ScenarioSetup(scenarioInfo);
#line 93
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 94
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
        testRunner.And(string.Format("week \"{0}\" is opened", weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
        testRunner.And("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
    testRunner.When("Cross button is clicked and calendar view has loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
    testRunner.Then(string.Format("Verify week name is \"{0}\"", weekName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
