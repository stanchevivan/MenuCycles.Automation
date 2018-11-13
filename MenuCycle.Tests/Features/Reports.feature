@QAI
Feature: Reports
    Reports feature

Background: 
Given 'Menu Cycles' application is open
And a central user is selected
#And a nouser user is selected

@TC32573 @D28281
Scenario: Open report page for menu cycle without items
	Given Menu Cycle "MC without items" is selected
	When Reports page is opened
    Then Reports page is correctly loaded
    
Scenario: Consumer Facing Report - Price options are not disabled for Local user
    Given Menu Cycle "Meda" is selected
    When Reports page is opened
    And Consumer facing report is opened
    And Include sell price is checked
    And Home button is clicked
    And Location name is clicked
    And a local user is selected
    And location "SE001" is selected
    And Menu Cycle "Menasdasd" is selected
    When Reports page is opened
    And Consumer facing report is opened
    Then Verify Include sell price is checked
    And Verify Price type dropdown is disabled