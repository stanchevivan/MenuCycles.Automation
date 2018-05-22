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
    [NUnit.Framework.DescriptionAttribute("Buffet")]
    public partial class BuffetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Buffet.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Buffet", "    Buffet feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 4
#line 8
testRunner.And("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\" and \"Revenue\" should be correct for GP \"Price Model" +
            "\"")]
        [NUnit.Framework.CategoryAttribute("TC27790")]
        public virtual void CalculationsForTotalCostAndRevenueShouldBeCorrectForGPPriceModel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\" and \"Revenue\" should be correct for GP \"Price Model" +
                    "\"", new string[] {
                        "TC27790"});
#line 12
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 13
 testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
    testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
    testRunner.And("Meal Period \"DANGELO\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "Target",
                        "TaxPercentage"});
            table1.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "1",
                        "TariffOne",
                        "GP",
                        "5",
                        "20"});
#line 16
    testRunner.When("data for items is set", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table2.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "2"});
            table2.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "3"});
            table2.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "4"});
            table2.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "5"});
            table2.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "6"});
            table2.AddRow(new string[] {
                        "004Baked Beans_1",
                        "7"});
#line 19
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "Revenue"});
            table3.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "86.88",
                        "91.45"});
#line 27
    testRunner.And("Verify data for items is", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity"});
            table4.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "2"});
#line 30
    testRunner.And("data for items is set", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table5.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "4"});
            table5.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "6"});
            table5.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "8"});
            table5.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "10"});
            table5.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "12"});
            table5.AddRow(new string[] {
                        "004Baked Beans_1",
                        "14"});
#line 33
    testRunner.Then("Verify data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\" and \"Revenue\" and \"Actual GP\" should be correct for" +
            " Fixed \"Price Model\" (Buffet Menu)")]
        [NUnit.Framework.CategoryAttribute("TC27795")]
        public virtual void CalculationsForTotalCostAndRevenueAndActualGPShouldBeCorrectForFixedPriceModelBuffetMenu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\" and \"Revenue\" and \"Actual GP\" should be correct for" +
                    " Fixed \"Price Model\" (Buffet Menu)", new string[] {
                        "TC27795"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 44
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
    testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
    testRunner.And("Meal Period \"DANGELO\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "TaxPercentage",
                        "SellPrice"});
            table6.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "1",
                        "TariffOne",
                        "Fixed",
                        "5",
                        "100"});
#line 47
    testRunner.When("data for items is set", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table7.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "2"});
            table7.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "3"});
            table7.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "4"});
            table7.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "5"});
            table7.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "6"});
            table7.AddRow(new string[] {
                        "004Baked Beans_1",
                        "7"});
#line 50
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "Revenue"});
            table8.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "86.88",
                        "95.24"});
#line 58
    testRunner.And("Verify data for items is", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity"});
            table9.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "2"});
#line 61
    testRunner.And("data for items is set", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table10.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "4"});
            table10.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "6"});
            table10.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "8"});
            table10.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "10"});
            table10.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "12"});
            table10.AddRow(new string[] {
                        "004Baked Beans_1",
                        "14"});
#line 64
    testRunner.Then("Verify data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\" and \"Sell Price\" and \"Revenue\" should be correct fo" +
            "r Mark Up \"Price Model\" (Buffet Menu)")]
        [NUnit.Framework.CategoryAttribute("TC27796")]
        public virtual void CalculationsForTotalCostAndSellPriceAndRevenueShouldBeCorrectForMarkUpPriceModelBuffetMenu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\" and \"Sell Price\" and \"Revenue\" should be correct fo" +
                    "r Mark Up \"Price Model\" (Buffet Menu)", new string[] {
                        "TC27796"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 75
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
    testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
    testRunner.And("Meal Period \"DANGELO\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "Target",
                        "TaxPercentage"});
            table11.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "1",
                        "TariffOne",
                        "Markup",
                        "5",
                        "20"});
#line 78
    testRunner.When("data for items is set", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table12.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "1"});
            table12.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "2"});
            table12.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "3"});
#line 81
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table13.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "24.21",
                        "30.5",
                        "25.42",
                        "5%"});
#line 86
    testRunner.And("Verify data for items is", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity"});
            table14.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "2"});
#line 89
    testRunner.And("data for items is set", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table15.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "2"});
            table15.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "4"});
            table15.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "6"});
#line 92
    testRunner.Then("Verify data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table15, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
