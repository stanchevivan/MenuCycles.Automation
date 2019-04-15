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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\" and \"Revenue\" should be correct for GP \"Price Model" +
            "\"")]
        [NUnit.Framework.CategoryAttribute("TC27790")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "Meda", "DANGELO", "TUESDAY", null, Category="QAI")]
        public virtual void CalculationsForTotalCostAndRevenueShouldBeCorrectForGPPriceModel(string environment, string menuCycle, string mealPeriod, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27790"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\" and \"Revenue\" should be correct for GP \"Price Model" +
                    "\"", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
        testRunner.And(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
        testRunner.And(string.Format("Meal Period \"{0}\" is expanded", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
#line 11
    testRunner.When("data for buffets is set", ((string)(null)), table1, "When ");
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
#line 14
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table3.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "70.79",
                        "89.42",
                        "74.52",
                        "5%"});
#line 22
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
#line 25
    testRunner.And("data for buffets is set", ((string)(null)), table4, "And ");
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
#line 28
    testRunner.Then("Verify data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table6.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "141.59",
                        "89.42",
                        "149.04",
                        "5%"});
#line 36
    testRunner.And("Verify data for items is", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\" and \"Revenue\" and \"Actual GP\" should be correct for" +
            " Fixed \"Price Model\" (Buffet Menu)")]
        [NUnit.Framework.CategoryAttribute("TC27795")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "Meda", "DANGELO", "TUESDAY", null, Category="QAI")]
        public virtual void CalculationsForTotalCostAndRevenueAndActualGPShouldBeCorrectForFixedPriceModelBuffetMenu(string environment, string menuCycle, string mealPeriod, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27795"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\" and \"Revenue\" and \"Actual GP\" should be correct for" +
                    " Fixed \"Price Model\" (Buffet Menu)", @__tags);
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
        testRunner.And(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
        testRunner.And(string.Format("Meal Period \"{0}\" is expanded", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "TaxPercentage",
                        "SellPrice"});
            table7.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "1",
                        "TariffOne",
                        "Fixed",
                        "5",
                        "100"});
#line 52
    testRunner.When("data for buffets is set", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table8.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "2"});
            table8.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "3"});
            table8.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "4"});
            table8.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "5"});
            table8.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "6"});
            table8.AddRow(new string[] {
                        "004Baked Beans_1",
                        "7"});
#line 55
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "Revenue",
                        "ActualGP"});
            table9.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "70.79",
                        "95.24",
                        "26%"});
#line 63
    testRunner.And("Verify data for items is", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity"});
            table10.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "2"});
#line 66
    testRunner.And("data for buffets is set", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table11.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "4"});
            table11.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "6"});
            table11.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "8"});
            table11.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "10"});
            table11.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "12"});
            table11.AddRow(new string[] {
                        "004Baked Beans_1",
                        "14"});
#line 69
    testRunner.Then("Verify data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table11, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "Revenue",
                        "ActualGP"});
            table12.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "141.59",
                        "190.48",
                        "26%"});
#line 77
    testRunner.And("Verify data for items is", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\" and \"Sell Price\" and \"Revenue\" should be correct fo" +
            "r Mark Up \"Price Model\" (Buffet Menu)")]
        [NUnit.Framework.CategoryAttribute("TC27796")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "Meda", "DANGELO", "TUESDAY", null, Category="QAI")]
        public virtual void CalculationsForTotalCostAndSellPriceAndRevenueShouldBeCorrectForMarkUpPriceModelBuffetMenu(string environment, string menuCycle, string mealPeriod, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27796"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\" and \"Sell Price\" and \"Revenue\" should be correct fo" +
                    "r Mark Up \"Price Model\" (Buffet Menu)", @__tags);
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
        testRunner.And(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
        testRunner.And(string.Format("Meal Period \"{0}\" is expanded", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "Target",
                        "TaxPercentage"});
            table13.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "1",
                        "TariffOne",
                        "Markup",
                        "5",
                        "20"});
#line 93
    testRunner.When("data for buffets is set", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table14.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "2"});
            table14.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "3"});
            table14.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "4"});
            table14.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "5"});
            table14.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "6"});
            table14.AddRow(new string[] {
                        "004Baked Beans_1",
                        "7"});
#line 96
    testRunner.And("data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table15.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "70.79",
                        "89.2",
                        "74.33",
                        "5%"});
#line 104
    testRunner.And("Verify data for items is", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "Target"});
            table16.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "2",
                        "43"});
#line 107
    testRunner.And("data for buffets is set", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table17.AddRow(new string[] {
                        "004Bechamel Sauce",
                        "4"});
            table17.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "6"});
            table17.AddRow(new string[] {
                        "004Tartare Sauce (bulk)",
                        "8"});
            table17.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "10"});
            table17.AddRow(new string[] {
                        "004Blueberry Muffin (Wrapped)",
                        "12"});
            table17.AddRow(new string[] {
                        "004Baked Beans_1",
                        "14"});
#line 110
    testRunner.Then("Verify data for recipes in buffet \"Aneliya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table17, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table18.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Aneliya Buffet",
                        "141.59",
                        "121.48",
                        "202.47",
                        "30%"});
#line 118
    testRunner.And("Verify data for items is", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Planned Quantity Values are rounded after scaling")]
        [NUnit.Framework.CategoryAttribute("TC30088")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "Meda", "FRIDAY", null, Category="QAI")]
        public virtual void PlannedQuantityValuesAreRoundedAfterScaling(string environment, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30088"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Planned Quantity Values are rounded after scaling", @__tags);
#line 128
this.ScenarioSetup(scenarioInfo);
#line 129
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 130
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
        testRunner.And(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity"});
            table19.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Maya Buffet",
                        "5"});
#line 133
    testRunner.When("data for buffets is set", ((string)(null)), table19, "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table20.AddRow(new string[] {
                        "004Basic Sponge",
                        "6"});
            table20.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "7"});
#line 136
    testRunner.And("data for recipes in buffet \"Maya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table20, "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity"});
            table21.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Maya Buffet",
                        "6"});
#line 140
   testRunner.And("data for buffets is set", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table22.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "8"});
            table22.AddRow(new string[] {
                        "004Basic Sponge",
                        "7"});
#line 143
    testRunner.Then("Verify data for recipes in buffet \"Maya Buffet\" in meal period \"DANGELO\" is", ((string)(null)), table22, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
