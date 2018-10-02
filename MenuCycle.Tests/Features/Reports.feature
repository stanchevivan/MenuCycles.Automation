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
