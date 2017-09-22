Feature: Basic
	In order to test Menu Cycles application
	As a QA Engineer
	I want to test all basic funcitionalities

Background: 
Given Fourth Engage Dashboard is open
And 'Menu Cycles' application is selected

@create
Scenario: Menu Cycle with No Non Serving Days
	Given the Menu Cycles Dashboard is open as a central user
	When a Menu Cycle with the following data is created
	  | Group    | NonServingDays |
	  | SodexoUp | 0              |
	Then the message 'Menu Cycle has been created.' is displayed
	And the calendar view is opened

Scenario: Add recipe searching by Name #2
	Given data exists
	And the Menu Cycles Dashboard is open as a central user


	When a test is made for TUESDAY
	#Given a Menu Cycle and Recipe exists
	#And the Menu Cycles Dashboard is open as a central user
	#When a recipe found searching by name is added to a meal period
	Then the message 'Meal Period Saved successfully' is displayed
	And recipe is shown in the calendar view

#Scenario: Add recipe searching by Name #1
#	Given a Menu Cycle with the following data exists
#	| Name                          | Description              | NonServingDays | Group    |
#	| Ico Winter Schools Menu Cycle | Lorem ipsum dolor school | 0              | SodexoUp |
#	| Ico Testing Second Line       | This is just a test      | 0              | SodexoUp |
#	And the Menu Cycles Dashboard is open as a central user
#	And a Recipe with the following data exists
#	| Name     |
#	| Whatever | 
#	When a recipe found searching by name is added to a meal period
#	Then the message 'Meal Period Saved successfully.' is displayed
#	And recipe is shown in the calendar view

#Scenario: NOTE
#Given: 
	#Creates a Menu Cycles with a meal Period to DB
	#Creates a Recipe
	#Creates an object with the created data and store in scenario context
#When: 
	#Selects the Meal Period
	#Search for a Recipe and adds to meal period

#Then:
	#Validates message
	#Validate if recipe is included into Meal Period

#Post
	#Delete all created objects