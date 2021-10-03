Feature: SearchSkill
	As a user 
	I want the feature to filter my search 
	so that 
	I am able to find specific skills posted by others matching to my search criteria. 

@mytag
Scenario: Check if skill search is refined by Seller name
	Given I click on Search skills on home page
	When I type in seller name in search user box
	And I click on search icon 
	Then refined search of seller name as result should be displayed.

	@mytag
Scenario: Check if skill search is refined by Category
	Given I click on Search skills on home page
	When I type in skills category in search box
	And I click on search category icon 
	Then refined category list should be displayed.