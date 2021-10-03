Feature: Seller Add Certification to Profile
As a Seller
I want the feature to add certfication to my Profile Details
So that
The people seeking for some certification can look into my details.

@mytag
Scenario: Add Certification in Profile Details
	Given I click on certifications on profile page
	And I click on add new under certifications
	When I add new certification details
	Then I am able to see saved certifications

@mytag
	Scenario: Update Certifications in Profile Details
	Given I am on profile page
	And I click on edit icon under certification
	When I update certification 
	Then certification updated successfully

@mytag
	Scenario: Delete Certifications in Profile Details
	Given I am on profile page
	And I click on delete icon under certification
	When I delete a certification 
	Then I successfully delete added certiification
