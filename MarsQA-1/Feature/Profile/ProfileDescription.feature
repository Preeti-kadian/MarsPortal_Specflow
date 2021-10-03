Feature: Seller Add Description to profile
As a Seller
I want the feature to add description to my Profile Details
So that
The people seeking for some skills can look into my details.

@mytag
Scenario: Add Description to Profile
	Given I am on profile page
	And I click on description tab
	When I save descpription about myself
	Then I successfully save description


