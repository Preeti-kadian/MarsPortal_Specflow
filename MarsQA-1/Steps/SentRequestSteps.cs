using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SentRequestSteps
    {
        ManageRequests reqObj = new ManageRequests();
        [Given(@"I click on ManageRequest tab on Home page")]
        public void GivenIClickOnManageRequestTabOnHomePage()
        {
        }

        
        [Given(@"I Select SentRequest DropDown")]
        public void GivenISelectSentRequestDropDown()
        {
           
        }
        
        
        
        [Given(@"if the Status is accepted for sent request")]
        public void GivenIfTheStatusIsAcceptedForSentRequest()
        {
            reqObj.AcceptReceivedRequest();

        }
        
        [Given(@"I click ManageRequest tab")]
        public void GivenIClickManageRequestTab()
        {
            
        }
        
        [Given(@"if the Status is Completed")]
        public void GivenIfTheStatusIsCompleted()
        {
            
        }
        
        [Given(@"if the Status is Declined the Request is Declined")]
        public void GivenIfTheStatusIsDeclinedTheRequestIsDeclined()
        {
            reqObj.DeclineRequest();
        }
        
        [When(@"I Select SentRequest DropDown")]
        public void WhenISelectSentRequestDropDown()
        {
           
        }
        
        [When(@"I click on withdraw button")]
        public void WhenIClickOnWithdrawButton()
        {
            
        }
        
        [Then(@"Check if the receiver has not accepted the request then, Status will be pending\.")]
        public void ThenCheckIfTheReceiverHasNotAcceptedTheRequestThenStatusWillBePending_()
        {
            
        }
        
        [Then(@"the Status should be Withdrawn")]
        public void ThenTheStatusShouldBeWithdrawn()
        {
            
        }

        [Then(@"Click on Completed Button")]
        public void ThenClickOnCompletedButton()
        {
        }

        
        [Then(@"I click on Review Button")]
        public void ThenIClickOnReviewButton()
        {
            
        }
        
        [Then(@"I Add Review Text and Ratings and Save\.")]
        public void ThenIAddReviewTextAndRatingsAndSave_()
        {
            
        }
    }
}
