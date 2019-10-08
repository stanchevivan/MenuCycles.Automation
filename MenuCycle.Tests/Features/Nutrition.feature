Feature: Nutrition screen
	
@TC36897
Scenario Outline: Expand all / Collapse all meal periods Nutrition Days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    When Expand all is clicked
    Then Verify all nutrition meal periods are expanded
        And Collapse all is clicked
        And Verify all nutrition meal periods are collapsed
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day    |
    |QAI_2      |false |Meda     |Tuesday|

@TC36898    
Scenario Outline: Expand/Collapse single meal period Nutritions screen days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Nutrition meal period "<mealPeriod>" is collapsed
    Then Verify main data for Meal Period "<mealPeriod>" is collapsed in Nutrition days
    When Nutrition meal period "<mealPeriod>" is expanded
    Then Verify main data for Meal Period "<mealPeriod>" is expanded in Nutrition days
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |mealPeriod|
    |QAI_2      |false |Meda     |Monday|LUNCH     |

@TC36908 
Scenario Outline: Single Meal Period is expanded by default in the Nutrition screen days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify all meal periods are expanded in Nutrition screen days
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |mealPeriod|
    |QAI_2      |false |Meda     |Monday|LUNCH     |
 
@TC36909       
Scenario Outline: Multiple Meal Periods are collapsed by default in the Nutrition screen days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify all meal periods are collapsed in Nutrition screen days
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day    |
    |QAI_2      |false |Meda     |Tuesday|
   
@TC36910         
Scenario Outline: Verify save button is hidden for in the Nutrition screen days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify save button is not present
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI_2      |false |Meda     |Monday|

@TC36912    
Scenario Outline: Calendar view is opened when Cancel is clicked in the Nutrition screen days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And nutrition tab is opened
    When Cancel button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI_2      |false |Meda     |MONDAY|
    
@TC36913
Scenario Outline: Calendar view is opened when Cross is clicked in the Nutrition screen days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And nutrition tab is opened
    When Cross button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI_2      |false |Meda     |MONDAY|
    
# enable test when data is fixed
#@TC36938 @ignore
#Scenario Outline: Retrieve recipe information from the API in Nutrition screen
#    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
#        And a nouser user is selected
#        And Menu Cycle "<menuCycle>" is selected
#    When planning for "<day>" is opened
#        And "PlannedQuantity" is saved in context for recipe "<recipeName>" in meal period "<mealPeriod>"
#        And nutrition tab is opened
#    Then Verify nutrition data for recipes are
#        |MealPeriodName|RecipeTitle |PlannedQuantity  |MixPercent  |EnergyKJ  |EnergyKCAL  |Fat  |SaturatedFat  |Sugar  |Salt  |
#        |<mealPeriod>  |<recipeName>|<plannedQuantity>|<mixPercent>|<energyKJ>|<energyKCAL>|<fat>|<saturatedFat>|<sugar>|<salt>|
#        
#    @QAI
#    Examples:
#    |environment|withFA|menuCycle|day     |mealPeriod|recipeName      |mixPercent|energyKJ|energyKCAL|fat  |saturatedFat|sugar|salt    |
#    |QAI_2      |false |Meda     |Monday  |LUNCH     |004Baked Beans_3|       100|  799.20|      6.00|66.00|       79.20|34.08|15000.00|
    
Scenario Outline: Planned qty are summed for recipe with more than one tariffs
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When sum of planned qty for all tariffs for recipe "<recipeName>" in meal period "<mealPeriod>" are saved in context
        And nutrition tab is opened
    Then Verify Planned Qty for recipe "<recipeName>" in meal period "<mealPeriod>" equals the sum of the tariffs planned qty values
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day     |mealPeriod|recipeName      |tariffOne|tariffTwo|
    |QAI_2      |false |Meda     |Saturday|     LUNCH|004Baked Beans_3|TariffOne|TariffTwo|
    
Scenario Outline: Validate Nutritions Daily Totals
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify daily nutrition totals equals the sum of all meal period totals
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|day    |
    |QAI_2      |false |Meda     |TUESDAY|
    
Scenario Outline: Validate Nutritions Meal Period Totals
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify meal period "<mealPeriod>" nutrition total equals the sum of all recipes nutrition values
        
    @QAI
    Examples:
    |environment|withFA|menuCycle         |day    |mealPeriod|
    |QAI_2      |false |Automation Testing|TUESDAY|LUNCH     |
    
Scenario Outline: Verify Number of covers field is not present in the Nutrition screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then number of covers field is not present
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |mealPeriod|
    |QAI_2      |false |Meda     |MONDAY|LUNCH     |
    
@TC38024
Scenario Outline: Close nutrition weeks with "X" button redirects to the calendar daily view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Weeks tab is opened
        And Cross button is clicked and calendar view has loaded
    Then Verify calendar view is opened
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI_2      |false |Meda     |MONDAY|
    
@TC38023
Scenario Outline: Close nutrition weeks with "Cancel" button redirects to the calendar daily view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Weeks tab is opened
        And Cancel button is clicked and calendar view has loaded
    Then Verify calendar view is opened
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI_2      |false |Meda     |MONDAY|
    
@TC38030    
Scenario Outline: Save button is hidden for nutrition weeks
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Weeks tab is opened
    Then Verify save button is not present
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI_2      |false |Meda     |MONDAY|
    
@TC38807    
Scenario Outline: Verify Nutrition weekly totals equals the sum of all meal period totals
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Weeks tab is opened
    Then Verify weekly nutrition totals equals the sum of all meal period totals
        
    @QAI
    Examples:
    |environment|withFA|menuCycle                               |day   |
    |QAI_2      |false |AUTOMATION - API Integration Weekly View|MONDAY|
    
@TC39274    
Scenario Outline: Nutrition data is shown after changing planned quantity
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And data for recipes is set
            |MealPeriodName|TYPE  |RecipeTitle |PlannedQuantity|
            |<mealPeriod>  |RECIPE|<recipeName>|           1#99|
        And Save button is clicked
        And nutrition tab is opened
    Then Verify nutrition data for recipes are
        |MealPeriodName|RecipeTitle |EnergyKJ  |
        |<mealPeriod>  |<recipeName>|<energyKJ>|
        
    @QAI
    Examples:
    |environment|withFA|menuCycle         |day     |mealPeriod|recipeName      |energyKJ|
    |QAI_2      |false |Automation Testing|THURSDAY|CHLOE     |004Baked Beans_1|13092.00|