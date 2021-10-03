Feature: Seller Enter new skills to the listings
As a Seller
I want the feature to add new skills to my Profile 
So that
The people seeking for same skill can look into my Profile.


@mytag
Scenario: Enter new skill
	Given I click on Share skill button on Profile page
	When I Enter Valid Skills Details
	And I click on Save button
	Then my skills should be saved