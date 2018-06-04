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
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
    testRunner.Then("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to t" +
                    "he previous inputted number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
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
#line 55
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 56
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.When("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
        testRunner.And("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
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
#line 68
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 69
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
    testRunner.When("Number of covers for meal period \"LUNCH\" is set to random number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
        testRunner.And("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
        testRunner.And("Cross button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
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
        [NUnit.Framework.CategoryAttribute("D24051")]
        public virtual void OpenMondayPlanningScreenThenGoToTuesdayBackToMondayUpdateTotalQuantityAndClickSave()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Monday planning screen, then go to Tuesday, back to Monday update total quan" +
                    "tity and click Save", new string[] {
                        "TC29080",
                        "D23144",
                        "D24051"});
#line 82
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 83
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
        testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
        testRunner.And("meal periods for the day are \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
    testRunner.Then("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to t" +
                    "he previous inputted number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Modal dialog for unsaved changes is shown on cancel")]
        [NUnit.Framework.CategoryAttribute("TC29521")]
        public virtual void ModalDialogForUnsavedChangesIsShownOnCancel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modal dialog for unsaved changes is shown on cancel", new string[] {
                        "TC29521"});
#line 98
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 99
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 100
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
    testRunner.Then("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are equal to the stor" +
                    "ed ones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Modal dialog for unsaved changes is shown on pressing X")]
        [NUnit.Framework.CategoryAttribute("TC29521")]
        public virtual void ModalDialogForUnsavedChangesIsShownOnPressingX()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modal dialog for unsaved changes is shown on pressing X", new string[] {
                        "TC29521"});
#line 109
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 110
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
        testRunner.And("Cross button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
    testRunner.Then("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are equal to the stor" +
                    "ed ones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Modal dialog for unsaved changes is shown when going to nutrition")]
        [NUnit.Framework.CategoryAttribute("TC29526")]
        public virtual void ModalDialogForUnsavedChangesIsShownWhenGoingToNutrition()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modal dialog for unsaved changes is shown when going to nutrition", new string[] {
                        "TC29526"});
#line 120
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 121
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
        testRunner.And("daily nutrition tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
    testRunner.When("daily planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
    testRunner.Then("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are equal to the stor" +
                    "ed ones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Modal dialog for unsaved changes is shown when going to weekly planning view")]
        [NUnit.Framework.CategoryAttribute("TC29521")]
        public virtual void ModalDialogForUnsavedChangesIsShownWhenGoingToWeeklyPlanningView()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modal dialog for unsaved changes is shown when going to weekly planning view", new string[] {
                        "TC29521"});
#line 131
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 132
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 133
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
        testRunner.And("switching to Weekly Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
    testRunner.When("switching to Daily Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
    testRunner.Then("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are equal to the stor" +
                    "ed ones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Number of covers is saved after closing the app")]
        [NUnit.Framework.CategoryAttribute("D23865")]
        public virtual void NumberOfCoversIsSavedAfterClosingTheApp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Number of covers is saved after closing the app", new string[] {
                        "D23865"});
#line 142
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 143
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 144
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
        testRunner.And("Number of covers for meal period \"LUNCH\" is set to random number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
        testRunner.And("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
        testRunner.And("Menu Cycles app is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
        testRunner.And("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
        testRunner.And("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
    testRunner.Then("number of covers for meal period \"LUNCH\" is equal to the previous inputted number" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
