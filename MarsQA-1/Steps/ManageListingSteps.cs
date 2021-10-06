using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
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
            ManageListings.ManageListingLink();
        }
        
        [When(@"I Check on ActiveService")]
        public void WhenICheckOnActiveService()
        {
            ManageListings.ViewListing();
        }
        
        [When(@"I click on view listings button")]
        public void WhenIClickOnViewListingsButton()
        {
            ManageListings.ViewListing();
        }
        
        [When(@"I click Edit Icon which Navigates to Share Skill Page")]
        public void WhenIClickEditIconWhichNavigatesToShareSkillPage()
        {
            ManageListings.EditListingIcon();
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
            Start.test = Start.extent.StartTest("View Skill feature");
            ManageListings.ValidateViewListing();
        }
        
        [Then(@"Click on View Icon in Manage Listing page to see the changes\.")]
        public void ThenClickOnViewIconInManageListingPageToSeeTheChanges_()
        {
            Start.test = Start.extent.StartTest("Edit listing feature");
            ManageListings.EditListingIcon();

        }
        
        [Then(@"I should be able to delete the Skill")]
        public void ThenIShouldBeAbleToDeleteTheSkill()
        {
            Start.test = Start.extent.StartTest("Delete Skill feature");
            ManageListings.ValidateDeleteListing();
        }
        
        [Then(@"I should get an alert for deletion")]
        public void ThenIShouldGetAnAlertForDeletion()
        {
            
           ManageListings.DeleteAlert();

        }
    }
}
