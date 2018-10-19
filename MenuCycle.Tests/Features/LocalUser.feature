@QAI # @planningscreen
Feature: LocalUser
    Meal Peridos functionalities and validations

Background: 
And 'Menu Cycles' application is open
And a local user is selected

@TC27777 @Sanity
Scenario: Local user can not delete menu cycle
    Given location "SE001" is selected
    When action menu is opened for menu cycle "Local User Testing" 
    Then Delete button is not present for menu cycle "Local User Testing"