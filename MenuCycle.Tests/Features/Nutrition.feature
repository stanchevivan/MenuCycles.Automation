Feature: Nutrition screen
	
@TC36897
Scenario Outline: Expand all / Collapse all meal periods Nutrition Days
    Given Menu Cycle app is open on "<environment>" 
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
    |environment|menuCycle|day    |
    |QAI_2        |Meda     |Tuesday|

@TC36898    
Scenario Outline: Expand/Collapse single meal period Nutritions screen days
    Given Menu Cycle app is open on "<environment>" 
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
    |environment|menuCycle|day   |mealPeriod|
    |QAI_2        |Meda     |Monday|LUNCH     |

@TC36908 
Scenario Outline: Single Meal Period is expanded by default in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify all meal periods are expanded in Nutrition screen days
    
    @QAI
    Examples:
    |environment|menuCycle|day   |mealPeriod|
    |QAI_2        |Meda     |Monday|LUNCH     |
 
@TC36909       
Scenario Outline: Multiple Meal Periods are collapsed by default in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify all meal periods are collapsed in Nutrition screen days
    
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI_2        |Meda     |Tuesday|
   
@TC36910         
Scenario Outline: Verify save button is disabled for in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify save button is disabled
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI_2        |Meda     |Monday|

@TC36912    
Scenario Outline: Calendar view is opened when Cancel is clicked in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And nutrition tab is opened
    When Cancel button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI_2        |Meda     |MONDAY|
    
@TC36913
Scenario Outline: Calendar view is opened when Cross is clicked in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And nutrition tab is opened
    When Cross button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI_2        |Meda     |MONDAY|
    
@TC36938
Scenario Outline: Retrieve recipe information from the API in Nutrition screen
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And "PlannedQuantity" is saved in context for recipe "<recipeName>" in meal period "<mealPeriod>"
        And nutrition tab is opened
    Then Verify nutrition data for recipes are
        |MealPeriodName|RecipeTitle |PlannedQuantity  |MixPercent  |EnergyKJ  |EnergyKCAL  |Fat  |SaturatedFat  |Sugar  |Salt  |
        |<mealPeriod>  |<recipeName>|<plannedQuantity>|<mixPercent>|<energyKJ>|<energyKCAL>|<fat>|<saturatedFat>|<sugar>|<salt>|
        
    @QAI
    Examples:
    |environment|menuCycle|day     |mealPeriod|recipeName      |mixPercent|energyKJ|energyKCAL|fat   |saturatedFat |sugar    |salt|
    |QAI_2      |Meda     |Monday  |LUNCH     |004Baked Beans_3|       100|   452.4|       108|  0.48|         0.24|     5.88| 360|
    
Scenario Outline: Planned qty are summed for recipe with more than one tariffs
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When sum of planned qty for all tariffs for recipe "<recipeName>" in meal period "<mealPeriod>" are saved in context
        And nutrition tab is opened
    Then Verify Planned Qty for recipe "<recipeName>" in meal period "<mealPeriod>" equals the sum of the tariffs planned qty values
    
    @QAI
    Examples:
    |environment|menuCycle|day     |mealPeriod|recipeName      |tariffOne|tariffTwo|
    |QAI_2        |Meda     |Saturday|     LUNCH|004Baked Beans_3|TariffOne|TariffTwo|
    
Scenario Outline: Validate Nutritions Daily Totals
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify daily nutrition totals equals the sum of all meal period totals
        
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI_2        |Meda     |TUESDAY|
    
Scenario Outline: Validate Nutritions Meal Period Totals
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then Verify meal period "<mealPeriod>" nutrition total equals the sum of all recipes nutrition values
        
    @QAI
    Examples:
    |environment|menuCycle         |day    |mealPeriod|
    |QAI_2        |Automation Testing|TUESDAY|LUNCH     |
    
Scenario Outline: Verify Number of covers field is not present in the Nutrition screen
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
    Then number of covers field is not present
        
    @QAI
    Examples:
    |environment|menuCycle|day   |mealPeriod|
    |QAI_2      |Meda     |MONDAY|LUNCH     |
    
@TC37314
Scenario Outline: Close nutrition weeks with "X" button redirects to the calendar daily view
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Weeks tab is opened
        And Cross button is clicked and calendar view has loaded
    Then Verify calendar view is opened
        
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI_2      |Meda     |MONDAY|
    

Scenario Outline: Close nutrition weeks with "Cancel" button redirects to the calendar daily view
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And nutrition tab is opened
        And Weeks tab is opened
        And Cancel button is clicked and calendar view has loaded
    Then Verify calendar view is opened
        
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI_2      |Meda     |MONDAY|