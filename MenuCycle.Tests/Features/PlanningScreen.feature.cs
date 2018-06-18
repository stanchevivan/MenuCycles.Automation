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
#line 14
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 15
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
        testRunner.And("daily nutrition tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
        testRunner.And("daily planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
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
#line 22
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 23
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
        testRunner.And("switching to Weekly Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And("switching to Daily Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
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
#line 31
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 32
    testRunner.Given("a Menu Cycle is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
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
#line 37
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 38
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
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
#line 44
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 45
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
        testRunner.And("Number of covers for meal period \"LUNCH\" is set to random number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
    testRunner.Then("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to t" +
                    "he previous inputted number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
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
#line 57
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 58
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
    testRunner.When("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
        testRunner.And("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
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
#line 70
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 71
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
    testRunner.When("Number of covers for meal period \"LUNCH\" is set to random number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.And("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
        testRunner.And("Cross button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
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
        [NUnit.Framework.CategoryAttribute("D24410")]
        public virtual void OpenMondayPlanningScreenThenGoToTuesdayBackToMondayUpdateTotalQuantityAndClickSave()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Monday planning screen, then go to Tuesday, back to Monday update total quan" +
                    "tity and click Save", new string[] {
                        "TC29080",
                        "D23144",
                        "D24051",
                        "D24410"});
#line 84
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 85
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
        testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
        testRunner.And("Meal Period \"LUNCH\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle"});
            table1.AddRow(new string[] {
                        "LUNCH",
                        "RECIPE",
                        "724Gourmet Beef Burger 6oz"});
            table1.AddRow(new string[] {
                        "LUNCH",
                        "RECIPE",
                        "724Gourmet Chicken Burger"});
#line 90
        testRunner.And("Verify items for meal period \"Lunch\" are (check count \"yes\")", ((string)(null)), table1, "And ");
#line 94
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
        testRunner.And("meal periods for the day are \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
    testRunner.Then("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
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
#line 105
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 106
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
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
#line 116
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 117
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
        testRunner.And("Cross button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
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
#line 127
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 128
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 129
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
        testRunner.And("daily nutrition tab is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
    testRunner.When("daily planning tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
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
#line 138
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 139
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 140
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
        testRunner.And("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are stored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
        testRunner.And("quantity for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to ran" +
                    "dom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
        testRunner.And("weekly Planning view link is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
        testRunner.And("Modal dialog Yes is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
    testRunner.When("switching to Daily Planning view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 146
    testRunner.Then("values for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" are equal to the stor" +
                    "ed ones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Number of covers is saved after closing the app")]
        [NUnit.Framework.CategoryAttribute("D23865")]
        [NUnit.Framework.CategoryAttribute("TC29558")]
        public virtual void NumberOfCoversIsSavedAfterClosingTheApp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Number of covers is saved after closing the app", new string[] {
                        "D23865",
                        "TC29558"});
#line 149
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 150
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 151
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
        testRunner.And("Number of covers for meal period \"LUNCH\" is set to random number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
        testRunner.And("Save button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
        testRunner.And("Notification message \"Planning figures updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
        testRunner.And("Menu Cycles app is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
        testRunner.And("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
        testRunner.And("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
    testRunner.Then("number of covers for meal period \"LUNCH\" is equal to the previous inputted number" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculate Daily Totals")]
        [NUnit.Framework.CategoryAttribute("TC29753")]
        public virtual void CalculateDailyTotals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate Daily Totals", new string[] {
                        "TC29753"});
#line 164
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 165
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 166
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 167
        testRunner.And("Open all is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "TaxPercentage",
                        "SellPrice"});
            table2.AddRow(new string[] {
                        "LUNCH",
                        "RECIPE",
                        "724Gourmet Beef Burger 6oz",
                        "3",
                        "Fixed",
                        "0",
                        "3"});
            table2.AddRow(new string[] {
                        "LUNCH",
                        "RECIPE",
                        "724Gourmet Chicken Burger",
                        "7",
                        "Fixed",
                        "0",
                        "8"});
            table2.AddRow(new string[] {
                        "DINNER",
                        "RECIPE",
                        "703Houmus Sandwich Filling (50g)",
                        "5",
                        "Fixed",
                        "0",
                        "8"});
#line 168
    testRunner.And("data for recipes is set", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "TaxPercentage",
                        "SellPrice"});
            table3.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Maya Buffet",
                        "10",
                        "Fixed",
                        "20",
                        "23"});
            table3.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "1",
                        "Fixed",
                        "5",
                        "20"});
#line 173
    testRunner.And("data for buffets is set", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table4.AddRow(new string[] {
                        "004Fish Stock (bouillon)",
                        "10"});
            table4.AddRow(new string[] {
                        "004Basic Sponge",
                        "20"});
            table4.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "30"});
#line 177
    testRunner.And("data for recipes in buffet \"Maya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table5.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "2"});
            table5.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "3"});
            table5.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "4"});
            table5.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "5"});
            table5.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "6"});
            table5.AddRow(new string[] {
                        "004Baked Beans_1",
                        "7"});
#line 182
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "PlannedQty",
                        "TotalCost",
                        "Revenue",
                        "ActualGP"});
            table6.AddRow(new string[] {
                        "102",
                        "198.48",
                        "315.71",
                        "37%"});
#line 190
    testRunner.Then("Daily Totals are equal to", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No planning data available message")]
        [NUnit.Framework.CategoryAttribute("TC29844")]
        public virtual void NoPlanningDataAvailableMessage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No planning data available message", new string[] {
                        "TC29844"});
#line 195
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 196
    testRunner.Given("Menu Cycle \"Testing Copying Meal Periods\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 197
    testRunner.When("planning for Wednesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
    testRunner.Then("\"No planning data available. Please add a meal period.\" message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
        testRunner.And("Save button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Error message is displayed when changes are made and Update Price button is click" +
            "ed")]
        [NUnit.Framework.CategoryAttribute("TC29845")]
        public virtual void ErrorMessageIsDisplayedWhenChangesAreMadeAndUpdatePriceButtonIsClicked()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error message is displayed when changes are made and Update Price button is click" +
                    "ed", new string[] {
                        "TC29845"});
#line 202
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 203
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 204
        testRunner.And("planning for Friday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 205
    testRunner.When("quantity for recipe named \"004Baked Beans_3\" in meal period \"DANGELO\" is set to r" +
                    "andom number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 206
        testRunner.And("Update prices button is clicked for recipe \"004Baked Beans_3\" in meal period \"DAN" +
                    "GELO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
    testRunner.Then("Notification message \"You have some unsaved changes. Please save them before cont" +
                    "inuing.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No modal dialog is shown if there are no changes and Cancel button is clicked")]
        [NUnit.Framework.CategoryAttribute("TC29885")]
        [NUnit.Framework.CategoryAttribute("D24506")]
        public virtual void NoModalDialogIsShownIfThereAreNoChangesAndCancelButtonIsClicked()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No modal dialog is shown if there are no changes and Cancel button is clicked", new string[] {
                        "TC29885",
                        "D24506"});
#line 210
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 211
        testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 212
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 213
        testRunner.When("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 214
        testRunner.Then("Calendar view is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
