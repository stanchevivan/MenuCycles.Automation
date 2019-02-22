@QAI @Performance
Feature: Performance Tests
    Feature for Performance Tests

@TC35433
Scenario Outline: Local user locations
Given Menu Cycle app is open on "<environment>" 
When Performance for "10" repetitions of Select Location -> Click location name for location "<location>" is evaluated
    
    @QAI
    Examples:
    |environment|location |
    |QAI        |MockLoc_1|  
    
@TC35434
Scenario Outline: Central user search recipes
Given Menu Cycle app is open on "<environment>" 
    And a central user is selected
    And Menu Cycle "<menuCycle>" is selected
When Details for meal period "DINNER" in "FRIDAY" are opened
    And Recipe search is opened
    And Performance for "10" repetitions for recipe search on "<recipe>"
    
    @QAI
    Examples:
    |environment|location |menuCycle         |recipe|
    |QAI        |MockLoc_1|Automation Testing|004Baked Beans_3|
    
@TC35443
Scenario Outline: Open planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    
    @QAI
    Examples:
    |environment|menuCycle         |
    |QAI        |Automation Testing|