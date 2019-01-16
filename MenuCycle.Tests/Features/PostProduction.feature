Feature: Post Production
	
@TC34327
Scenario Outline: Expand all / Collapse all Post-production Days
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily post-production tab is opened
        And Expand all is clicked
    Then Verify all post production meal periods are expanded
    When Collapse all is clicked
    Then Verify all post production meal periods are collapsed
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|WED 11 JUL|
    
@TC34693
Scenario Outline: Expand/Collapse single meal period Post-production days
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily post-production tab is opened
        And Post-production meal period "<mealPeriod>" is collapsed
    Then Verify main data for Meal Period "<mealPeriod>" is collapsed in Post production days
    When Post-production meal period "<mealPeriod>" is expanded
    Then Verify main data for Meal Period "<mealPeriod>" is expanded in Post production days
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |mealPeriod|
    |QAI        |SE001   |Local User Testing|WED 11 JUL|DINNER    |
    
Scenario Outline: Post production daily total calculations
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily post-production tab is opened
    Then Verify planned quantity daily total equals the sum of all meal period totals
    When values are entered for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|qtySold|noCharge|returnToStock|
    |      7|     10|      3|       1|            2|
    Then Verify Wastage is correctly calculated for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |mealPeriod|recipeName        |tariff   |
    |QAI        |SE001   |Local User Testing|WED 11 JUL|DINNER    |724Lamb Burger 6oz|TariffOne|
    
Scenario Outline: Post production validations
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily post-production tab is opened
    Then Verify planned quantity daily total equals the sum of all meal period totals
    When values are entered for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|qtySold|noCharge|returnToStock|
    |      a|      b|      c|       d|            e|
    Then Verify context errors are present for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtyReqd         |qtyProd         |qtySold         |noCharge        |returnToStock   |
    |<integerMessage>|<integerMessage>|<integerMessage>|<integerMessage>|<integerMessage>|
    When values are entered for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|qtySold|noCharge|returnToStock|
    |     -1|     -2|    -10|      -3|          -99|
    Then Verify context errors are present for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtyReqd          |qtyProd          |qtySold          |noCharge         |returnToStock    |
    |<negativeMessage>|<negativeMessage>|<negativeMessage>|<negativeMessage>|<negativeMessage>|
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |mealPeriod|recipeName        |tariff   |integerMessage |negativeMessage     |
    |QAI        |SE001   |Local User Testing|WED 11 JUL|DINNER    |724Lamb Burger 6oz|TariffOne|Must be integer|Must be 0 or greater|