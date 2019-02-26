@QAI @Performance
Feature: Performance Tests
    Feature for Performance Tests

@TC35430
Scenario Outline: Initial load of menu cycles list
Given Menu Cycle app is open on "<environment>" 
When Measure performance of load menu cycles list for "20" repetitions
    
    @QAI
    Examples:
    |environment|
    |QAI        |
    
@TC35434
Scenario Outline: Central user search recipes
Given Menu Cycle app is open on "<environment>" 
    And a central user is selected
    And Menu Cycle "<menuCycle>" is selected
When Details for meal period "<mealPeriod>" in "<day>" are opened
    And Recipe search is opened
    And Measure performance of recipe search for "100" repetitions on "<recipe>"
    
    @QAI
    Examples:
    |environment|menuCycle                     |recipe|day      |mealPeriod|
    |QAI        |Automation Performance Testing|      |WEDNESDAY|LUNCH     |
    
@TC35443
Scenario Outline: Open planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Measure performance of Open planning screen for "20" repetitions on "<day>"
    
    @QAI
    Examples:
    |environment|menuCycle                     |day      |
    |QAI        |Automation Performance Testing|WEDNESDAY|
    
@TC35444
Scenario Outline: Open nutrition screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Measure performance of Open nutrition screen for "20" repetitions
    
    @QAI
    Examples:
    |environment|menuCycle                     |day      |
    |QAI        |Automation Performance Testing|WEDNESDAY|
    
@TC35445
Scenario Outline: Open calendar weeks
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Measure performance of Open weekly calendar view for "20" repetitions
    @QAI
    Examples:
    |environment|menuCycle                     |
    |QAI        |Automation Performance Testing|
    
@TC35439
Scenario Outline: Open menu cycle with 1800 items
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    When Measure performance of Open menu cycle with 1800 items for "10" repetitions for "<menuCycle>"
    @QAI
    Examples:
    |environment|location|menuCycle            |
    |QAI        |SE001   |Winter Breakfast Menu|