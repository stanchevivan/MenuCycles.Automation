@QAI
Feature: Weekly Calendar
Weekly Calendar Feature

Background: 
Given 'Menu Cycles' application is open
And a central user is selected
#And a nouser user is selected

@TC33038
Scenario: Copy and Delete week in Weekly Calendar view
    Given Menu Cycle "Automation Menu Cycle" is selected
    When Weekly Calendar is opened
        And Week "Week 2" is copied
        And Notification message "Week Successfully Added." is displayed
        And Delete button is clicked for week "Week 3"
        And Modal dialog Yes is selected
    Then Notification message "Week Successfully Removed." is displayed
        