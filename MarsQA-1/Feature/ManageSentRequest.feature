Feature: SentRequest
As a Seller
I want to manage the sent request feature
so that 
	I could Check the Withdraw and Pending Status of SentRequest

@mytag
Scenario:Check Sent Request Pending 
	Given I click on ManageRequest tab on Home page
	And I Select SentRequest DropDown
	Then Check if the receiver has not accepted the request then, Status will be pending.

	Scenario:Check Sent Request Withdrawn
	Given I click on ManageRequest tab on Home page
	When I Select SentRequest DropDown
	And I click on withdraw button
	Then the Status should be Withdrawn

	Scenario:Check Sent Request Completed
	Given I click on ManageRequest tab on Home page
	And I select SentRequest DropDown 
	And if the Status is accepted for sent request
	Then Click on Completed Button

	Scenario:Check Review in Sent Request
	Given I click ManageRequest tab 
	And I select SentRequest DropDown
	And if the Status is Completed 
	Then I click on Review Button 
	And I Add Review Text and Ratings and Save.

	Scenario:Check Sent Request Declined
	Given I click ManageRequest tab 
	And I select SentRequest DropDown
	And if the Status is Declined the Request is Declined
	