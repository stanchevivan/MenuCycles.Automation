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
    [NUnit.Framework.DescriptionAttribute("LocalUserPlanningScreen")]
    public partial class LocalUserPlanningScreenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LocalUserPlanningScreen.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LocalUserPlanningScreen", "    Meal Peridos functionalities and validations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Verify save button is disabled for passed days")]
        [NUnit.Framework.CategoryAttribute("TC30226")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "FOR Local User AUTOMATION", "WED 31 JUL", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void VerifySaveButtonIsDisabledForPassedDays(string environment, string withFA, string location, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30226"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify save button is disabled for passed days", null, @__tags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
        testRunner.And("week \"WEEK 1\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
    testRunner.Then("Verify save button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Real date is displayed on the top of the planning screen")]
        [NUnit.Framework.CategoryAttribute("TC30227")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "FOR Local User AUTOMATION", "WED 31 JUL", "WEDNESDAY - 31 July 2019", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void RealDateIsDisplayedOnTheTopOfThePlanningScreen(string environment, string withFA, string location, string menuCycle, string day, string date, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30227"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Real date is displayed on the top of the planning screen", null, @__tags);
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
        testRunner.And("week \"WEEK 1\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
    testRunner.Then(string.Format("location name \"{0}\" is present on the top of the planning", date), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Planning Screen, go to Weekly planning")]
        [NUnit.Framework.CategoryAttribute("TC30366")]
        [NUnit.Framework.CategoryAttribute("D25410")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "FOR Local User AUTOMATION", "WED 31 JUL", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void OpenPlanningScreenGoToWeeklyPlanning(string environment, string withFA, string location, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30366",
                    "D25410"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Planning Screen, go to Weekly planning", null, @__tags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
        testRunner.And("week \"WEEK 1\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
        testRunner.And("Weeks tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
    testRunner.Then("Verify Weekly Planning view is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User should not be redirected to the planning screen after navigating to post-pro" +
            "duction and back")]
        [NUnit.Framework.CategoryAttribute("TC30313")]
        [NUnit.Framework.CategoryAttribute("D25310")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "FOR Local User AUTOMATION", "WED 31 JUL", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void UserShouldNotBeRedirectedToThePlanningScreenAfterNavigatingToPost_ProductionAndBack(string environment, string withFA, string location, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30313",
                    "D25310"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User should not be redirected to the planning screen after navigating to post-pro" +
                    "duction and back", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
        testRunner.And("week \"WEEK 1\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
        testRunner.And("planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.And("Calendar tab is clicked and calendar view has loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("Home button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
    testRunner.Then("Verify calendar view is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create menu cycle button is not present - local user")]
        [NUnit.Framework.CategoryAttribute("TC27776")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CreateMenuCycleButtonIsNotPresent_LocalUser(string environment, string withFA, string location, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27776",
                    "Smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create menu cycle button is not present - local user", null, @__tags);
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 77
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.Then("Create menu cycle button is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Current week is opened when opening a non-expired menu cycle")]
        [NUnit.Framework.CategoryAttribute("TC38354")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "FOR Local User AUTOMATION", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CurrentWeekIsOpenedWhenOpeningANon_ExpiredMenuCycle(string environment, string withFA, string location, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38354"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Current week is opened when opening a non-expired menu cycle", null, @__tags);
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 105
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
    testRunner.When("Verify calendar view is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
    testRunner.Then("Verify real world week is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Last week is opened when opening a menu cycle in the past")]
        [NUnit.Framework.CategoryAttribute("TC38355")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Local User Expired", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void LastWeekIsOpenedWhenOpeningAMenuCycleInThePast(string environment, string withFA, string location, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38355"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Last week is opened when opening a menu cycle in the past", null, @__tags);
#line 118
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 119
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 120
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
    testRunner.When("Verify calendar view is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
    testRunner.Then("Verify week name is \"WEEK 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
