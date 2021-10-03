Feature: Seller Add EarnTarget to Profile
As a Seller
I want the feature to add earntarget to my Profile Details
So that
The people seeking for some earntarget can look into my details.

@mytag
Scenario: Add EarnTarget to profile
	Given I am on profile page
	And I click on earn target 
	When I select otion from dropdown list 
	Then I add earn target successfully

	@mytag
Scenario: Delete EarnTarget from profile
	Given I am on profile page
	When I click on delete earnTarget  
	Then I delete saved earn target