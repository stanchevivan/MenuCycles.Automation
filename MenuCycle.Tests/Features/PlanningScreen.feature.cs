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
    [NUnit.Framework.DescriptionAttribute("PlanningScreen")]
    public partial class PlanningScreenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PlanningScreen.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlanningScreen", "    Meal Peridos functionalities and validations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Planning Screen, go to Nutritions, go back to Planning screen (Central User)" +
            "")]
        [NUnit.Framework.CategoryAttribute("TC28526")]
        public virtual void OpenPlanningScreenGoToNutritionsGoBackToPlanningScreenCentralUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Planning Screen, go to Nutritions, go back to Planning screen (Central User)" +
                    "", new string[] {
                        "TC28526"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 14
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
        testRunner.And("daily nutrition tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
        testRunner.And("daily planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.Then("planning screen engine is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Planning Screen, go to Weeks, go back to Planning screen (Central User)")]
        [NUnit.Framework.CategoryAttribute("TC28555")]
        public virtual void OpenPlanningScreenGoToWeeksGoBackToPlanningScreenCentralUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Planning Screen, go to Weeks, go back to Planning screen (Central User)", new string[] {
                        "TC28555"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 22
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
        testRunner.And("switching to Weekly Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
        testRunner.And("switching to Daily Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
    testRunner.Then("planning screen engine is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Planning Screen, go to Post-Production, go back to Planning screen (Local Us" +
            "er)")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        [NUnit.Framework.CategoryAttribute("TC28557")]
        public virtual void OpenPlanningScreenGoToPost_ProductionGoBackToPlanningScreenLocalUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Planning Screen, go to Post-Production, go back to Planning screen (Local Us" +
                    "er)", new string[] {
                        "TC28557",
                        "ignore"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 31
    testRunner.Given("a Menu Cycle is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
    testRunner.Then("the planning screen for Tuesday is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save button is clicked without any changes applied")]
        [NUnit.Framework.CategoryAttribute("TC29023")]
        public virtual void SaveButtonIsClickedWithoutAnyChangesApplied()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save button is clicked without any changes applied", new string[] {
                        "TC29023"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 37
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.Then("the user stays on the planning page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save all updated figures (fields)")]
        [NUnit.Framework.CategoryAttribute("TC29022")]
        public virtual void SaveAllUpdatedFiguresFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save all updated figures (fields)", new string[] {
                        "TC29022"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 44
     testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
     testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.Then("Save button is clicked and the message \'Planning figures updated.\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to t" +
                    "he previous inputted number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
        testRunner.And("the user stays on the planning page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Saved data is retrieved from the API")]
        [NUnit.Framework.CategoryAttribute("TC29024")]
        public virtual void SavedDataIsRetrievedFromTheAPI()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Saved data is retrieved from the API", new string[] {
                        "TC29024"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 54
     testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
     testRunner.When("Save button is clicked and the message \'Planning figures updated.\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
     testRunner.Then("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to t" +
                    "he previous inputted number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully Update and Save number of covers")]
        [NUnit.Framework.CategoryAttribute("TC29019")]
        public virtual void SuccessfullyUpdateAndSaveNumberOfCovers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully Update and Save number of covers", new string[] {
                        "TC29019"});
#line 64
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 65
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
    testRunner.When("Number of covers value for meal period \"LUNCH\" is set to random number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
        testRunner.And("Save button is clicked and the message \'Planning figures updated.\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
        testRunner.And("Cross button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
    testRunner.Then("number of covers for meal period \"LUNCH\" is equal to the previous inputted number" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Monday planning screen, then go to Tuesday, back to Monday update total quan" +
            "tity and click Save")]
        [NUnit.Framework.CategoryAttribute("TC29080")]
        [NUnit.Framework.CategoryAttribute("D23144")]
        public virtual void OpenMondayPlanningScreenThenGoToTuesdayBackToMondayUpdateTotalQuantityAndClickSave()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Monday planning screen, then go to Tuesday, back to Monday update total quan" +
                    "tity and click Save", new string[] {
                        "TC29080",
                        "D23144"});
#line 76
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 77
     testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
        testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
     testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
     testRunner.Then("Save button is clicked and the message \'Planning figures updated.\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to t" +
                    "he previous inputted number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Error message is displayed when planned quantity for recipe is set to number <= 0" +
            "")]
        [NUnit.Framework.CategoryAttribute("TC29101")]
        public virtual void ErrorMessageIsDisplayedWhenPlannedQuantityForRecipeIsSetToNumber0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error message is displayed when planned quantity for recipe is set to number <= 0" +
                    "", new string[] {
                        "TC29101"});
#line 89
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 90
     testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
     testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"0\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
     testRunner.Then("Save button is clicked and the message \'Sorry, we could not proceed with your req" +
                    "uest\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
