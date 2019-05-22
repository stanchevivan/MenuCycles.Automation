Feature: Meal Period Details

@TC30229
Scenario Outline: Only one cost is presented for single recipe in the meal period detailed view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
    Then Verify items in the meal period are
    |Name     |Type  |Cost   |
    |<recipe1>|Recipe|<cost1>|
    |<recipe2>|Recipe|<cost2>|
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |recipe1                   |cost1|recipe2                  |cost2|
    |QAI        |Meda     |LUNCH     |TUESDAY|724Gourmet Beef Burger 6oz|£0.36|724Gourmet Chicken Burger|£0.36|

@TC30230
Scenario Outline: Only one cost is presented for recipes in Buffet in the meal period detailed view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Buffet "Maya Buffet" is expanded
    Then Verify recipes in meal period details for buffet "Maya Buffet" are
    |Name                                  |Cost   |
    |004Basic Sponge                       |£0.585 |
    |004Beef Stock (bouillon)              |£0     |
    |004Fish Stock (bouillon)              |£0.4875|
    |004Fresh Lemon Curd                   |£6.3697|
    # |004German Shortcrust Pastry (fresh)007|£8.793 |
    # |724Custard Sauce (powder, fresh milk) |£0.4351|
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI        |Meda     |DANGELO   |TUESDAY|

Scenario Outline: Only single cost is presented for recipes in recipe search
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe search is opened
        And Recipe "<recipe>" is searched
    Then Verify items present in the search results are
    |Name    |Type  |Cost  |
    |<recipe>|Recipe|<cost>|
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |recipe        |cost   |
    |QAI        |Meda     |LUNCH     |MONDAY |724Apple Sauce|£2.1011|