Feature: Profile Password

@mytag
Scenario: Change Password in Profile Page
Given the user is on Profile tab
And the user Clicks on User tab and changepassword link
And the user inputs current password,new password and confirmpassword
And Clicks on save button the details are saved