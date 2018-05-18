#@menucycle @mealperiod @recipe
Feature: Recipes
    Recipes feature

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC28829
Scenario: Retrieve recipe information from the API
    Given Menu Cycle "Meda" is selected
    When planning for Thursday is opened
    Then verify the following recipes:
    |MealPeriodName   |Type  |RecipeTitle       |PlannedQuantity|CostPerUnit|TotalCosts|TariffType|PriceModel|TargetGP|TaxPercentage|SellPrice|Revenue|ActualGP|
    |DANGELO          |RECIPE|Cheese            |              2|      20.27|     40.54| TariffTwo|    Markup|      12|           20|    27.24|   45.4|     11%|

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


