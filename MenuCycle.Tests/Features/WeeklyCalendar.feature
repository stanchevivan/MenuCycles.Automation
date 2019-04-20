﻿@QAI
Feature: Weekly Calendar
Weekly Calendar Feature

@TC33038 @TC31075
Scenario Outline: Copy and Delete week in Weekly Calendar view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Weekly Calendar is opened
        And Week "Week 1" is copied
        And Verify notification message "Week Successfully Added." is displayed
        And Week "Week 2" is copied
        And Verify notification message "Week Successfully Added." is displayed
        And Delete button is clicked for week "Week 2"
        And Modal dialog Yes is selected
    Then Verify notification message "Week Successfully Removed." is displayed
        And Delete button is clicked for week "Week 2"
        And Modal dialog Yes is selected
        And Verify notification message "Week Successfully Removed." is displayed
    @QAI
    Examples:
    |environment|menuCycle            |
    |QAI        |Automation Menu Cycle|
        
@TC37776
Scenario Outline: Empty weeks are not present in the calendar weekly view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When new week is added
        And new week is added
        And Meal period "<mealPeriod>" is created for "<day>"
        And Recipe search is opened
        And Recipe "<recipeName>" is searched
        And Recipe "<recipeName>" is added
        And Meal period is saved with notification "Meal Period Saved successfully"
        And meal period detailed view is closed
        And Weekly Calendar is opened
        And Verify caledar weeks contains weeks:
            |WEEK 1|WEEK 3|
        And Week "WEEK 3" is copied
        Then Verify notification message "Week Successfully Added." is displayed
        And Verify caledar weeks contains weeks:
            |WEEK 1|WEEK 3|WEEK 4|
        And Delete button is clicked for week "Week 3"
        And Modal dialog Yes is selected
        Then Verify notification message "Week Successfully Removed." is displayed
        And Verify caledar weeks contains weeks:
            |WEEK 1|WEEK 3|
        And Delete button is clicked for week "Week 3"
        And Modal dialog Yes is selected
        Then Verify notification message "Week Successfully Removed." is displayed
        And Verify caledar weeks contains weeks:
            |WEEK 1|
        When Daily Calendar is opened
    Then Verify next week arrow is not present
    
    @QAI
    Examples:
    |environment|menuCycle             |mealPeriod|day   |recipeName                 |
    |QAI        |Automation Copy Delete|LUNCH     |Monday|703Reggae Raggae Mayonnaise|
    
@TC37973
Scenario Outline: Open meal period from the weekly view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
    Given Menu Cycle "<menuCycle>" is selected
    When Weekly Calendar is opened
        And meal period "<mealPeriod>" in day "<day>" for week "<weekName>" is opened
    Then Verify meal period details for "<weekName> <day>" is open
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day   |weekName|
    |QAI        |Meda     |Dangelo   |MONDAY|WEEK 2  |
    
@TC38017
Scenario Outline: NaN is not displayed for Week title
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Weekly Calendar is opened
        And Daily Calendar is opened
    Then Verify week name is "WEEK 1"
        
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |
    
@TC38017
Scenario Outline: GAP days are indicated in weekly view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Weekly Calendar is opened
    Then Verify day "<day>" in week "<week>" is GAP day
        
    @QAI
    Examples:
    |environment|menuCycle            |day     |week  |
    |QAI        |Automation Menu Cycle|Saturday|Week 1|