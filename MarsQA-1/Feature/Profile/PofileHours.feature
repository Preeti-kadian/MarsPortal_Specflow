Feature: Seller Add Hours to Profile
As a Seller
I want the feature to add hours to my Profile Details
So that
The people seeking for some skills can look into my details.


@mytag
Scenario: Add Hours to profile
	Given I am on profile page
	And I click on hours
	When I select otion from dropdown list 
	Then I successfully add hours
	

@mytag
Scenario: Delete Hours to profile
	Given I am on profile page
	When I click on delete hours icon
	Then I successfully delete hours
