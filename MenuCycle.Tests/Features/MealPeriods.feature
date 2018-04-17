#@menucycle @mealperiod @recipe
Feature: MealPeriods
	Meal Peridos functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC28547
Scenario: Open daily planning with one meal period
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    Then main data for Meal Period "Lunch" is expanded

@TC27663
Scenario: Open daily planning with multiple meal period
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    Then main data for Meal Period "Dinner" is collapsed

@TC28566
Scenario: Display correct meal period name
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    Then the planning screen for Tuesday is open

@TC28549
Scenario: Collapse single meal period
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    And Meal Period "Lunch" is collapsed
    Then main data for Meal Period "Lunch" is collapsed

@TC28548
Scenario: Expand single meal period
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    And Meal Period "Lunch" is expanded
    Then main data for Meal Period "Lunch" is expanded

@TC28546
Scenario: The colour of every meal period in the Planning screen is the same as in the calendar page
    Given Menu Cycle "Meda" is selected
    And Meal Period colours for "Tuesday" are saved
    When planning for Tuesday is opened
    Then Meal Period colours match the calendar view colours