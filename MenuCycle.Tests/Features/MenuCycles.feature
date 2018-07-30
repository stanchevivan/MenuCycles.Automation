# Example feature
@ignore
Feature: MenuCycles
    Menu Cycles functionalities and validations

Background: 
Given 'Menu Cycles' application is open
And a central user is selected

Scenario: Test
    Given Menu Cycle is created with following data
    |MenuCycleName|Description|GapDays        |Usergroup    |
    |   Menu Cycle|Description|Saturday,Sunday|SodexoUK     |
