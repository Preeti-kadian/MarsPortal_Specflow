Feature: Seller is able to see notifications
As a Seller
I want the feature to display notifications
So that
The people can navigate, view, select and delete notifications


	@mytag
Scenario: Check if "Notification"->"Mark all as read" is clickable
	Given I Clicks on the Notification button
	When I Clicks on the Mark all as read button
	Then The numbers of notification should be Cleared	

	@mytag
Scenario: Check if "Notification"->"See all" is clickable
	Given I Clicks on the Notification button
	When  I Clicks on the See all button
	Then The I should be able to navigate to the dashboard Page

	@mytag
Scenario: Check if "Load more" is clickable
	Given I Clicks on the Notification button
	And I Clicks on the See all button
	When I Clicks on the Load More button
	Then The Show Less button should be displayed	

	@mytag
Scenario: Check if "Show Less" is clickable
	Given I Clicks on the Notification button
	And I Clicks on the See all button
	And I Clicks on the Load More button
	When I Clicks on the Show Less button
	Then The Show Less button should be not displayed

	@mytag
Scenario: Check if user is able to delete single notification
	Given I Clicks on the Notification button
	And I Clicks on the See all button
	And I Ticks a notification Item
	When I Clicks on the Delete Selection icon
	Then The notification Item should be deleted

	@mytag
Scenario: Check if user is able to delete all notifications
	Given I Clicks on the Notification button
	And Clicks on the See all button
	And  Clicks on Select All icon
	When I Clicks on the Delete Selection icon
	Then All of the notification items should be deleted

	@mytag
Scenario: Check if user is able to click on Select All
	Given I Clicks on the Notification button
	And Clicks on the See all button
	When Clicks on Select all
	Then All notifications should be selected

	@mytag
Scenario: Check if user is able to click on Unselect all when all notifications are selected
	Given I Clicks on the Notification button
	And Clicks on the See all button
	And Clicks on Select all
	When Clicks on Unselect all
	Then All notifications should be unselected