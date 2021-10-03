Feature: Login
As a I	
	I want to login into account
So that
	I am able to enter profile details.

@login
Scenario: When valid Username and password entered login should be successful
	Given I click on signin button on Login page 
    When I enter valid Iname and valid password credentials
    And Click on login button
    Then I login to my profile successfully.

	@login
Scenario: when invalid Username and valid password entered login should be unsuccessful
	Given I click on login button
    When I enter invalid Iname and valid password
    And Click on login button
    Then I should not be logged in. 

    


