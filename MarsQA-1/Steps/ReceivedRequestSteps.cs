using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ReceivedRequestSteps
    {
        ManageRequests reqObj = new ManageRequests();
        [Given(@"I click on Manage Request")]
        public void GivenIClickOnManageRequest()
        {
           
        }
        
        [Given(@"I have received a new request")]
        public void GivenIHaveReceivedANewRequest()
        {
            reqObj.WithdrawRequest();
        }
        
        [Given(@"I received a new request")]
        public void GivenIReceivedANewRequest()
        {
            
        }
        
        [When(@"I click on the received request menu option")]
        public void WhenIClickOnTheReceivedRequestMenuOption()
        {
           
        }
        
        [When(@"I Accept the new request")]
        public void WhenIAcceptTheNewRequest()
        {
            
        }
        
        [When(@"I click on the Complete button\.")]
        public void WhenIClickOnTheCompleteButton_()
        {
            
        }
        
        [When(@"I Decline the new request")]
        public void WhenIDeclineTheNewRequest()
        {
           
        }
        
        [Then(@"I should see the Accepted status on the request status")]
        public void ThenIShouldSeeTheAcceptedStatusOnTheRequestStatus()
        {
           
        }
        
        [Then(@"I should see the Declined status on the request status")]
        public void ThenIShouldSeeTheDeclinedStatusOnTheRequestStatus()
        {
           
        }
    }
}
