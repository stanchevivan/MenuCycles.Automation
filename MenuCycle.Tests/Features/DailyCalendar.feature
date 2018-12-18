Feature: Daily Calendar
	Daily Calendar Feature
	
@TC34368 @TC34367
Scenario Outline: Daily Calendar view is switched for central user
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When daily calendar view is switched
        And Verify day "<day>" is visible
        And daily calendar view is switched
    Then Verify day "<day>" is not visible
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI        |Meda     |Sunday|
    
@TC34370 @TC34369
Scenario Outline: Daily Calendar view is switched for local user
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    When Menu Cycle "<menuCycle>" is selected
        And daily calendar view is switched
        And Verify day "<day>" is visible
        And daily calendar view is switched
    Then Verify day "<day>" is not visible
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day      |
    |QAI        |SE001   |Local User Testing|SUN 5 AUG|