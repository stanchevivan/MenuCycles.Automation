#@menucycle @mealperiod @recipe
Feature: Recipes
    Recipes feature

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected
#And a nouser user is selected

@TC28829 @Smoke
Scenario: Retrieve recipe information from the API
    Given Menu Cycle "Meda" is selected
    When planning for Thursday is opened
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle|PlannedQuantity|CostPerUnit|TotalCosts|TariffType|PriceModel|Target|TaxPercentage|SellPrice|Revenue|ActualGP|
        |DANGELO       |RECIPE|Cheese     |              2|      20.27|     40.54| TariffTwo|    Markup|    12|           20|    27.24|   45.4|     11%|

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
Scenario: Target GP % validations
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-100"
        And the user focus out
        And red border and contextual error message "Must be -99.99 to 99.99" is displayed for TargetGP field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to ""
        And the user focus out
        And red border and contextual error message "Value is required" is displayed for TargetGP field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "7a7"
        And the user focus out
        And red border and contextual error message "Must be number" is displayed for TargetGP field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-99.99"
        And the user focus out
        And red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "99.99"
        And the user focus out
    Then red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29036
Scenario: Target Markup % validations
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Markup"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
        And red border and contextual error message "Must be 0 or greater" is displayed for TargetGP field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to ""
        And the user focus out
        And red border and contextual error message "Value is required" is displayed for TargetGP field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "7a7"
        And the user focus out
        And red border and contextual error message "Must be number" is displayed for TargetGP field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
        And the user focus out
        And red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"
        And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2134"
        And the user focus out
    Then red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29039
Scenario: Sell price validations
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
        And red border and contextual error message "Must be 0 or greater" is displayed for Sell Price field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to ""
        And the user focus out
        And red border and contextual error message "Value is required" is displayed for Sell Price field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "7a7"
        And the user focus out
        And red border and contextual error message "Must be number" is displayed for Sell Price field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
        And the user focus out
        And red border is not displayed around Sell Price for recipe "004Baked Beans_3" in meal period "LUNCH"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "4322"
        And the user focus out
    Then red border is not displayed around Sell Price for recipe "004Baked Beans_3" in meal period "LUNCH"

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
        |004Bread (fresh dough)        |              2|     Fixed|     ^|           20|       55|
        |724Pepper & Garlic Coated Beef|              3|        GP|     5|            5|        ^|
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle    |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |LANCE         |RECIPE|004Basic Sponge|              4| TariffOne|    Markup|    15|            0|
    Then Verify data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is
        |RecipeTitle                   |CostPerUnit|TotalCosts|SellPrice|Revenue|ActualGP|
        |004Bread (fresh dough)        |       0.04|      0.08|        ^|  91.67|    100%|
        |724Pepper & Garlic Coated Beef|    2180.61|   6541.83|  2410.15|6886.14|      5%|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle    |TotalCosts|SellPrice|Revenue|ActualGP|
        |LANCE         |RECIPE|004Basic Sponge|      2.12|     0.61|   2.44|     13%|

@TC29101 @D23785
Scenario: Planned Quantity validations
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "-1"
        And the user focus out
        And red border and contextual error message "Must be 0 or greater" is displayed for Planned Quantity field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "7a7"
        And the user focus out
        And red border and contextual error message "Must be integer" is displayed for Planned Quantity field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to ""
        And the user focus out
        And red border and contextual error message "Value is required" is displayed for Planned Quantity field for recipe "004Baked Beans_3" in meal period "LUNCH"
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
        And the user focus out
    Then red border is not displayed around Planned Quantity for recipe "004Baked Beans_3" in meal period "LUNCH"

@TC29394 @D23825
Scenario: Transferring Sell Price value to Markup and GP Target% field does not happen
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
    When data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PriceModel|Target|SellPrice|
        |LUNCH         |RECIPE|004Baked Beans_3|        GP|      |        ^|
        |LUNCH         |RECIPE|004Baked Beans_3|    Markup|      |        ^|
        |LUNCH         |RECIPE|004Baked Beans_3|     Fixed|     ^|       50|
        |LUNCH         |RECIPE|004Baked Beans_3|        GP|     ^|        ^|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |Target|
        |LUNCH         |RECIPE|004Baked Beans_3|      |
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PriceModel|
        |LUNCH         |RECIPE|004Baked Beans_3|    Markup|
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |Target|
        |LUNCH         |RECIPE|004Baked Beans_3|      |

@TC29395 @D23825
Scenario: Transferring Markup Target% value to Sell Price and GP target field does not happen
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
    When data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PriceModel|Target|SellPrice|
        |LUNCH         |RECIPE|004Baked Beans_3|        GP|      |        ^|
        |LUNCH         |RECIPE|004Baked Beans_3|     Fixed|     ^|         |
        |LUNCH         |RECIPE|004Baked Beans_3|    Markup|    50|        ^|
        |LUNCH         |RECIPE|004Baked Beans_3|        GP|     ^|        ^|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |Target|
        |LUNCH         |RECIPE|004Baked Beans_3|      |
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PriceModel|
        |LUNCH         |RECIPE|004Baked Beans_3|    Fixed|
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |SellPrice|
        |LUNCH         |RECIPE|004Baked Beans_3|         |

@TC29469 @D23825
Scenario: Transferring GP Target% value to Sell Price and Markup target field does not happen
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
    When data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PriceModel|Target|SellPrice|
        |LUNCH         |RECIPE|004Baked Beans_3|     Fixed|     ^|         |
        |LUNCH         |RECIPE|004Baked Beans_3|    Markup|      |        ^|
        |LUNCH         |RECIPE|004Baked Beans_3|        GP|    50|        ^|
        |LUNCH         |RECIPE|004Baked Beans_3|    Markup|     ^|        ^|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |Target|
        |LUNCH         |RECIPE|004Baked Beans_3|      |
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PriceModel|
        |LUNCH         |RECIPE|004Baked Beans_3|     Fixed|
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |SellPrice|
        |LUNCH         |RECIPE|004Baked Beans_3|         |

@TC29468 @D23967 @D24183 @D23194
Scenario: Error message displayed if recipe values are empty
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to ""
        And red border is displayed around Planned Quantity for recipe "004Baked Beans_3" in meal period "LUNCH"
        And Save button is clicked
    Then Notification message "Sorry, we could not proceed with your request" is displayed

@TC29716 @D24183
Scenario: Collapsing meal period does no return previous value if field
    Given Menu Cycle "Meda" is selected
    When planning for Thursday is opened
        And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle                |PlannedQuantity|
        |DANGELO       |RECIPE|703Reggae Raggae Mayonnaise|               |
        And Meal Period "DANGELO" is collapsed
        And Meal Period "DANGELO" is expanded
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle                |PlannedQuantity|
        |DANGELO       |RECIPE|703Reggae Raggae Mayonnaise|               |

@TC29735 @D24183
Scenario: Meal period totals are re-calculated when the data from the input field is cleared
    Given Menu Cycle "Meda" is selected
    When planning for Thursday is opened
        And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle|TargetGP|PlannedQuantity|
        |DANGELO       |RECIPE|Cheese     |      33|               |
    Then Value for fields for meal period "DANGELO" is
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |        14|    10.16|    8.4|    -21%|

Scenario: Mass recipe update
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
    When SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Save button is clicked
        And Price is updated for recipe "004Baked Beans_3" in meal period "LUNCH"
        And Cancel button is clicked
        And planning for Friday is opened
    Then SellPrice for recipe named "004Baked Beans_3" in meal period "DANGELO" is equal to the previous inputted number

@TC29933 @D24491
Scenario: Tariff types are discarded when cancel button is clicked
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Add type is clicked for recipe "004Baked Beans_3" in meal period "LUNCH"
    When Cancel button is clicked
        And Confirm is selected on unsaved changes dialog
        And planning for Monday is opened
    Then Existing types for recipe "004Baked Beans_3" in meal period "LUNCH" are
        |TariffType|
        |TariffOne|