#@menucycle @mealperiod @recipe
Feature: Recipes
    Recipes feature

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC28829 @Smoke
Scenario: Retrieve recipe information from the API
    Given Menu Cycle "Meda" is selected
    When planning for Thursday is opened
    Then verify the following recipes:
    |MealPeriodName   |Type  |RecipeTitle       |PlannedQuantity|CostPerUnit|TotalCosts|TariffType|PriceModel|Target|TaxPercentage|SellPrice|Revenue|ActualGP|
    |DANGELO          |RECIPE|Cheese            |              2|      20.27|     40.54| TariffTwo|    Markup|    12|           20|    27.24|   45.4|     11%|

@TC28830
Scenario: "Target %" field is not present and "Sell Price" can be edited if "Price model" = "Fixed"
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
    Then Target % field for recipe "004Baked Beans_3" in meal period "LUNCH" is not present
        And Sell Price for recipe "004Baked Beans_3" in meal period "LUNCH" is an editable field

@TC29033 @ignore
Scenario: Target GP % has format: float and type: 2 decimals
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2.333333"
        And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "2.33"

@TC29034 @ignore    
Scenario: Target Mark up % has format: float and type: 2 decimals
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2.333333"
        And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "2.33"

@TC29035 @ignore
Scenario: Min selected Target GP % is -99.99
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-10000"
        And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "-99.99"

@TC29036 @ignore
Scenario: Min selected Target Markup % is -99.99
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "0"

@TC29037 @ignore
Scenario: Max selected Target GP % is 99.99
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "1000"
        And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "99.99"

@TC29038 @ignore
Scenario: Max selected Target Markup % is 100
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "200"
        And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "100"

@TC29039 @ignore
Scenario: Min selected Sell Price is 0 - Price model = "Fixed"
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
    Then SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "0"

@TC29040
Scenario: No max value for "Sell Price" - Price model = "Fixed"
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "10000"
        And the user focus out
    Then SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "10000"

@TC28899
Scenario: Retrieve Recipe Price from the API (NO Min - Max)
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    Then CostPerUnit for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to "1.68"

Scenario: Calculations for "Total Cost", "Sell Price", "Revenue" and "Actual GP" should be correct
    Given Menu Cycle "Meda" is selected
    And planning for Wednesday is opened
    When data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is set
        |RecipeTitle                   |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |004Bread (fresh dough)        |              2|     Fixed|      |           20|       55|
        |724Pepper & Garlic Coated Beef|              3|        GP|     5|            5|         |
    And data for items is set
        |MealPeriodName|TYPE  |RecipeTitle    |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |LANCE         |RECIPE|004Basic Sponge|              4| TariffOne|    Markup|    15|            0|
    Then Verify data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is
        |RecipeTitle                   |CostPerUnit|TotalCosts|SellPrice|Revenue|ActualGP|
        |004Bread (fresh dough)        |       0.04|      0.08|         |  91.67|    100%|
        |724Pepper & Garlic Coated Beef|    2180.61|   6541.83|  2410.15|6886.14|      5%|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle    |TotalCosts|SellPrice|Revenue|ActualGP|
        |LANCE         |RECIPE|004Basic Sponge|      2.12|     0.61|   2.44|     13%|