Feature: Basic
	In order to test Menu Cycles application
	As a QA Engineer
	I want to test all basic funcitionalities

@create
Scenario: Menu Cycle with No Non Serving Days
	Given the Menu Cycles Dashboard is opened as a central user
	When a Menu Cycle with the following data is created
	  | Offer    |
	  | SodexoUp |
	Then the message Menu Cycle has been created. is displayed
	And the calendar view is opened