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
    [NUnit.Framework.DescriptionAttribute("Reports")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    public partial class ReportsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Reports.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Reports", "    Reports feature", ProgrammingLanguage.CSharp, new string[] {
                        "QAI"});
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
        [NUnit.Framework.DescriptionAttribute("Open report page for menu cycle without items")]
        [NUnit.Framework.CategoryAttribute("TC32573")]
        [NUnit.Framework.CategoryAttribute("D28281")]
        public virtual void OpenReportPageForMenuCycleWithoutItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open report page for menu cycle without items", new string[] {
                        "TC32573",
                        "D28281"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.And("Menu Cycle \"MC without items\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
    testRunner.Then("Reports page is correctly loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consumer Facing Report - Price options are not disabled for Local user")]
        public virtual void ConsumerFacingReport_PriceOptionsAreNotDisabledForLocalUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consumer Facing Report - Price options are not disabled for Local user", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.Then("Verify Include sell price is not checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
        testRunner.And("Verify Price type dropdown is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Export Consumer Facing Report as PDF with Sell Price, Kilojoules and Calories")]
        [NUnit.Framework.CategoryAttribute("TC33979")]
        [NUnit.Framework.CategoryAttribute("TC34204")]
        public virtual void ExportConsumerFacingReportAsPDFWithSellPriceKilojoulesAndCalories()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Export Consumer Facing Report as PDF with Sell Price, Kilojoules and Calories", new string[] {
                        "TC33979",
                        "TC34204"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
        testRunner.And("Report start date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
        testRunner.And("Report end date \"25/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
        testRunner.And("Export CSV and Export PDF buttons are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
        testRunner.And("Include sell price is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
        testRunner.And("Calories checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
        testRunner.And("Kilojoules checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
        testRunner.And("Export PDF button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.Then("Verify notification message \"Successfully Exported\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Export Consumer Facing Report as CSV with Sell Price, Kilojoules and Calories")]
        [NUnit.Framework.CategoryAttribute("TC34203")]
        public virtual void ExportConsumerFacingReportAsCSVWithSellPriceKilojoulesAndCalories()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Export Consumer Facing Report as CSV with Sell Price, Kilojoules and Calories", new string[] {
                        "TC34203"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
        testRunner.And("Report start date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
        testRunner.And("Report end date \"25/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And("Export CSV and Export PDF buttons are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
        testRunner.And("Include sell price is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
        testRunner.And("Calories checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
        testRunner.And("Kilojoules checkbox is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And("Export CSV button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.Then("Verify notification message \"Successfully Exported\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consumer Facing Report - Local > User is able to export Consumer Facing report as" +
            " PDF without selecting Calories, kilojoules and Sell Price")]
        [NUnit.Framework.CategoryAttribute("TC33983")]
        public virtual void ConsumerFacingReport_LocalUserIsAbleToExportConsumerFacingReportAsPDFWithoutSelectingCaloriesKilojoulesAndSellPrice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consumer Facing Report - Local > User is able to export Consumer Facing report as" +
                    " PDF without selecting Calories, kilojoules and Sell Price", new string[] {
                        "TC33983"});
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
        testRunner.And("Report start date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
        testRunner.And("Report end date \"25/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
        testRunner.And("Export CSV and Export PDF buttons are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
        testRunner.And("Export PDF button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.Then("Verify notification message \"Successfully Exported\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consumer Facing Report - Local > User is able to export Consumer Facing report as" +
            " CSV without selecting Calories, kilojoules and Sell Price")]
        [NUnit.Framework.CategoryAttribute("TC34205")]
        public virtual void ConsumerFacingReport_LocalUserIsAbleToExportConsumerFacingReportAsCSVWithoutSelectingCaloriesKilojoulesAndSellPrice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consumer Facing Report - Local > User is able to export Consumer Facing report as" +
                    " CSV without selecting Calories, kilojoules and Sell Price", new string[] {
                        "TC34205"});
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
        testRunner.And("Report start date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
        testRunner.And("Report end date \"25/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
        testRunner.And("Export CSV and Export PDF buttons are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
        testRunner.And("Export CSV button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
    testRunner.Then("Verify notification message \"Successfully Exported\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consumer Facing Report - Local > Error message is displayed if selected end date " +
            "is after MC end date")]
        [NUnit.Framework.CategoryAttribute("TC33981")]
        public virtual void ConsumerFacingReport_LocalErrorMessageIsDisplayedIfSelectedEndDateIsAfterMCEndDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consumer Facing Report - Local > Error message is displayed if selected end date " +
                    "is after MC end date", new string[] {
                        "TC33981"});
#line 94
this.ScenarioSetup(scenarioInfo);
#line 95
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
        testRunner.And("Report start date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
        testRunner.And("Report end date \"31/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
        testRunner.And("Export CSV button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
    testRunner.Then("Verify notification message \"Please select a report end date that is before the m" +
                    "enu cycle end date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
        testRunner.And("Export PDF button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
        testRunner.And("Verify notification message \"Please select a report end date that is before the m" +
                    "enu cycle end date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consumer facing report - Local > Error message is displayed if selected start dat" +
            "e is before MC start date")]
        [NUnit.Framework.CategoryAttribute("TC33994")]
        public virtual void ConsumerFacingReport_LocalErrorMessageIsDisplayedIfSelectedStartDateIsBeforeMCStartDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consumer facing report - Local > Error message is displayed if selected start dat" +
                    "e is before MC start date", new string[] {
                        "TC33994"});
#line 111
this.ScenarioSetup(scenarioInfo);
#line 112
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 113
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
        testRunner.And("Report start date \"08/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
        testRunner.And("Report end date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
        testRunner.And("Export CSV button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
    testRunner.Then("Verify notification message \"Please select a report start date that is after the " +
                    "menu cycle start date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
        testRunner.And("Export PDF button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
        testRunner.And("Verify notification message \"Please select a report start date that is after the " +
                    "menu cycle start date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consumer Facing Report  - Local > Error message is displayed if selected end date" +
            " is before selected start date")]
        [NUnit.Framework.CategoryAttribute("TC33999")]
        public virtual void ConsumerFacingReport_LocalErrorMessageIsDisplayedIfSelectedEndDateIsBeforeSelectedStartDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consumer Facing Report  - Local > Error message is displayed if selected end date" +
                    " is before selected start date", new string[] {
                        "TC33999"});
#line 128
this.ScenarioSetup(scenarioInfo);
#line 129
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 130
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
        testRunner.And("Report \"ConsumerFacing\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
        testRunner.And("Report start date \"20/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
        testRunner.And("Export CSV and Export PDF buttons are not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
        testRunner.And("Report end date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
        testRunner.And("Export CSV button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
    testRunner.Then("Verify notification message \"Please select an end date that is not before the sta" +
                    "rt date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
        testRunner.And("Export PDF button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
        testRunner.And("Verify notification message \"Please select an end date that is not before the sta" +
                    "rt date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipe Card Report - Local > Error message is displayed if selected start date is" +
            " before MC start date")]
        [NUnit.Framework.CategoryAttribute("TC33980")]
        public virtual void RecipeCardReport_LocalErrorMessageIsDisplayedIfSelectedStartDateIsBeforeMCStartDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipe Card Report - Local > Error message is displayed if selected start date is" +
                    " before MC start date", new string[] {
                        "TC33980"});
#line 145
this.ScenarioSetup(scenarioInfo);
#line 146
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 147
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
        testRunner.And("Report \"RecipeCard\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
        testRunner.And("Report start date \"08/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
        testRunner.And("Report end date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriod"});
            table1.AddRow(new string[] {
                        "Lunch"});
            table1.AddRow(new string[] {
                        "Dinner"});
#line 154
        testRunner.And("Meal periods are selected", ((string)(null)), table1, "And ");
#line 158
        testRunner.And("Report is exported", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
    testRunner.Then("Verify notification message \"Please select a report start date that is after the " +
                    "menu cycle start date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipe Card Report - Local > Error message is displayed if selected end date is b" +
            "efore selected start date")]
        [NUnit.Framework.CategoryAttribute("TC33982")]
        public virtual void RecipeCardReport_LocalErrorMessageIsDisplayedIfSelectedEndDateIsBeforeSelectedStartDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipe Card Report - Local > Error message is displayed if selected end date is b" +
                    "efore selected start date", new string[] {
                        "TC33982"});
#line 162
this.ScenarioSetup(scenarioInfo);
#line 163
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 164
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
        testRunner.And("Report \"RecipeCard\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
        testRunner.And("Report start date \"20/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
        testRunner.And("Report end date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriod"});
            table2.AddRow(new string[] {
                        "Lunch"});
            table2.AddRow(new string[] {
                        "Dinner"});
#line 171
        testRunner.And("Meal periods are selected", ((string)(null)), table2, "And ");
#line 175
        testRunner.And("Report is exported", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
    testRunner.Then("Verify notification message \"Please select an end date that is not before the sta" +
                    "rt date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipe Card Report - Central > Export button is displayed after meal period is sp" +
            "ecified")]
        [NUnit.Framework.CategoryAttribute("TC33988")]
        public virtual void RecipeCardReport_CentralExportButtonIsDisplayedAfterMealPeriodIsSpecified()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipe Card Report - Central > Export button is displayed after meal period is sp" +
                    "ecified", new string[] {
                        "TC33988"});
#line 179
this.ScenarioSetup(scenarioInfo);
#line 180
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 181
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
        testRunner.And("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 184
        testRunner.And("Report \"RecipeCard\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
        testRunner.And("Export button is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriod"});
            table3.AddRow(new string[] {
                        "Lunch"});
            table3.AddRow(new string[] {
                        "Dinner"});
#line 186
        testRunner.And("Meal periods are selected", ((string)(null)), table3, "And ");
#line 190
    testRunner.Then("Verify Export button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipe Card Report - Local > Error message is displayed if selected end date is a" +
            "fter MC end date")]
        [NUnit.Framework.CategoryAttribute("TC33997")]
        public virtual void RecipeCardReport_LocalErrorMessageIsDisplayedIfSelectedEndDateIsAfterMCEndDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipe Card Report - Local > Error message is displayed if selected end date is a" +
                    "fter MC end date", new string[] {
                        "TC33997"});
#line 195
this.ScenarioSetup(scenarioInfo);
#line 196
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 197
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
        testRunner.And("location \"SE001\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
        testRunner.And("Menu Cycle \"Local User Testing\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
        testRunner.And("Report \"RecipeCard\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 202
        testRunner.And("Report start date \"11/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
        testRunner.And("Report end date \"31/07/2018\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriod"});
            table4.AddRow(new string[] {
                        "Lunch"});
            table4.AddRow(new string[] {
                        "Dinner"});
#line 204
        testRunner.And("Meal periods are selected", ((string)(null)), table4, "And ");
#line 208
        testRunner.And("Report is exported", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 209
    testRunner.Then("Verify notification message \"Please select a report end date that is before the m" +
                    "enu cycle end date\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Menu Extract Report - Central > Export button is displayed and clicked after meal" +
            " period is specified")]
        [NUnit.Framework.CategoryAttribute("TC33985")]
        public virtual void MenuExtractReport_CentralExportButtonIsDisplayedAndClickedAfterMealPeriodIsSpecified()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Menu Extract Report - Central > Export button is displayed and clicked after meal" +
                    " period is specified", new string[] {
                        "TC33985"});
#line 212
this.ScenarioSetup(scenarioInfo);
#line 213
    testRunner.Given("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 214
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 215
        testRunner.And("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
    testRunner.When("Reports page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 217
        testRunner.And("Report \"MenuExtract\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 218
        testRunner.And("Export button is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriod"});
            table5.AddRow(new string[] {
                        "Chloe"});
#line 219
        testRunner.And("Meal periods are selected", ((string)(null)), table5, "And ");
#line 222
    testRunner.Then("Verify Export button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 223
        testRunner.And("Report is exported", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 224
        testRunner.And("Verify notification message \"Successfully Exported\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
