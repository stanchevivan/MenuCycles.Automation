@QAI @Performance
Feature: Performance Tests
    Feature for Performance Tests

@TC35430
Scenario Outline: Initial load of menu cycles list
Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
When Measure performance of load menu cycles list for "100" repetitions
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |
    
@TC35434
Scenario Outline: Central user search recipes
Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
    And a central user is selected
    And Menu Cycle "<menuCycle>" is selected
When Details for meal period "<mealPeriod>" in "<day>" are opened
    And Recipe search is opened
    And Measure performance of recipe search for "100" repetitions on "<recipe>"
    
    @QAI
    Examples:
    |environment|withFA|menuCycle                     |recipe|day      |mealPeriod|
    |QAI        |false |Automation Performance Testing|      |WEDNESDAY|LUNCH     |
    
@TC35443
Scenario Outline: Open planning screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Measure performance of Open planning screen for "20" repetitions on "<day>"
    
    @QAI
    Examples:
    |environment|withFA|menuCycle                     |day      |
    |QAI        |false |Automation Performance Testing|WEDNESDAY|
    
@TC35444
Scenario Outline: Open nutrition screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Measure performance of Open nutrition screen for "20" repetitions
    
    @QAI
    Examples:
    |environment|withFA|menuCycle                     |day      |
    |QAI        |false |Automation Performance Testing|WEDNESDAY|
    
@TC35445
Scenario Outline: Open calendar weeks
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Measure performance of Open weekly calendar view for "20" repetitions
    @QAI
    Examples:
    |environment|withFA|menuCycle                     |
    |QAI        |false |Automation Performance Testing|
    
@TC35439
Scenario Outline: Open menu cycle with 1800 items
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
    When Measure performance of Open menu cycle for "10" repetitions for "<menuCycle>"
    @QAI
    Examples:
    |environment|withFA|location|menuCycle            |
    |QAI        |false |Site EUR1   |Winter Breakfast Menu|
    
@TC39657
Scenario Outline: Open menu cycle with 4000 items in one week
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
    When Measure performance of Open menu cycle for "10" repetitions for "<menuCycle>"
    @QAI
    Examples:
    |environment|withFA|location|menuCycle               |
    |QAI        |false |Site EUR1   |4000 items - Do not use|