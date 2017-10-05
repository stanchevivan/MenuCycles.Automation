Feature: MenuCycles
    In order to guarantee the Menu Cycles UI quality
    As a QA
    I want to validate all possible functionalities and permutations

Background: 
Given 'Menu Cycles' application is open
And a central user is selected

@menucycle
Scenario: Create Menu Cycle
    When a Menu Cycle with the following criteria is create
      | Group    | NonServingDays |
      | SodexoUp | 32             |
    Then the message 'Menu Cycle has been created.' is displayed
    And the calendar view is opened     