﻿Feature: MenuCycles
	In order to guarantee the Menu Cycles UI quality
	As a QA
	I want to validate all possible functionalities and permutations

#Background: 
#Given 'Menu Cycles' application is open
#And a central user is selected

@create
Scenario: Create Menu Cycle
	When a Menu Cycle with the following criteria is create
	  | Group    | NonServingDays |
	  | SodexoUp | 0              |
	Then the message 'Menu Cycle has been created.' is displayed
	And the calendar view is opened

Scenario: Seed Test
	Given 3 recipes exists