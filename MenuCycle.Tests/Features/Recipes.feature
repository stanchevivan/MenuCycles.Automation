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
        |MealPeriodName   |Type  |RecipeTitle|PlannedQuantity|CostPerUnit|TotalCosts|TariffType|PriceModel|Target|TaxPercentage|SellPrice|Revenue|ActualGP|
        |DANGELO          |RECIPE|Cheese     |              2|      20.27|     40.54| TariffTwo|    Markup|    12|           20|    27.24|   45.4|     11%|

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

@TC29035
Scenario: Min selected Target GP % is -99.99
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-100"
        And the user focus out
    And red border is displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-99.99"
        And the user focus out
    Then red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29036
Scenario: Min selected Target Markup % is 0
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
    And red border is displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
        And the user focus out
    Then red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29037
Scenario: Max selected Target GP % is 99.99
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "100"
        And the user focus out
    And red border is displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "99.99"
        And the user focus out
    Then red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29038
Scenario: Max selected Target Markup % is 100
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "200"
        And the user focus out
    And red border is displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "100"
        And the user focus out
    Then red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29039
Scenario: Min selected Sell Price is 0 - Price model = "Fixed"
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
    And red border is displayed around Sell Price for recipe "004Baked Beans_3" in meal period "LUNCH"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
        And the user focus out
    Then red border is not displayed around Sell Price for recipe "004Baked Beans_3" in meal period "LUNCH"

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

@TC27705 @TC27721 @TC27724 @TC27726
Scenario: Calculations for "Total Cost", "Sell Price", "Revenue" and "Actual GP" should be correct
    Given Menu Cycle "Meda" is selected
    And planning for Wednesday is opened
    When data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is set
        |RecipeTitle                   |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |004Bread (fresh dough)        |              2|     Fixed|      |           20|       55|
        |724Pepper & Garlic Coated Beef|              3|        GP|     5|            5|         |
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle    |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |LANCE         |RECIPE|004Basic Sponge|              4| TariffOne|    Markup|    15|            0|
    Then Verify data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is
        |RecipeTitle                   |CostPerUnit|TotalCosts|SellPrice|Revenue|ActualGP|
        |004Bread (fresh dough)        |       0.04|      0.08|         |  91.67|    100%|
        |724Pepper & Garlic Coated Beef|    2180.61|   6541.83|  2410.15|6886.14|      5%|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle    |TotalCosts|SellPrice|Revenue|ActualGP|
        |LANCE         |RECIPE|004Basic Sponge|      2.12|     0.61|   2.44|     13%|

@TC29101 @D23785
Scenario: Min selected Planned Quantity is 0
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
    And red border is displayed around Planned Quantity for recipe "004Baked Beans_3" in meal period "LUNCH"
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
        And the user focus out
    Then red border is not displayed around Planned Quantity for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29394 @D23825 @ignore
Scenario: Sell Price value is not transferred to Markup and GP Target% field
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
    When SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "50"
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And field "Target" for single recipe "004Baked Beans_3" in meal period "LUNCH" is empty
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
    Then field "Target" for single recipe "004Baked Beans_3" in meal period "LUNCH" is empty

@TC29395 @D23825 @ignore
Scenario: Markup Target% value is not transferred to Sell Price and GP target field
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
    When TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "50"
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And field "Sell Price" for single recipe "004Baked Beans_3" in meal period "LUNCH" is empty
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
    Then field "Target" for single recipe "004Baked Beans_3" in meal period "LUNCH" is empty

@TC29469 @D23825 @ignore
Scenario: GP Target% value is not transferred to Sell Price and Markup target field
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
    When TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "50"
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And field "Sell Price" for single recipe "004Baked Beans_3" in meal period "LUNCH" is empty
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
    Then field "Target" for single recipe "004Baked Beans_3" in meal period "LUNCH" is empty

@TC29468 @D23967
Scenario: Error message displayed if recipe values are empty
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to ""
        And red border is displayed around Planned Quantity for recipe "004Baked Beans_3" in meal period "LUNCH"
        And Save button is clicked
    Then Notification message "Sorry, we could not proceed with your request" is displayed
