Feature: RecipeSearch
	In order to guarantee Recipe Search works
	As a QA
	I want to validate all permutations and functionalities

Background: 
Given 1 Menu Cycles exists
And 1 Meal Period exists
And 'Menu Cycles' application is open
And a central user is selected

@searchRecipe
Scenario: Add Recipe Searching By Name
	Given 3 recipes exists
	And a Menu Cycle is selected
	When a Meal Period for MONDAY is added
	And the first recipe is searched by name 
	And recipe is added to a meal period
	Then the message 'Meal Period Saved successfully' is displayed
	And recipe is displayed under MONDAY column inside the correct Meal Period
