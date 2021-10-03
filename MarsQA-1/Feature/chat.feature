Feature: Seller uses chat feature
As a Seller
I want the feature to verify chat feature 
So that
The people using chat can communicate to other user. 


@mytag
Scenario: Verify if chat with other users is successful
	Given I click on Chat icon on Home page
	And I select the user
	When I type the message and Click on Send button
	Then message sent succesfully to other user. 