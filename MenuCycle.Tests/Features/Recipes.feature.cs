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
    [NUnit.Framework.DescriptionAttribute("Recipes")]
    public partial class RecipesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Recipes.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Recipes", "    Recipes feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Retrieve recipe information from the API")]
        [NUnit.Framework.CategoryAttribute("TC28829")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void RetrieveRecipeInformationFromTheAPI()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retrieve recipe information from the API", new string[] {
                        "TC28829",
                        "Smoke"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 14
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
    testRunner.When("planning for Thursday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "Type",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "CostPerUnit",
                        "TotalCosts",
                        "TariffType",
                        "PriceModel",
                        "Target",
                        "TaxPercentage",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table1.AddRow(new string[] {
                        "DANGELO",
                        "RECIPE",
                        "Cheese",
                        "2",
                        "20.27",
                        "40.54",
                        "TariffTwo",
                        "Markup",
                        "12",
                        "20",
                        "27.24",
                        "45.4",
                        "11%"});
#line 16
    testRunner.Then("verify the following recipes:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Target %\" field is not present and \"Sell Price\" can be edited if \"Price model\" =" +
            " \"Fixed\"")]
        [NUnit.Framework.CategoryAttribute("TC28830")]
        public virtual void TargetFieldIsNotPresentAndSellPriceCanBeEditedIfPriceModelFixed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Target %\" field is not present and \"Sell Price\" can be edited if \"Price model\" =" +
                    " \"Fixed\"", new string[] {
                        "TC28830"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 22
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.Then("Target % field for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is not presen" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
        testRunner.And("Sell Price for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is an editable fi" +
                    "eld", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Target GP % has format: float and type: 2 decimals")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        [NUnit.Framework.CategoryAttribute("TC29033")]
        public virtual void TargetGPHasFormatFloatAndType2Decimals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Target GP % has format: float and type: 2 decimals", new string[] {
                        "TC29033",
                        "ignore"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 30
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"GP\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    ".333333\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.Then("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to " +
                    "\"2.33\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Target Mark up % has format: float and type: 2 decimals")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        [NUnit.Framework.CategoryAttribute("TC29034")]
        public virtual void TargetMarkUpHasFormatFloatAndType2Decimals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Target Mark up % has format: float and type: 2 decimals", new string[] {
                        "TC29034",
                        "ignore"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 39
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Marku" +
                    "p\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    ".333333\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.Then("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to " +
                    "\"2.33\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Min selected Target GP % is -99.99")]
        [NUnit.Framework.CategoryAttribute("TC29035")]
        public virtual void MinSelectedTargetGPIs_99_99()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Min selected Target GP % is -99.99", new string[] {
                        "TC29035"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 48
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"GP\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"-" +
                    "100\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.And("red border is displayed around Target% for recipe \"004Baked Beans_3\" in meal peri" +
                    "od \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"-" +
                    "99.99\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
    testRunner.Then("red border is not displayed around Target% for recipe \"004Baked Beans_3\" in meal " +
                    "period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Min selected Target Markup % is 0")]
        [NUnit.Framework.CategoryAttribute("TC29036")]
        public virtual void MinSelectedTargetMarkupIs0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Min selected Target Markup % is 0", new string[] {
                        "TC29036"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 60
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Marku" +
                    "p\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"-" +
                    "1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
    testRunner.And("red border is displayed around Target% for recipe \"004Baked Beans_3\" in meal peri" +
                    "od \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"0" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
    testRunner.Then("red border is not displayed around Target% for recipe \"004Baked Beans_3\" in meal " +
                    "period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Max selected Target GP % is 99.99")]
        [NUnit.Framework.CategoryAttribute("TC29037")]
        public virtual void MaxSelectedTargetGPIs99_99()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Max selected Target GP % is 99.99", new string[] {
                        "TC29037"});
#line 71
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 72
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"GP\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"1" +
                    "00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
    testRunner.And("red border is displayed around Target% for recipe \"004Baked Beans_3\" in meal peri" +
                    "od \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"9" +
                    "9.99\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.Then("red border is not displayed around Target% for recipe \"004Baked Beans_3\" in meal " +
                    "period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Max selected Target Markup % is 100")]
        [NUnit.Framework.CategoryAttribute("TC29038")]
        public virtual void MaxSelectedTargetMarkupIs100()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Max selected Target Markup % is 100", new string[] {
                        "TC29038"});
#line 83
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 84
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Marku" +
                    "p\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"2" +
                    "00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
    testRunner.And("red border is displayed around Target% for recipe \"004Baked Beans_3\" in meal peri" +
                    "od \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
        testRunner.And("TargetGP% for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"1" +
                    "00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
    testRunner.Then("red border is not displayed around Target% for recipe \"004Baked Beans_3\" in meal " +
                    "period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Min selected Sell Price is 0 - Price model = \"Fixed\"")]
        [NUnit.Framework.CategoryAttribute("TC29039")]
        public virtual void MinSelectedSellPriceIs0_PriceModelFixed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Min selected Sell Price is 0 - Price model = \"Fixed\"", new string[] {
                        "TC29039"});
#line 95
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 96
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"-" +
                    "1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
    testRunner.And("red border is displayed around Sell Price for recipe \"004Baked Beans_3\" in meal p" +
                    "eriod \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"0" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
    testRunner.Then("red border is not displayed around Sell Price for recipe \"004Baked Beans_3\" in me" +
                    "al period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No max value for \"Sell Price\" - Price model = \"Fixed\"")]
        [NUnit.Framework.CategoryAttribute("TC29040")]
        public virtual void NoMaxValueForSellPrice_PriceModelFixed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No max value for \"Sell Price\" - Price model = \"Fixed\"", new string[] {
                        "TC29040"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 108
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 109
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
        testRunner.And("Price model for recipe \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"Fixed" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
        testRunner.And("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is set to \"1" +
                    "0000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
    testRunner.Then("SellPrice for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal to " +
                    "\"10000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Retrieve Recipe Price from the API (NO Min - Max)")]
        [NUnit.Framework.CategoryAttribute("TC28899")]
        public virtual void RetrieveRecipePriceFromTheAPINOMin_Max()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retrieve Recipe Price from the API (NO Min - Max)", new string[] {
                        "TC28899"});
#line 116
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 117
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
    testRunner.Then("CostPerUnit for recipe named \"004Baked Beans_3\" in meal period \"LUNCH\" is equal t" +
                    "o \"1.68\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculations for \"Total Cost\", \"Sell Price\", \"Revenue\" and \"Actual GP\" should be " +
            "correct")]
        public virtual void CalculationsForTotalCostSellPriceRevenueAndActualGPShouldBeCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculations for \"Total Cost\", \"Sell Price\", \"Revenue\" and \"Actual GP\" should be " +
                    "correct", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 122
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
    testRunner.And("planning for Wednesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "Target",
                        "TaxPercentage",
                        "SellPrice"});
            table2.AddRow(new string[] {
                        "004Bread (fresh dough)",
                        "2",
                        "Fixed",
                        "",
                        "20",
                        "55"});
            table2.AddRow(new string[] {
                        "724Pepper & Garlic Coated Beef",
                        "3",
                        "GP",
                        "5",
                        "5",
                        ""});
#line 124
    testRunner.When("data for recipes in a la carte \"Holiday A La Carte\" in meal period \"LANCE\" is set" +
                    "", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "Target",
                        "TaxPercentage"});
            table3.AddRow(new string[] {
                        "LANCE",
                        "RECIPE",
                        "004Basic Sponge",
                        "4",
                        "TariffOne",
                        "Markup",
                        "15",
                        "0"});
#line 128
    testRunner.And("data for items is set", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "CostPerUnit",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table4.AddRow(new string[] {
                        "004Bread (fresh dough)",
                        "0.04",
                        "0.08",
                        "",
                        "91.67",
                        "100%"});
            table4.AddRow(new string[] {
                        "724Pepper & Garlic Coated Beef",
                        "2180.61",
                        "6541.83",
                        "2410.15",
                        "6886.14",
                        "5%"});
#line 131
    testRunner.Then("Verify data for recipes in a la carte \"Holiday A La Carte\" in meal period \"LANCE\"" +
                    " is", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "TotalCosts",
                        "SellPrice",
                        "Revenue",
                        "ActualGP"});
            table5.AddRow(new string[] {
                        "LANCE",
                        "RECIPE",
                        "004Basic Sponge",
                        "2.12",
                        "0.61",
                        "2.44",
                        "13%"});
#line 135
    testRunner.And("Verify data for items is", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
