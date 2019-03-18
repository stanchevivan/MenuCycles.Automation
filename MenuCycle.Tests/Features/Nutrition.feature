Feature: Nutrition screen
	
Scenario Outline: Expand all / Collapse all meal periods Nutrition Days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    When Expand all is clicked
    Then Verify all nutrition meal periods are expanded
        And Collapse all is clicked
        And Verify all nutrition meal periods are collapsed
    
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI        |Meda     |Tuesday|
    
Scenario Outline: Expand/Collapse single meal period Nutritions screen days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
        And Nutrition meal period "<mealPeriod>" is collapsed
    Then Verify main data for Meal Period "<mealPeriod>" is collapsed in Nutrition days
    When Nutrition meal period "<mealPeriod>" is expanded
    Then Verify main data for Meal Period "<mealPeriod>" is expanded in Nutrition days
    
    @QAI
    Examples:
    |environment|menuCycle|day   |mealPeriod|
    |QAI        |Meda     |Monday|LUNCH     |
    
Scenario Outline: Single Meal Period is expanded by default in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    Then Verify all meal periods are expanded in Nutrition screen days
    
    @QAI
    Examples:
    |environment|menuCycle|day   |mealPeriod|
    |QAI        |Meda     |Monday|LUNCH     |
    
Scenario Outline: Multiple Meal Periods are collapsed by default in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    Then Verify all meal periods are collapsed in Nutrition screen days
    
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI        |Meda     |Tuesday|
          
Scenario Outline: Verify save button is disabled for in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    Then Verify save button is disabled
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI        |Meda     |Monday|
    
Scenario Outline: Calendar view is opened when Cancel is clicked in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And daily nutrition tab is opened
    When Cancel button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI        |Meda     |MONDAY|
    
Scenario Outline: Calendar view is opened when Cross is clicked in the Nutrition screen days
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And daily nutrition tab is opened
    When Cross button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI        |Meda     |MONDAY|
    
Scenario Outline: Retrieve recipe information from the API in Nutrition screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And "PlannedQuantity" is saved in context for recipe "<recipeName>" in meal period "<mealPeriod>"
        And daily nutrition tab is opened
    Then Verify nutrition data for recipes are
        |MealPeriodName|RecipeTitle |PlannedQuantity  |MixPercent  |EnergyKJ  |EnergyKCAL  |Fat  |SaturatedFat  |Sugar  |Salt  |
        |<mealPeriod>  |<recipeName>|<plannedQuantity>|<mixPercent>|<energyKJ>|<energyKCAL>|<fat>|<saturatedFat>|<sugar>|<salt>|
        
    @QAI
    Examples:
    |environment|menuCycle|day     |mealPeriod|recipeName      |mixPercent|energyKJ|energyKCAL|fat   |saturatedFat |sugar    |salt|
    |QAI        |Meda     |Monday  |LUNCH     |004Baked Beans_3|       100|   452.4|       108|  0.48|         0.24|     5.88| 360|
    
Scenario Outline: Validate Nutritions Daily Totals
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    Then Verify Nutrition Daily Totals are equal to
        |PlannedQty|EnergyKJ|EnergyKCAL|Fat   |SaturatedFat |Sugar    |Salt|
        |       248|       0|         0|     0|            0|        0|   0|
        
    @QAI
    Examples:
    |environment|menuCycle|day    |
    |QAI        |Meda     |TUESDAY|
    
Scenario Outline: Validate Nutritions Meal Period Totals
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    Then Verify Nutritions Meal Period "<mealPeriod>" Totals are equal to
        |PlannedQty|EnergyKJ|EnergyKCAL|Fat   |SaturatedFat |Sugar    |Salt|
        |         5|       0|         0|     0|            0|        0|   0|
        
    @QAI
    Examples:
    |environment|menuCycle|day   |mealPeriod|
    |QAI        |Meda     |MONDAY|LUNCH     |
    
Scenario Outline: Verify Number of covers field is not present in the Nutrition screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily nutrition tab is opened
    Then number of covers field is not present
        
    @QAI
    Examples:
    |environment|menuCycle|day   |mealPeriod|
    |QAI        |Meda     |MONDAY|LUNCH     |