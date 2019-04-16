@QAI
Feature: Weekly Calendar
Weekly Calendar Feature

Background: 
Given 'Menu Cycles' application is open
And a central user is selected
#And a nouser user is selected

@TC33038 @TC31075
Scenario: Copy and Delete week in Weekly Calendar view
    Given Menu Cycle "Automation Menu Cycle" is selected
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
        
@TC37776
Scenario Outline: Empty weeks are not present in the calendar weekly view
    Given Menu Cycle "<menuCycle>" is selected
    When new week is added
        And new week is added
        And Meal period "<mealPeriod>" is created for "<day>"
        And Recipe search is opened
        And Recipe "<recipeName>" is searched
        And Recipe "<recipeName>" is added
        And Meal period is saved
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