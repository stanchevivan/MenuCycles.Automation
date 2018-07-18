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
    [NUnit.Framework.DescriptionAttribute("MealPeriods")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    [NUnit.Framework.CategoryAttribute("#@menucycle")]
    [NUnit.Framework.CategoryAttribute("mealperiod")]
    [NUnit.Framework.CategoryAttribute("recipe")]
    public partial class MealPeriodsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MealPeriods.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MealPeriods", "\tMeal Periods functionalities and validations", ProgrammingLanguage.CSharp, new string[] {
                        "QAI",
                        "#@menucycle",
                        "mealperiod",
                        "recipe"});
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
        [NUnit.Framework.DescriptionAttribute("Open daily planning with one meal period")]
        [NUnit.Framework.CategoryAttribute("TC28547")]
        public virtual void OpenDailyPlanningWithOneMealPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open daily planning with one meal period", new string[] {
                        "TC28547"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 15
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
    testRunner.Then("main data for Meal Period \"Lunch\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open daily planning with multiple meal period")]
        [NUnit.Framework.CategoryAttribute("TC27663")]
        public virtual void OpenDailyPlanningWithMultipleMealPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open daily planning with multiple meal period", new string[] {
                        "TC27663"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 21
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
    testRunner.Then("main data for Meal Period \"Dinner\" is collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Display correct meal period name")]
        [NUnit.Framework.CategoryAttribute("TC28566")]
        public virtual void DisplayCorrectMealPeriodName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display correct meal period name", new string[] {
                        "TC28566"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 27
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
    testRunner.Then("the planning screen for Tuesday is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Collapse single meal period")]
        [NUnit.Framework.CategoryAttribute("TC28549")]
        public virtual void CollapseSingleMealPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Collapse single meal period", new string[] {
                        "TC28549"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 33
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
    testRunner.When("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
        testRunner.And("Meal Period \"Lunch\" is collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.Then("main data for Meal Period \"Lunch\" is collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Expand single meal period")]
        [NUnit.Framework.CategoryAttribute("TC28548")]
        public virtual void ExpandSingleMealPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expand single meal period", new string[] {
                        "TC28548"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 40
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
        testRunner.And("Meal Period \"Lunch\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
    testRunner.Then("main data for Meal Period \"Lunch\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The colour of every meal period in the Planning screen is the same as in the cale" +
            "ndar page")]
        [NUnit.Framework.CategoryAttribute("TC28546")]
        public virtual void TheColourOfEveryMealPeriodInThePlanningScreenIsTheSameAsInTheCalendarPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The colour of every meal period in the Planning screen is the same as in the cale" +
                    "ndar page", new string[] {
                        "TC28546"});
#line 46
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 47
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
        testRunner.And("Meal Period colours for \"Tuesday\" are saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
    testRunner.Then("Meal Period colours match the calendar view colours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Display recipes, added to a meal period in the planning screen")]
        [NUnit.Framework.CategoryAttribute("TC28800")]
        public virtual void DisplayRecipesAddedToAMealPeriodInThePlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display recipes, added to a meal period in the planning screen", new string[] {
                        "TC28800"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 54
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
        testRunner.And("Meal Period \"LUNCH\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
    testRunner.Then("recipe named \"724Gourmet Beef Burger 6oz\" is present for meal period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
        testRunner.And("recipe colour for \"724Gourmet Beef Burger 6oz\" match the colour for meal period \"" +
                    "LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Display Buffet menus, added to a meal period in the planning screen")]
        [NUnit.Framework.CategoryAttribute("TC28801")]
        public virtual void DisplayBuffetMenusAddedToAMealPeriodInThePlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display Buffet menus, added to a meal period in the planning screen", new string[] {
                        "TC28801"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 62
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
        testRunner.And("Meal Period \"DANGELO\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
    testRunner.Then("buffet named \"Aneliya Buffet\" is present for meal period \"DANGELO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
        testRunner.And("buffet colour for \"Aneliya Buffet\" match the colour for meal period \"DANGELO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And("in meal period \"DANGELO\" all recipe colours inside \"Aneliya Buffet\" match the buf" +
                    "fet colour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Display A la carte menus, added to a meal period in the planning screen")]
        [NUnit.Framework.CategoryAttribute("TC28802")]
        public virtual void DisplayALaCarteMenusAddedToAMealPeriodInThePlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display A la carte menus, added to a meal period in the planning screen", new string[] {
                        "TC28802"});
#line 70
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 71
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
    testRunner.When("planning for Wednesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
    testRunner.Then("a la carte named \"Holiday A La Carte\" is present for meal period \"LANCE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
        testRunner.And("a la carte colour for \"Holiday A La Carte\" match the colour for meal period \"LANC" +
                    "E\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("in meal period \"LANCE\" all recipe colours inside \"Holiday A La Carte\" match the A" +
                    " La Carte colour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Retrieve Number of covers for meal period from the API")]
        [NUnit.Framework.CategoryAttribute("TC28897")]
        public virtual void RetrieveNumberOfCoversForMealPeriodFromTheAPI()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retrieve Number of covers for meal period from the API", new string[] {
                        "TC28897"});
#line 78
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 79
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
    testRunner.When("planning for Thursday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
    testRunner.Then("number of covers for meal period \"DANGELO\" is equal to \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open all meal periods in Planning screen")]
        [NUnit.Framework.CategoryAttribute("TC27660")]
        [NUnit.Framework.CategoryAttribute("TC27662")]
        public virtual void OpenAllMealPeriodsInPlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open all meal periods in Planning screen", new string[] {
                        "TC27660",
                        "TC27662"});
#line 84
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 85
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
        testRunner.And("Open all is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
    testRunner.And("all meal periods are expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
        testRunner.And("Close all is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
    testRunner.Then("all meal periods are collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipes onlyCalculate Meal period \"Planned Quantity\", \"Total Cost\", \"Revenue\" and" +
            " \"ActualGP\"")]
        [NUnit.Framework.CategoryAttribute("TC29384")]
        public virtual void RecipesOnlyCalculateMealPeriodPlannedQuantityTotalCostRevenueAndActualGP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipes onlyCalculate Meal period \"Planned Quantity\", \"Total Cost\", \"Revenue\" and" +
                    " \"ActualGP\"", new string[] {
                        "TC29384"});
#line 93
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 94
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
    testRunner.When("planning for Thursday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "Target",
                        "TaxPercentage",
                        "SellPrice"});
            table1.AddRow(new string[] {
                        "DANGELO",
                        "RECIPE",
                        "703Coronation Chicken Sandwich Filling (50g)",
                        "10",
                        "GP",
                        "14",
                        "20",
                        "^"});
            table1.AddRow(new string[] {
                        "DANGELO",
                        "RECIPE",
                        "703Reggae Raggae Mayonnaise",
                        "10",
                        "Fixed",
                        "^",
                        "20",
                        "1"});
            table1.AddRow(new string[] {
                        "DANGELO",
                        "RECIPE",
                        "Cheese",
                        "10",
                        "Markup",
                        "12",
                        "20",
                        "^"});
#line 96
    testRunner.And("data for recipes is set", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PlannedQty",
                        "TotalCost",
                        "Revenue",
                        "ActualGP"});
            table2.AddRow(new string[] {
                        "30",
                        "218.50",
                        "243.50",
                        "10%"});
#line 101
    testRunner.Then("Value for fields for meal period \"DANGELO\" is", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Buffets only - Calculate Meal period \"Planned Quantity\", \"Total Cost\", \"Revenue\" " +
            "and \"ActualGP\"")]
        [NUnit.Framework.CategoryAttribute("TC29387")]
        public virtual void BuffetsOnly_CalculateMealPeriodPlannedQuantityTotalCostRevenueAndActualGP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buffets only - Calculate Meal period \"Planned Quantity\", \"Total Cost\", \"Revenue\" " +
                    "and \"ActualGP\"", new string[] {
                        "TC29387"});
#line 106
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 107
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 108
    testRunner.When("planning for Friday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "TaxPercentage",
                        "SellPrice"});
            table3.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Maya Buffet",
                        "10",
                        "TariffOne",
                        "Fixed",
                        "20",
                        "23"});
#line 109
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
#line 112
    testRunner.And("data for recipes in buffet \"Maya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "PlannedQty",
                        "TotalCost",
                        "Revenue",
                        "ActualGP"});
            table5.AddRow(new string[] {
                        "60",
                        "108.3",
                        "191.67",
                        "43%"});
#line 117
    testRunner.Then("Value for fields for meal period \"DANGELO\" is", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A la cares only - Calculate Meal period \"Planned Quantity\", \"Total Cost\", \"Revenu" +
            "e\" and \"ActualGP\"")]
        [NUnit.Framework.CategoryAttribute("TC29388")]
        public virtual void ALaCaresOnly_CalculateMealPeriodPlannedQuantityTotalCostRevenueAndActualGP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A la cares only - Calculate Meal period \"Planned Quantity\", \"Total Cost\", \"Revenu" +
                    "e\" and \"ActualGP\"", new string[] {
                        "TC29388"});
#line 122
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 123
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
    testRunner.When("planning for Friday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "Target",
                        "TaxPercentage",
                        "SellPrice"});
            table6.AddRow(new string[] {
                        "004Bread (fresh dough)",
                        "2",
                        "GP",
                        "11",
                        "20",
                        "^"});
            table6.AddRow(new string[] {
                        "724Pepper & Garlic Coated Beef",
                        "3",
                        "Fixed",
                        "^",
                        "20",
                        "55"});
#line 125
    testRunner.And("data for recipes in a la carte \"Holiday A La Carte\" in meal period \"DANGELO\" is s" +
                    "et", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "PlannedQty",
                        "TotalCost",
                        "Revenue",
                        "ActualGP"});
            table7.AddRow(new string[] {
                        "5",
                        "6541.91",
                        "137.59",
                        "-4655%"});
#line 129
    testRunner.Then("Value for fields for meal period \"DANGELO\" is", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Combined for Buffet, A la cares and recipes - Calculate Meal period \"Planned Quan" +
            "tity\", \"Total Cost\", \"Revenue\" and \"ActualGP\"")]
        [NUnit.Framework.CategoryAttribute("TC29391")]
        public virtual void CombinedForBuffetALaCaresAndRecipes_CalculateMealPeriodPlannedQuantityTotalCostRevenueAndActualGP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Combined for Buffet, A la cares and recipes - Calculate Meal period \"Planned Quan" +
                    "tity\", \"Total Cost\", \"Revenue\" and \"ActualGP\"", new string[] {
                        "TC29391"});
#line 134
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 135
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 136
    testRunner.When("planning for Friday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "Target",
                        "TaxPercentage",
                        "SellPrice"});
            table8.AddRow(new string[] {
                        "004Bread (fresh dough)",
                        "2",
                        "GP",
                        "11",
                        "20",
                        "^"});
            table8.AddRow(new string[] {
                        "724Pepper & Garlic Coated Beef",
                        "3",
                        "Fixed",
                        "^",
                        "20",
                        "55"});
#line 137
    testRunner.And("data for recipes in a la carte \"Holiday A La Carte\" in meal period \"DANGELO\" is s" +
                    "et", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "TariffType",
                        "PriceModel",
                        "TaxPercentage",
                        "SellPrice"});
            table9.AddRow(new string[] {
                        "DANGELO",
                        "BUFFET",
                        "Maya Buffet",
                        "10",
                        "TariffOne",
                        "Fixed",
                        "20",
                        "23"});
#line 141
    testRunner.And("data for buffets is set", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "RecipeTitle",
                        "PlannedQuantity"});
            table10.AddRow(new string[] {
                        "004Fish Stock (bouillon)",
                        "10"});
            table10.AddRow(new string[] {
                        "004Basic Sponge",
                        "20"});
            table10.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "30"});
#line 144
    testRunner.And("data for recipes in buffet \"Maya Buffet\" in meal period \"DANGELO\" is set", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "PlannedQuantity",
                        "PriceModel",
                        "Target",
                        "TaxPercentage",
                        "SellPrice"});
            table11.AddRow(new string[] {
                        "DANGELO",
                        "RECIPE",
                        "004Bechamel Sauce",
                        "10",
                        "GP",
                        "14",
                        "20",
                        "^"});
            table11.AddRow(new string[] {
                        "DANGELO",
                        "RECIPE",
                        "004Baked Beans_3",
                        "10",
                        "Fixed",
                        "^",
                        "20",
                        "1"});
#line 149
    testRunner.And("data for recipes is set", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "PlannedQty",
                        "TotalCost",
                        "Revenue",
                        "ActualGP"});
            table12.AddRow(new string[] {
                        "85",
                        "6668.41",
                        "339.22",
                        "-1866%"});
#line 153
    testRunner.Then("Value for fields for meal period \"DANGELO\" is", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Meal periods are collapsed after reopening planning screen")]
        [NUnit.Framework.CategoryAttribute("TC29560")]
        public virtual void MealPeriodsAreCollapsedAfterReopeningPlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Meal periods are collapsed after reopening planning screen", new string[] {
                        "TC29560"});
#line 158
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 159
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 160
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
        testRunner.And("Open all is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
    testRunner.And("all meal periods are expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 163
        testRunner.And("Cancel button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
        testRunner.And("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
    testRunner.Then("all meal periods are collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("More than one hundred recipies are shown in a meal period")]
        [NUnit.Framework.CategoryAttribute("TC30011")]
        public virtual void MoreThanOneHundredRecipiesAreShownInAMealPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("More than one hundred recipies are shown in a meal period", new string[] {
                        "TC30011"});
#line 168
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 169
    testRunner.Given("Menu Cycle \"Testing Copying Meal Periods\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 170
    testRunner.When("planning for Wednesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 171
    testRunner.Then("\"132\" recipies are present in meal period \"LUNCH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The order of meal periods from the planning screen is the same as in the calendar" +
            " view")]
        [NUnit.Framework.CategoryAttribute("TC30087")]
        [NUnit.Framework.CategoryAttribute("D24839")]
        public virtual void TheOrderOfMealPeriodsFromThePlanningScreenIsTheSameAsInTheCalendarView()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The order of meal periods from the planning screen is the same as in the calendar" +
                    " view", new string[] {
                        "TC30087",
                        "D24839"});
#line 174
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 175
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 176
        testRunner.And("Meal Period names for \"Tuesday\" are saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
    testRunner.When("planning for Tuesday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 178
    testRunner.Then("Meal Period names match the calendar view names", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Menu Cycles by name or description")]
        [NUnit.Framework.CategoryAttribute("TC27713")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void SearchMenuCyclesByNameOrDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Menu Cycles by name or description", new string[] {
                        "TC27713",
                        "Smoke"});
#line 181
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 182
    testRunner.When("Menu Cycle \"FOR AUTOMATION TESTS - DO NOT TOUCH\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table13.AddRow(new string[] {
                        "Meda",
                        "FOR AUTOMATION TESTS - DO NOT TOUCH"});
#line 183
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table13, "And ");
#line 186
    testRunner.When("Menu Cycle \"MC with recipes\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table14.AddRow(new string[] {
                        "MC with recipes",
                        "Testing the publishing of a MC with recipes"});
#line 187
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
