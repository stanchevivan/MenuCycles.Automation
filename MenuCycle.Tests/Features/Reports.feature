@QAI
Feature: Reports
    Reports feature

Background: 
Given 'Menu Cycles' application is open
And a central user is selected
#And a nouser user is selected

@TC32573 @D28281
Scenario: Open report page for menu cycle with specific group
	Given Menu Cycle "MC for group test" is selected
	When Reports page is opened
    Then Reports page is correctly loaded
