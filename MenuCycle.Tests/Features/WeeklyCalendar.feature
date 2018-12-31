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