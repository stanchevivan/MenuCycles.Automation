﻿Feature: Meal Period Details

@TC30229
Scenario Outline: Only one cost is presented for single recipe in the meal period detailed view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
    Then Verify items in the meal period are
    |Name     |Type  |Cost   |
    |<recipe1>|Recipe|<cost1>|
    |<recipe2>|Recipe|<cost2>|
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day    |recipe1                   |cost1 |recipe2                  |cost2 |
    |QAI_2      |false |Meda     |LUNCH     |TUESDAY|724Gourmet Beef Burger 6oz|£0.375|724Gourmet Chicken Burger|£0.375|

@TC30230
Scenario Outline: Only one cost is presented for recipes in Buffet in the meal period detailed view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Buffet "Maya Buffet" is expanded
    Then Verify recipes in meal period details for buffet "Maya Buffet" are
    |Name                                  |Cost |
    |004Basic Sponge                       |£0.04|
    |004Fresh Lemon Curd                   |£6.63|
    |004Fish Stock (bouillon)              |£0.5 |
    |004Beef Stock (bouillon)              |£0   |
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day    |
    |QAI_2      |false |Meda     |DANGELO   |TUESDAY|

Scenario Outline: Only single cost is presented for recipes in recipe search
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe search is opened
        And Recipe "<recipe>" is searched
    Then Verify items present in the search results are
    |Name    |Type  |Cost  |
    |<recipe>|Recipe|<cost>|
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day    |recipe        |cost   |
    |QAI_2      |false |Meda     |LUNCH     |MONDAY |724Apple Sauce|£2.1886|
    
@TC39628
Scenario Outline: Copy and Delete buttons are disabled when new recipe is added
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe search is opened
        And Recipe "<recipe>" is searched
        And Recipe "<recipe>" is added
    Then Verify meal period copy button is disabled
        And Verify meal period delete button is disabled
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day    |recipe        |
    |QAI_2      |false |Meda     |LUNCH     |MONDAY |724Apple Sauce|
    
@TC39851 @TC39630
Scenario Outline: Copy/Delete buttons are enabled when you delete and add the same recipe to its original order
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe "<recipe>" is deleted
        And Verify meal period copy button is disabled
        And Verify meal period delete button is disabled
        And Recipe search is opened
        And Recipe "<recipe>" is searched
        And Recipe "<recipe>" is added
        And Recipe "<recipe>" order is set to "1"
    Then Verify meal period copy button is enabled
        And Verify meal period delete button is enabled
        And Verify order for item "<recipe>" is "1"
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day      |recipe          |
    |QAI_2      |false |Meda     |LANCE     |WEDNESDAY|004Baked Beans_0|
    
@TC39631    
Scenario Outline: Copy and Delete buttons are disabled when recipe order is changed
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe "<recipe>" order is set to "2"
    Then Verify meal period copy button is disabled
        And Verify meal period delete button is disabled
        And Verify order for item "<recipe>" is "2"
        And Recipe "<recipe>" order is set to "1"
        And Verify meal period copy button is enabled
        And Verify meal period delete button is enabled
        And Verify order for item "<recipe>" is "1"
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day      |recipe          |
    |QAI_2      |false |Meda     |LANCE     |WEDNESDAY|004Baked Beans_0|
    
@TC39629
Scenario Outline: Copy/Delete buttons are disabled when you have unsaved new recipes
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe search is opened
        And Recipe "<recipe1>" is searched
        And Recipe "<recipe1>" is added
            And Recipe "<recipe2>" is searched
            And Recipe "<recipe2>" is added
            And Recipe "<recipe2>" is deleted
    Then Verify meal period copy button is disabled
        And Verify meal period delete button is disabled
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day      |recipe1         |recipe2         |
    |QAI_2      |false |Meda     |LANCE     |WEDNESDAY|004Baked Beans_1|004Baked Beans_2|
    
Scenario Outline: Copy/Delete buttons are disabled when last recipe is deleted
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Details for meal period "<mealPeriod>" in "<day>" are opened
        And Recipe "<recipe>" is deleted
    Then Verify meal period copy button is disabled
        And Verify meal period delete button is disabled
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day      |recipe                  |
    |QAI_2      |false |Meda     |LANCE     |WEDNESDAY|004Beef Stock (bouillon)|

@TC40894 @D38047
Scenario Outline: Local user open recipe details
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>"
        And a local user is selected
        And location "<location>" is selected
    When Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
        And Details for meal period "<mealPeriod>" in "<day>" are opened
        And detailed view for recipe with name "<recipe>" is opened
    Then Verify meal period recipe name is "<recipe>"
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |week  |mealPeriod|recipe          |
    |QAI        |false |Site EUR1   |FOR Local User AUTOMATION|WED 31 JUL|WEEK 1|LUNCH     |004Baked Beans_2|