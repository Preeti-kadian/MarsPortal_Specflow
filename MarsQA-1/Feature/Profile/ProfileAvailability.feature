Feature: Seller Add Avaiability to Profile
As a Seller
I want the feature to add availability to my Profile Details
So that
The people seeking for some availablity can look into my details.

@mytag
Scenario: Add Availablity to profile
	Given I am on profile page
	And I click on availiablity 
	When I select otion from dropdown list 
	Then I successfully save availability


@mytag
Scenario: Delete Availablity from profile
	Given I am on profile page
	When I click on delete availiablity icon
	Then availability delete successful