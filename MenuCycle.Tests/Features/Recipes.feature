Feature: Recipes
    Recipes feature

@TC28829 @Smoke
Scenario Outline: Retrieve recipe information from the API
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |PlannedQuantity  |CostPerUnit  |TariffType  |PriceModel  |Target  |TaxPercentage  |SellPrice  |
        |DANGELO       |RECIPE|<recipeName>|<plannedQuantity>|<costPerUnit>|<tariffType>|<priceModel>|<target>|<taxPercentage>|<sellPrice>|
        
    @QAI
    Examples:
    |environment|menuCycle|day     |mealPeriod|type  |recipeName                                  |plannedQuantity|costPerUnit|tariffType|priceModel|target|taxPercentage|sellPrice|
    |QAI        |Meda     |Thursday|DANGELO   |RECIPE|703Coronation Chicken Sandwich Filling (50g)|             12|       0.80| TariffOne|        GP|  5.00|           20|     1.01|
    
                                                    
    
@TC28830
Scenario Outline: "Target %" field is not present and "Sell Price" can be edited if "Price model" = "Fixed"
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
    Then Verify Target % field for recipe "<recipeName>" in meal period "<mealPeriod>" is not present
        And Verify Sell Price for recipe "<recipeName>" in meal period "<mealPeriod>" is an editable field
        
        
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
# Not implemented
# @TC29033 
# Scenario Outline: Target GP % has format: float and type: 2 decimals
#     Given Menu Cycle app is open on "<environment>" 
#         And a central user is selected
#         And Menu Cycle "<menuCycle>" is selected
#     When planning for "<day>" is opened
#         And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "GP"
#         And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2.333333"
#         And the user focus out
#     Then Verify TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to "2.33"
    
#     @QAI
#     Examples:
#     |environment|menuCycle|day   |recipeName      |mealPeriod|
#     |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
# Not implemented
# @TC29034   
# Scenario Outline: Target Mark up % has format: float and type: 2 decimals
    # Given Menu Cycle app is open on "<environment>" 
    #     And a central user is selected
    #     And Menu Cycle "<menuCycle>" is selected
    # When planning for "<day>" is opened
    #     And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Markup"
    #     And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2.333333"
    #     And the user focus out
    # Then Verify TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to "2.33"
    
    # @QAI
    # Examples:
    # |environment|menuCycle|day   |recipeName      |mealPeriod|
    # |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29035
Scenario Outline: Target GP % validations
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "GP"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "-100"
        And the user focus out
        And Verify red border and contextual error message "Must be -99.99 to 99.99" is displayed for TargetGP field for recipe "<recipeName>" in meal period "LUNCH"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "1"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to ""
        And the user focus out
        And Verify red border and contextual error message "Value is required" is displayed for TargetGP field for recipe "<recipeName>" in meal period "LUNCH"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "7a7"
        And the user focus out
        And Verify red border and contextual error message "Must be number" is displayed for TargetGP field for recipe "<recipeName>" in meal period "LUNCH"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "-99.99"
        And the user focus out
        And Verify red border is not displayed around Target% for recipe "004Baked Beans_3" in meal period "<mealPeriod>"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "99.99"
        And the user focus out
    Then Verify red border is not displayed around Target% for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29036
Scenario Outline: Target Markup % validations
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Markup"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "5"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to ""
        And the user focus out
        And Verify red border and contextual error message "Value is required" is displayed for TargetGP field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "-1"
        And the user focus out
        And Verify red border and contextual error message "Must be 0 or greater" is displayed for TargetGP field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "7a7"
        And the user focus out
        And Verify red border and contextual error message "Must be number" is displayed for TargetGP field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "0"
        And the user focus out
        And Verify red border is not displayed around Target% for recipe "<recipeName>" in meal period "<mealPeriod>"
        And TargetGP% for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2134"
        And the user focus out
    Then Verify red border is not displayed around Target% for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29039
Scenario Outline: Sell price validations
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "5"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to ""
        And the user focus out
        And Verify red border and contextual error message "Value is required" is displayed for Sell Price field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "-1"
        And the user focus out
        And Verify red border and contextual error message "Must be 0 or greater" is displayed for Sell Price field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "7a7"
        And the user focus out
        And Verify red border and contextual error message "Must be number" is displayed for Sell Price field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "0"
        And the user focus out
        And Verify red border is not displayed around Sell Price for recipe "<recipeName>" in meal period "<mealPeriod>"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "4322"
        And the user focus out
    Then Verify red border is not displayed around Sell Price for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC28899
Scenario Outline: Retrieve Recipe Price from the API (NO Min - Max)
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify CostPerUnit for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to "1.92"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |

@TC27705 @TC27721 @TC27724 @TC27726
Scenario Outline: Calculations for "Total Cost", "Sell Price", "Revenue" and "Actual GP" should be correct
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is set
        |RecipeTitle                   |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |724Beef Bolognaise            |              2|     Fixed|     ^|           20|       55|
        |724Pepper & Garlic Coated Beef|              3|        GP|     5|            5|        ^|
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle     |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |LANCE         |RECIPE|004Baked Beans_0|              4| TariffOne|    Markup|    15|            0|
    Then Verify data for recipes in a la carte "Holiday A La Carte" in meal period "LANCE" is
        |RecipeTitle                   |CostPerUnit|TotalCosts|SellPrice| Revenue|ActualGP|
        |724Beef Bolognaise            |       1.91|      3.82|        ^|   91.67|     96%|
        |724Pepper & Garlic Coated Beef|    5231.88|  15695.63|  5782.60|16521.72|      5%|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |TotalCosts|SellPrice|Revenue|ActualGP|
        |LANCE         |RECIPE|004Baked Beans_0|    125.33|    36.03| 144.12|     13%|
        
    @QAI
    Examples:
    |environment|menuCycle|day      |
    |QAI        |Meda     |WEDNESDAY|
        
@TC29101 @D23785
Scenario Outline: Planned Quantity validations
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "5"
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to ""
        And the user focus out
        And Verify red border and contextual error message "Value is required" is displayed for Planned Quantity field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "-1"
        And the user focus out
        And Verify red border and contextual error message "Must be 0 or greater" is displayed for Planned Quantity field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "7a7"
        And the user focus out
        And Verify red border and contextual error message "Must be integer" is displayed for Planned Quantity field for recipe "<recipeName>" in meal period "<mealPeriod>"
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "0"
        And the user focus out
    Then Verify red border is not displayed around Planned Quantity for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29394 @D23825
Scenario Outline: Transferring Sell Price value to Markup and GP Target% field does not happen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|Target|SellPrice|
        |<mealPeriod>  |<recipeName>|        GP|      |        ^|
        |<mealPeriod>  |<recipeName>|    Markup|      |        ^|
        |<mealPeriod>  |<recipeName>|     Fixed|     ^|       50|
        |<mealPeriod>  |<recipeName>|        GP|     ^|        ^|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |Target|
        |<mealPeriod>  |RECIPE|<recipeName>|  0.00|
    And data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|
        |<mealPeriod>  |<recipeName>|    Markup|
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |Target|
        |<mealPeriod>  |RECIPE|<recipeName>|  0.00|
        
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |

@TC29395 @D23825
Scenario Outline: Transferring Markup Target% value to Sell Price and GP target field does not happen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|Target|SellPrice|
        |<mealPeriod>  |<recipeName>|        GP|      |        ^|
        |<mealPeriod>  |<recipeName>|     Fixed|     ^|         |
        |<mealPeriod>  |<recipeName>|    Markup|    50|        ^|
        |<mealPeriod>  |<recipeName>|        GP|     ^|        ^|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |Target|
        |<mealPeriod>  |RECIPE|<recipeName>|  0.00|
    And data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|
        |<mealPeriod>  |<recipeName>|     Fixed|
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |SellPrice|
        |<mealPeriod>  |RECIPE|<recipeName>|     0.00|
        
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
        
@TC29469 @D23825
Scenario Outline: Transferring GP Target% value to Sell Price and Markup target field does not happen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|Target|SellPrice|
        |<mealPeriod>  |<recipeName>|     Fixed|     ^|         |
        |<mealPeriod>  |<recipeName>|    Markup|      |        ^|
        |<mealPeriod>  |<recipeName>|        GP|    50|        ^|
        |<mealPeriod>  |<recipeName>|    Markup|     ^|        ^|
    And Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |Target|
        |<mealPeriod>  |RECIPE|<recipeName>|  0.00|
    And data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|
        |<mealPeriod>  |<recipeName>|     Fixed|
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |SellPrice|
        |<mealPeriod>  |RECIPE|<recipeName>|     0.00|
        
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |

@TC29468 @D23967 @D24183 @D23194
Scenario Outline: Error message displayed if recipe values are empty
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to ""
        And Verify red border is displayed around Planned Quantity for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Save button is clicked
    Then Verify notification message "Sorry, we could not proceed with your request" is displayed
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29716 @D24183
Scenario Outline: Collapsing meal period does no return previous value
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |PlannedQuantity|
        |<mealPeriod>  |<recipeName>|               |
        And Meal Period "<mealPeriod>" is collapsed
        And Meal Period "<mealPeriod>" is expanded
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |PlannedQuantity|
        |<mealPeriod>  |RECIPE|<recipeName>|               |
        
    @QAI
    Examples:
    |environment|menuCycle|day     |recipeName                 |mealPeriod|
    |QAI        |Meda     |Thursday|703Reggae Raggae Mayonnaise|DANGELO   |
        
        
@TC29735 @D24183
Scenario Outline: Meal period totals are re-calculated when the data from the input field is cleared
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle  |PriceModel|Target|SellPrice|TaxPercentage|PlannedQuantity|
        |<mealPeriod>  |<recipeName1>|GP        |    10|        ^|20           |              3|
        |<mealPeriod>  |<recipeName2>|Fixed     |     ^|        2|20           |              4|
        |<mealPeriod>  |<recipeName1>|^         |     ^|        ^|^            |               |
    Then Verify value for fields for meal period "<mealPeriod>" is
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |         4|     4.00|   6.67|     40%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day     |recipeName1                                 |recipeName2                |
    |QAI        |Meda     |DANGELO   |Thursday|703Coronation Chicken Sandwich Filling (50g)|703Reggae Raggae Mayonnaise|
        
@TC29853
Scenario Outline: Mass recipe update
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day1>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|ForTariffType|SellPrice|
        |<mealPeriod1> |<recipeName>|Fixed     |TariffOne    |     0#99|
    And "SellPrice" is saved in context for recipe "<recipeName>" in meal period "<mealPeriod1>"
        And Save button is clicked
        And Update prices button is clicked for recipe "<recipeName>" in meal period "<mealPeriod1>"
    And Verify Future recipe instances count is 2
        And Confirm is selected on the Update Prices dialog
        And Cancel button is clicked
        And planning for "<day2>" is opened
    Then Verify "SellPrice" is equal to the value saved in context for recipe "<recipeName>" in meal period "<mealPeriod2>"
    
    @QAI
    Examples:
    |environment|menuCycle|recipeName      |day1     |mealPeriod1|day2  |mealPeriod2|
    |QAI        |Meda     |004Baked Beans_3|MONDAY   |LUNCH      |FRIDAY|DANGELO    |
    
@TC29933 @D24491
Scenario Outline: Tariff types are discarded when cancel button is clicked
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
    And Cancel button is clicked
        And Confirm is selected on unsaved changes dialog
        And Wait for Calendar view
        And planning for "<day>" is opened
    Then Verify existing types for recipe "<recipeName>" in meal period "<mealPeriod>" are
        |TariffType|
        |TariffOne |
        
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |

@TC29942 @D24490
Scenario Outline: Delete icon appears when adding type
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |ForTariffType|TariffType|
        |<mealPeriod>  |<recipeName>|    TariffOne|TariffTwo |
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
    Then Verify delete icon is present for recipe "<recipeName>" in meal period "<mealPeriod>" tariff type "TariffOne"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29950 @D24575
Scenario Outline: Opening planning screen multiple times does not add data to unsaved items
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Meal Period "<mealPeriod>" is expanded
        And types are saved in context for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Cancel button is clicked
        And planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    Then Verify existing types are same as from the context for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day    |recipeName                      |mealPeriod|
    |QAI        |Meda     |TUESDAY|703Houmus Sandwich Filling (50g)|DINNER    |
    
@TC29954 @D24588 @Smoke @critical
Scenario Outline: Saving decimal values
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |SellPrice|
        |<mealPeriod>  |<recipeName>|     0#99|
        And Save button is clicked
        And "SellPrice" is saved in context for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Cancel button is clicked
        And planning for "<day>" is opened
    Then Verify "SellPrice" is equal to the value saved in context for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
    
@TC29987
Scenario Outline: Confirm dialog is not shown after save with added TariffTypes
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And "Planned Qty" for recipe with name "<recipeName>" with TariffType "TariffTwo" in meal period "<mealPeriod>" is set to "32"
        And "Sell Price" for recipe with name "<recipeName>" with TariffType "TariffTwo" in meal period "<mealPeriod>" is set to "32"
        And Save button is clicked
        And Verify notification message "Planning figures updated." is displayed
        And Cancel button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
        And planning for "<day>" is opened
        And Verify delete icon is clicked for recipe "<recipeName>" in meal period "<mealPeriod>" with tariff type "TariffTwo"
        And Save button is clicked
        And Verify notification message "Planning figures updated." is displayed
        
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |
        
@TC30090
Scenario Outline: Saving Planning screen with empty fields displays red border and contextual message
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for recipes is set
        |MealPeriodName|RecipeTitle |SellPrice   |PlannedQuantity|
        |<mealPeriod>  |<recipeName>|invalidinput|               |
    And Save button is clicked
    Then Verify red border and contextual error message "Value is required" is displayed for Planned Quantity field for recipe "<recipeName>" in meal period "<mealPeriod>"
    And Verify red border and contextual error message "Must be number" is displayed for Sell Price field for recipe "<recipeName>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle|day   |recipeName      |mealPeriod|
    |QAI        |Meda     |MONDAY|004Baked Beans_3|LUNCH     |