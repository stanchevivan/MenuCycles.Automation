@QAI
Feature: Performance Tests
    Feature for Performance Tests

@TC27777 @Sanity
Scenario Outline: Local user locations
Given Menu Cycle app is open on "<environment>" 
When a local user is selected
        And Performance for "10" repetitions of Select Location -> Click location name for location "<location>" is evaluated
    
    @QAI
    Examples:
    |environment|location|
    |QAI        |KIRO    |  