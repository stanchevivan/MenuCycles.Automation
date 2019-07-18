@QAI
Feature: LocalUser
    Meal Peridos functionalities and validations

@TC27777 @Sanity
Scenario Outline: Local user can not delete menu cycle
# Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>"
        And a local user is selected
        And location "<location>" is selected
    When Menu Cycle "<menuCycle>" is searched
        And action menu is opened for menu cycle "<menuCycle>"
    Then Verify delete button is not present for menu cycle "<menuCycle>"
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |
    |QAI        |false |SE001   |Local User Testing|
