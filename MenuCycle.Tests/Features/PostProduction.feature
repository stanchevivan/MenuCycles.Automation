Feature: Post Production
	
@TC34327
Scenario Outline: Expand all / Collapse all Post-production Days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And Expand all is clicked
    Then Verify all post production meal periods are expanded
    When Collapse all is clicked
    Then Verify all post production meal periods are collapsed
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle           |week  |day       |
    |QAI        |false |Site EUR1   |Automation post-prod|WEEK 3|FRI 26 JUL|
    
@TC34693
Scenario Outline: Expand/Collapse single meal period Post-production days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And Post-production meal period "<mealPeriod>" is collapsed
    Then Verify main data for Meal Period "<mealPeriod>" is collapsed in Post production days
    When Post-production meal period "<mealPeriod>" is expanded
    Then Verify main data for Meal Period "<mealPeriod>" is expanded in Post production days
    
    @QAI
    Examples:
    |environment|withFA|location |menuCycle           |week  |day       |mealPeriod|
    |QAI        |false |Site EUR1|Automation post-prod|WEEK 3|FRI 26 JUL|MARGRET   |
    
Scenario Outline: Post production daily total calculations
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And Expand all is clicked
    Then Verify planned quantity daily total equals the sum of all meal period totals
    When values are entered for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtySold|
    |      2|
    And values are entered for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|noCharge|returnToStock|
    |     55|     60|      15|            5|
    Then Verify Wastage is correctly calculated for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    And Verify values for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    |plannedQty|qtySold|
    |        48|     62|
    
    @QAI
    Examples:
    |environment|withFA|location    |menuCycle                        |week  |day       |mealPeriod|recipeName      |tariff   |recipe|
    |QAI        |false |Site EUR1   |Post-production MC for AUTOMATION|WEEK 1|THUR 21 NOV|MARGRET   |004Apple Sauce_100|TariffOne|Recipe Total|
    
Scenario Outline: Post production validations
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
    Then Verify planned quantity daily total equals the sum of all meal period totals
    When values are entered for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtySold|
    |      c|
    Then Verify context errors are present for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtySold         |
    |<integerMessage>|
    When values are entered for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtySold|
    |    -10|
    Then Verify context errors are present for recipe "<recipeName>" tariff "<tariff>" in meal period "<mealPeriod>"
    |qtySold          |
    |<negativeMessage>|
    When values are entered for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|noCharge|returnToStock|
    |     c|     a|      1b|            n|
    Then Verify context errors are present for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|noCharge|returnToStock|
    |<integerMessage>|<integerMessage>|<integerMessage>|<integerMessage>|
    When values are entered for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|noCharge|returnToStock|
    |     -5|     -6|      -3|           -5|
    Then Verify context errors are present for recipe "<recipeName>" tariff "<recipe>" in meal period "<mealPeriod>"
    |qtyReqd|qtyProd|noCharge|returnToStock|
    |<negativeMessage>|<negativeMessage>|<negativeMessage>|<negativeMessage>|
    
    @QAI
    Examples:
    |environment|withFA|location |menuCycle           |week  |day       |mealPeriod |recipeName      |tariff   |recipe|integerMessage |negativeMessage     |
    |QAI        |false |Site EUR1|Automation post-prod|WEEK 3|FRI 26 JUL|MARGRET    |004Apple Sauce_100|TariffOne|Recipe Total|Must be integer|Must be 0 or greater|


@TC35467 @D31395
Scenario Outline: Open Post-Production Screen, navigate to Weekly view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And switching to Weekly Post-Production view
    Then Verify Weekly Post-production view is open
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle           |week  |day       |
    |QAI        |false |Site EUR1   |Automation post-prod|WEEK 3|FRI 26 JUL|
  
 # Scenario is commented until POS integration is finished   
 # @TC35573
 # Scenario Outline: POS Integration: When "isSoldQtyReadOnly" flag = false, 'qty sold' is disabled for buffet at menu level
   #  Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
   #      And a local user is selected
   #      And location "<location>" is selected
   #      And Menu Cycle "<menuCycle>" is selected
   #  When planning for "<day>" is opened
   #      And post-production tab is opened
   # Then Verify Qty Sold input field is disabled for buffet "<buffetName>" in meal period "<mealPeriod>"
   
    #    @QAI
    # Examples:
    # |environment|withFA|location|menuCycle       |day       |buffetName |mealPeriod|
    # |QAI        |false |Site EUR1   |Please don`t use|TUE 29 JAN|Maya Buffet|   DANGELO|
    
@TC36205  
Scenario Outline: Export Local Sales report
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 2" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And local sales report is exported
    Then Verify notification message "Successfully Exported." is displayed
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day       |
    |QAI        |false |Site EUR1   |Local User Testing|WED 31 JUL|
    
@TC36009 @TC36010
Scenario Outline: Wastage is an input field and QtySold and No charge fields are not present for buffet recipes
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
   Then Verify Wastage for buffet "<buffetName>" recipe "<recipeName>" in meal period "<mealPeriod>" is an editable field
       And Verify Qty Sold and No Charge fields for buffet "<buffetName>" recipe "<recipeName>" in meal period "<mealPeriod>" are not present
    
       @QAI
    Examples:
    |environment|withFA|location|menuCycle           |week  |day       |buffetName |recipeName     |mealPeriod|
    |QAI        |false |Site EUR1   |Automation post-prod|WEEK 3|FRI 26 JUL|Maya Buffet|004Basic Sponge|   MARGRET|
    
Scenario Outline: Wastage field is disabled for recipes
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
   Then Verify Wastage for recipe "<recipeName>" in meal period "<mealPeriod>" is disabled
   
       @QAI
    Examples:
    |environment|withFA|location|menuCycle           |week  |day       |recipeName             |mealPeriod|
    |QAI        |false |Site EUR1   |Automation post-prod|WEEK 3|FRI 26 JUL|004Apple Sauce_100|   MARGRET|
    
@TC36011
Scenario Outline: Contextual error message is shown for Wastage for buffet recipes when decimal is inputed
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 3" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And Wastage value "9.11" is inputed for buffet "<buffetName>" recipe "<recipeName>" in meal period "<mealPeriod>"
    Then Verify contextual error message "Must be integer" is displayed for Wastage field for buffet "<buffetName>" recipe "<recipeName>" in meal period "<mealPeriod>"

       @QAI
    Examples:
    |environment|withFA|location|menuCycle           |day       |buffetName |recipeName     |mealPeriod|
    |QAI        |false |Site EUR1   |Automation post-prod|FRI 26 JUL|Maya Buffet|004Basic Sponge|   MARGRET|

@TC36211
Scenario Outline: Buffet tariff type is present at menu level
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
    Then Buffet tariff type is present for buffet "<buffetName>" in meal period "<mealPeriod>"
    
           @QAI
    Examples:
    |environment|withFA|location|menuCycle           |week  |day       |buffetName |recipeName     |mealPeriod|
    |QAI        |false |Site EUR1   |Automation post-prod|WEEK 3|FRI 26 JUL|Maya Buffet|004Basic Sponge|   MARGRET|
    
@TC38808    
Scenario Outline: Verify Post-Production weekly totals equals the sum of all meal period totals
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<week>" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And Weeks tab is opened
    Then Verify weekly post-production totals equals the sum of all meal period totals
        And Verify post-production weekly totals are
        |qtyReqd  |qtyProd  |qtySold  |noCharge  |returnToStock  |wastage  |
        |<qtyReqd>|<qtyProd>|<qtySold>|<noCharge>|<returnToStock>|<wastage>|
    
    @QAI
    Examples:
    |environment|withFA|location |menuCycle           |week  |day       |qtyReqd|qtyProd|qtySold|noCharge|returnToStock|wastage|
    |QAI        |false |Site EUR1|Post-production MC for AUTOMATION|WEEK 1|THUR 21 NOV|143   |105    |102    |59       |23            |95    |