Feature: MealPeriods
	Meal Periods functionalities and validations

@TC28547
Scenario Outline: Open daily planning with one meal period
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify main data for Meal Period "<mealPeriod>" is expanded
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day   |
    |QAI        |Meda     |LUNCH     |MONDAY|

@TC27663
Scenario Outline: Open daily planning with multiple meal period
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify main data for Meal Period "<mealPeriod>" is collapsed
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI        |Meda     |DINNER    |TUESDAY|
    
#TODO: Investigate what this test does
# @TC28566  
# Scenario Outline: Display correct meal period name
    # Given Menu Cycle app is open on "<environment>" 
    #     And a central user is selected
    #     And Menu Cycle "<menuCycle>" is selected
    # When planning for "<day>" is opened
    # Then the planning screen for "<day>" is open
    
    # @QAI
    # Examples:
    # |environment|menuCycle|mealPeriod|day    |
    # |QAI        |Meda     |DINNER    |TUESDAY|

@TC28549
Scenario Outline: Collapse single meal period
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is collapsed
    Then Verify main data for Meal Period "<mealPeriod>" is collapsed
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day   |
    |QAI        |Meda     |LUNCH     |MONDAY|

@TC28548
Scenario Outline: Expand single meal period
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    Then Verify main data for Meal Period "<mealPeriod>" is expanded
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI        |Meda     |LUNCH     |TUESDAY|

@TC28546
Scenario Outline: The colour of every meal period in the Planning screen is the same as in the calendar page
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Meal Period colours for "<day>" are saved
    When planning for "<day>" is opened
    Then Verify Meal Period colours match the calendar view colours
    
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI        |Meda     |TUESDAY|

@TC28800
Scenario Outline: Display recipes, added to a meal period in the planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    Then Verify recipe named "<recipe>" is present for meal period "<mealPeriod>"
        And Verify recipe colour for "<recipe>" match the colour for meal period "<mealPeriod>"
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |recipe                    |
    |QAI        |Meda     |LUNCH     |TUESDAY|724Gourmet Beef Burger 6oz|

@TC28801
Scenario Outline: Display Buffet menus, added to a meal period in the planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    Then Verify buffet named "<buffet>" is present for meal period "<mealPeriod>"
        And Verify buffet colour for "<buffet>" match the colour for meal period "<mealPeriod>"
        And Verify in meal period "<mealPeriod>" all recipe colours inside "<buffet>" match the buffet colour
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |buffet        |
    |QAI        |Meda     |DANGELO   |TUESDAY|Aneliya Buffet|
        
@TC28802
Scenario Outline: Display A la carte menus, added to a meal period in the planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify a la carte named "<aLaCarte>" is present for meal period "<mealPeriod>"
        And Verify a la carte colour for "<aLaCarte>" match the colour for meal period "<mealPeriod>"
        And Verify in meal period "<mealPeriod>" all recipe colours inside "<aLaCarte>" match the A La Carte colour
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day      |aLaCarte          |
    |QAI        |Meda     |LANCE     |Wednesday|Holiday A La Carte|
        
@TC28897
Scenario Outline: Retrieve Number of covers for meal period from the API
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify number of covers for meal period "<mealPeriod>" is equal to "3"
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day     |
    |QAI        |Meda     |DANGELO   |Thursday|

@TC27660 @TC27662
Scenario Outline: Open all meal periods in Planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Expand all is clicked
    And Verify all meal periods are expanded in Daily Planning
        And Collapse all is clicked
    Then Verify all meal periods are collapsed in Daily Planning
    
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI        |Meda     |TUESDAY|

@TC29384
Scenario Outline: Recipes only - Calculate Meal period "Planned Quantity", "Total Cost", "Revenue" and "ActualGP" 
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle                                 |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |DANGELO       |RECIPE|703Coronation Chicken Sandwich Filling (50g)|             10|        GP|    14|            20|       ^|
        |DANGELO       |RECIPE|703Reggae Raggae Mayonnaise                 |             10|     Fixed|     ^|            20|       1|
        |DANGELO       |RECIPE|Cheese                                      |             10|    Markup|    12|            20|       ^|
    Then Verify value for fields for meal period "<mealPeriod>" is
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |        30|     18.2|  17.75|     -3%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day     |
    |QAI        |Meda     |DANGELO   |Thursday|
        
@TC29387
Scenario Outline: Buffets only - Calculate Meal period "Planned Quantity", "Total Cost", "Revenue" and "ActualGP"
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    And data for buffets is set
        |MealPeriodName|TYPE  |RecipeTitle|PlannedQuantity|TariffType|PriceModel|TaxPercentage|SellPrice|
        |DANGELO       |BUFFET|Maya Buffet|             10| TariffOne|     Fixed|           20|       23|
    And data for recipes in buffet "Maya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                           |PlannedQuantity|
        |004Basic Sponge                       |             10|
        |004Fresh Lemon Curd                   |             20|
        |004Fish Stock (bouillon)              |             30|
        |004Beef Stock (bouillon)              |             40|
        |724Custard Sauce (powder, fresh milk) |             50|
        |004German Shortcrust Pastry (fresh)007|             60|
    Then Verify value for fields for meal period "DANGELO" is
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |       210|    391.2| 191.67|   -104%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day   |
    |QAI        |Meda     |DANGELO   |Friday|

@TC29388
Scenario Outline: A la cartes only - Calculate Meal period "Planned Quantity", "Total Cost", "Revenue" and "ActualGP"
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    And data for recipes in a la carte "Holiday A La Carte" in meal period "DANGELO" is set
        |RecipeTitle                   |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |004Bread (fresh dough)        |              2|        GP|    11|           20|        ^|
        |724Pepper & Garlic Coated Beef|              3|     Fixed|     ^|           20|       55|
    Then Verify value for fields for meal period "DANGELO" is
        |PlannedQty|TotalCost  |Revenue|ActualGP|
        |         5|     7136.9| 137.72|  -5082%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day   |
    |QAI        |Meda     |DANGELO   |Friday|
        
@TC29391
Scenario Outline: Combined for Buffet, A la cares and recipes - Calculate Meal period "Planned Quantity", "Total Cost", "Revenue" and "ActualGP"
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    And data for recipes in a la carte "Holiday A La Carte" in meal period "DANGELO" is set
        |RecipeTitle                   |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |004Bread (fresh dough)        |              2|        GP|    11|           20|        ^|
        |724Pepper & Garlic Coated Beef|              3|     Fixed|     ^|           20|       55|
    And data for buffets is set
        |MealPeriodName|TYPE  |RecipeTitle|PlannedQuantity|TariffType|PriceModel|TaxPercentage|SellPrice|
        |DANGELO       |BUFFET|Maya Buffet|             10| TariffOne|     Fixed|           20|       23|
    And data for recipes in buffet "Maya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                           |PlannedQuantity|
        |004Basic Sponge                       |             10|
        |004Fresh Lemon Curd                   |             20|
        |004Fish Stock (bouillon)              |             30|
        |004Beef Stock (bouillon)              |             40|
        |724Custard Sauce (powder, fresh milk) |             50|
        |004German Shortcrust Pastry (fresh)007|             60|
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle      |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |DANGELO       |RECIPE|004Bechamel Sauce|             10|        GP|    14|            20|       ^|
        |DANGELO       |RECIPE|004Baked Beans_3 |             10|     Fixed|     ^|            20|       1|
    Then Verify value for fields for meal period "DANGELO" is
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |       235|     7549| 340.17|  -2119%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day   |
    |QAI        |Meda     |DANGELO   |Friday|

@TC29560
Scenario Outline: Meal periods are collapsed after reopening planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Expand all is clicked
    And Verify all meal periods are expanded in Daily Planning
        And Cancel button is clicked
        And planning for "<day>" is opened
    Then Verify all meal periods are collapsed in Daily Planning
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI        |Meda     |DANGELO   |Tuesday|

@TC30011
Scenario Outline: More than one hundred recipies are shown in a meal period
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify "132" recipies are present in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|menuCycle                   |mealPeriod|day      |
    |QAI        |Testing Copying Meal Periods|LUNCH     |Wednesday|

@TC30087 @D24839
Scenario Outline: The order of meal periods from the planning screen is the same as in the calendar view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Meal Period names for "<day>" are saved
    When planning for "<day>" is opened
    Then Verify Meal Period names match the calendar view names
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI        |Meda     |LUNCH     |Tuesday|
    
@TC31018
Scenario Outline: Expand all meal periods in the Calendar view 
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Calendar view is opened
        And Expand all is clicked
    Then Verify all meal periods are expanded in Daily Calendar
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI        |Meda     |LUNCH     |Tuesday|

@TC31019 @D27173
Scenario Outline: Collapse all meal periods in the Calendar view  
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Calendar view is opened
        And Expand all is clicked
        And Verify all meal periods are expanded in Daily Calendar
        And Collapse all is clicked
    Then Verify all meal periods are collapsed in Daily Calendar
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |

@TC31021
Scenario Outline: All meal periods in Calendar view are collapsed by default
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Calendar view is opened
    Then Verify all meal periods are collapsed in Daily Calendar
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |

@TC31191 @D21720
Scenario Outline: Deleting meal period deletes it from calendar view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Calendar view is opened
        And Meal period "<mealPeriod>" is created for "<day>"
        And Recipe search is opened
        And Buffet "Maya Buffet" is searched
        And Buffet "Maya Buffet" is added
        And Meal period is saved
        And Notification message "Meal Period Saved successfully" is displayed
    When Meal period delete button is clicked
        And Modal dialog Yes is selected
        And Notification message "Meal Period Deleted Successfully." is displayed
    Then Verify Meal period "<mealPeriod>" is not present for "<day>"
    
    @QAI
    Examples:
    |environment|menuCycle           |mealPeriod|day   |
    |QAI        |Automation Testing  |LUNCH     |Monday|

@TC31310 @D21324
Scenario Outline: Clicking on the "NEW MEAL PERIOD" box while selecting a meal period should not disable the "Select meal period" drop-down
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When New meal period button is clicked for "<day>"
        And the header for the new meal period is clicked
        And meal period "<mealPeriod>" is selected in drop-down
    Then Verify drop down for meal period has "<mealPeriod>" selected
    
    @QAI
    Examples:
    |environment|menuCycle           |mealPeriod|day   |
    |QAI        |Automation Testing  |LUNCH     |Monday|