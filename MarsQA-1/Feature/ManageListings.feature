Feature: ManageListing
	As a user
	I want the feature to allow manage listings 
	So that
	The user is able to View, Edit and Delete listings.

	@mytag
	Scenario: Check if View Skill In Manage Listing Page is successful
	Given I have Navigated to Manage Listing Page
	When   I Check on ActiveService
	And  I click on view listings button
	Then I should be able to view the service listing details. 

    @mytag
    Scenario: Check if Edit Skill In Manage Listing Page is successful
	Given I have Navigated to Manage Listing Page
	When  I Check on ActiveService
	And  I click Edit Icon which Navigates to Share Skill Page   
	And  I edit the fields and Click on Save Button
	Then Click on View Icon in Manage Listing page to see the changes.

	@mytag
	Scenario: Check if Delete Skill In Manage Listing Page is successful
	When I Click on Delete Icon 
	Then I should be able to delete the Skill 
	And I should get an alert for deletion 
	

	