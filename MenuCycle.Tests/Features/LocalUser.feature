@QAI
Feature: LocalUser
    Meal Peridos functionalities and validations

@TC27777 @Sanity
Scenario Outline: Local user can not delete menu cycle
Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    When Menu Cycle "<menuCycle>" is searched
        And action menu is opened for menu cycle "<menuCycle>" 
    Then Delete button is not present for menu cycle "<menuCycle>"
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|