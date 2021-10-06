Feature: SentRequest
As a Seller
I want to manage the sent request feature
so that 
	I could Check the Withdraw and Pending Status of SentRequest

@mytag
	Scenario:Check Sent Request Withdrawn
	Given I click on ManageRequest tab on the Home page
	When I Select SentRequest DropDownlist
	And I click on Withdraw button
	Then Request Status should be Withdrawn

	Scenario:Check Sent Request Completed
	Given I click on ManageRequest tab on the Home page
	And I select SentRequest DropDownlist 
	And if Status is accepted for sent request
	Then click on Completed Button
	