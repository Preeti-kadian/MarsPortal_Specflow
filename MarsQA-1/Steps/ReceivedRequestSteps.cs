using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ReceivedRequestSteps
    {
        ManageRequests reqObj = new ManageRequests();
        [Given(@"I click on Manage Request")]
        public void GivenIClickOnManageRequest()
        {
            reqObj.ManageRequestClick();
        }
        
        [Given(@"I have received a new request")]
        public void GivenIHaveReceivedANewRequest()
        {
            Start.test = Start.extent.StartTest("Received request feature");
            reqObj.WithdrawRequest();
        }
        
      
        [When(@"I click on the received request menu option")]
        public void WhenIClickOnTheReceivedRequestMenuOption()
        {
            reqObj.ReceievedRequestLink();
        }
        
        [When(@"I Accept the new request")]
        public void WhenIAcceptTheNewRequest()
        {
            Start.test = Start.extent.StartTest("accept request feature");
            reqObj.AcceptReceivedRequest();
        }
        
        [When(@"I click on the Complete button\.")]
        public void WhenIClickOnTheCompleteButton_()
        {
            Start.test = Start.extent.StartTest("Complete request feature");
            reqObj.CompleteRequest();
        }
        
        
        
        [Then(@"I should see the Accepted status on the request status")]
        public void ThenIShouldSeeTheAcceptedStatusOnTheRequestStatus()
        {
            Start.test = Start.extent.StartTest("Accept request feature");
           reqObj.ValidateAcceptRequest();
        }

        [When(@"I Decline the new request")]
        public void WhenIDeclineTheNewRequest()
        {
            Start.test = Start.extent.StartTest("Delete request feature");
            reqObj.DeclineRequest();

        }

        [Then(@"I should see the Declined status on the request status")]
        public void ThenIShouldSeeTheDeclinedStatusOnTheRequestStatus()
        {

            reqObj.ValidateDeclineRequest();
        }

    }
}
