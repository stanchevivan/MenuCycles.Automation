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
    [NUnit.Framework.DescriptionAttribute("LocalUserPlanningScreen")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    [NUnit.Framework.CategoryAttribute("#")]
    [NUnit.Framework.CategoryAttribute("planningscreen")]
    public partial class LocalUserPlanningScreenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LocalUserPlanningScreen.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LocalUserPlanningScreen", "    Meal Peridos functionalities and validations", ProgrammingLanguage.CSharp, new string[] {
                        "QAI",
                        "#",
                        "planningscreen"});
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
        
        public virtual void FeatureBackground()
        {
#line 5
#line 9
testRunner.And("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Load engine when Planning screen is opened (Local User)")]
        [NUnit.Framework.CategoryAttribute("TC28558")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void LoadEngineWhenPlanningScreenIsOpenedLocalUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Load engine when Planning screen is opened (Local User)", new string[] {
                        "TC28558",
                        "Smoke"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 15
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.When("planning for TUE 10 JUL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
    testRunner.Then("planning screen engine is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save button is disabled for passed days")]
        [NUnit.Framework.CategoryAttribute("TC30226")]
        public virtual void SaveButtonIsDisabledForPassedDays()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save button is disabled for passed days", new string[] {
                        "TC30226"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 22
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.When("planning for TUE 10 JUL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
    testRunner.Then("Save button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Real date is displayed on the top of the planning screen")]
        [NUnit.Framework.CategoryAttribute("TC30227")]
        public virtual void RealDateIsDisplayedOnTheTopOfThePlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Real date is displayed on the top of the planning screen", new string[] {
                        "TC30227"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 29
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
    testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.When("planning for TUE 10 JUL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
    testRunner.Then("location name \"TUESDAY - 10 July 2018\" is present on the top of the planning", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Planning Screen, go to Post-Production, go back to Planning screen")]
        [NUnit.Framework.CategoryAttribute("TC30264")]
        [NUnit.Framework.CategoryAttribute("D25299")]
        public virtual void OpenPlanningScreenGoToPost_ProductionGoBackToPlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Planning Screen, go to Post-Production, go back to Planning screen", new string[] {
                        "TC30264",
                        "D25299"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 36
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
    testRunner.When("planning for TUE 10 JUL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
        testRunner.And("daily post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
        testRunner.And("daily planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.Then("planning screen engine is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Planning Screen, go to Weekly planning")]
        [NUnit.Framework.CategoryAttribute("TC30366")]
        [NUnit.Framework.CategoryAttribute("D25410")]
        public virtual void OpenPlanningScreenGoToWeeklyPlanning()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Planning Screen, go to Weekly planning", new string[] {
                        "TC30366",
                        "D25410"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 45
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
    testRunner.When("planning for WED 11 JUL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
        testRunner.And("switching to Weekly Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
    testRunner.Then("Verify Weekly Planning view is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User should not be redirected to the planning screen after navigating to post-pro" +
            "duction and back")]
        [NUnit.Framework.CategoryAttribute("TC30313")]
        [NUnit.Framework.CategoryAttribute("D25310")]
        public virtual void UserShouldNotBeRedirectedToThePlanningScreenAfterNavigatingToPost_ProductionAndBack()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User should not be redirected to the planning screen after navigating to post-pro" +
                    "duction and back", new string[] {
                        "TC30313",
                        "D25310"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 53
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
    testRunner.When("planning for TUE 10 JUL is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
        testRunner.And("daily post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
        testRunner.And("daily planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And("Cross button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
        testRunner.And("Home button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.Then("Calendar view is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create menu cycle button is not present - local user")]
        [NUnit.Framework.CategoryAttribute("TC27776")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void CreateMenuCycleButtonIsNotPresent_LocalUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create menu cycle button is not present - local user", new string[] {
                        "TC27776",
                        "Smoke"});
#line 64
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 65
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
    testRunner.Then("Create menu cycle button is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save button is clicked without any changes applied (Local user)")]
        [NUnit.Framework.CategoryAttribute("TC30910")]
        [NUnit.Framework.CategoryAttribute("ForDataSeeding")]
        public virtual void SaveButtonIsClickedWithoutAnyChangesAppliedLocalUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save button is clicked without any changes applied (Local user)", new string[] {
                        "TC30910",
                        "ForDataSeeding"});
#line 70
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 71
    testRunner.Given("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
        testRunner.And("Menu Cycle \"Menu Cycle for Local user\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
    testRunner.When("planning for THUR 2 AUG is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.Then("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
