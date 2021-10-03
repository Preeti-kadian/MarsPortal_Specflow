Feature: Seller Add Education Details
As a Seller
I want the feature to add education to my Profile Details
So that
The people seeking for some education can look into my details.

@mytag
Scenario: Add Education in Profile Details
	Given I click on education on profile page
	And I click on add new under education
	When I add eductaion details
	Then I am able to see the saved education

@mytag
	Scenario: Update Education in Profile Details
	Given I am on profile page
	And I click on edit icon under education
	When I update education
	Then Update succesful message displayed

@mytag
	Scenario: Delete Education in Profile Details
	Given I am on profile page
	When I click on delete icon under education
	Then delete succesful message displayed