Feature: Seller Add Skills to Profile
As a Seller
I want the feature to add skills to my Profile Details
So that
The people seeking for some skills can look into my details.

@mytag
Scenario: Add Skills in Profile Details
	Given I click on skills on profile page
	And I click on add new under skills
	When I add skills
	Then I am able to see the added skills

@mytag
	Scenario: Update Skills in Profile Details
	Given I am on profile page
	And I click on edit icon under skills
	When I update skills
	Then Update skills successfully

@mytag
	Scenario: Delete Skills in Profile Details
	Given I am on profile page
	When I click on delete icon under skills
	Then delete saved skills successfully
