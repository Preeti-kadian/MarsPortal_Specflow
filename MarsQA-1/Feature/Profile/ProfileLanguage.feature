Feature: Seller Add Language to Profile
As a Seller
I want the feature to add language to my Profile Details
So that
The people seeking for some language skills can look into my details.

@mytag
Scenario: Add Languages in Profile Details
	Given I am on profile page
	And I click on add new under language
	When I add languages 
	Then I am able to see the added languages

@mytag
	Scenario: Update Languages in Profile Details
	Given I am on profile page
	And I click on edit icon under language
	When I update languages 
	Then Update succesful message displayed

@mytag
	Scenario:Delete Languages in Profile Details
	Given I am on profile page
	When I click on delete icon under language
	Then delete succesful message displayed