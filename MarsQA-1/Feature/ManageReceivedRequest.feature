Feature: ReceivedRequest
As a user
I want to manage the received request feature
so that 
	I could Accept, Complete and Decline received request. 

@mytag
Scenario: Check Accept button on Manage Request page
	Given I click on Manage Request
	When I click on the received request menu option
	And I Accept the new request
	Then I should see the Accepted status on the request status

@mytag
Scenario: Check Complete button on Manage Request page
	Given I have received a new request
	When I click on the received request menu option
	And I Accept the new request
	And I click on the Complete button.

@mytag
Scenario: Check Decline request on Manage Request page
	Given I received a new request
	When I click on the received request menu option
	And I Decline the new request
	Then I should see the Declined status on the request status