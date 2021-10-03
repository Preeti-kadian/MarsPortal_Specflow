using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ManageListingSteps
    {
        [Given(@"I have Navigated to Manage Listing Page")]
        public void GivenIHaveNavigatedToManageListingPage()
        {
            
        }
        
        [When(@"I Check on ActiveService")]
        public void WhenICheckOnActiveService()
        {
            
        }
        
        [When(@"I click on view listings button")]
        public void WhenIClickOnViewListingsButton()
        {
            ManageListings.ViewListing();
        }
        
        [When(@"I click Edit Icon which Navigates to Share Skill Page")]
        public void WhenIClickEditIconWhichNavigatesToShareSkillPage()
        {
            
        }
        
        [When(@"I edit the fields and Click on Save Button")]
        public void WhenIEditTheFieldsAndClickOnSaveButton()
        {
            ManageListings.EditServiceListing();
        }

        [When(@"I Click on Delete Icon")]
        public void WhenIClickOnDeleteIcon()
        {
            ManageListings.DeleteListings();
        }
        
        [Then(@"I should be able to view the service listing details\.")]
        public void ThenIShouldBeAbleToViewTheServiceListingDetails_()
        {

        }
        
        [Then(@"Click on View Icon in Manage Listing page to see the changes\.")]
        public void ThenClickOnViewIconInManageListingPageToSeeTheChanges_()
        {
            
        }
        
        [Then(@"I should be able to delete the Skill")]
        public void ThenIShouldBeAbleToDeleteTheSkill()
        {
            
        }
        
        [Then(@"I should get an alert for deletion")]
        public void ThenIShouldGetAnAlertForDeletion()
        {
            
        }
    }
}
