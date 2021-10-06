using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SentRequestSteps
    {
        ManageRequests reqObj = new ManageRequests();

        [Given(@"I click on ManageRequest tab on the Home page")]
        public void GivenIClickOnManageRequestTabOnTheHomePage()
        {
            reqObj.ManageRequestClick();
        }
        
        [Given(@"I select SentRequest DropDownlist")]
        public void GivenISelectSentRequestDropDownlist()
        {
            reqObj.SentRequestLink();
        }
        
        [Given(@"if Status is accepted for sent request")]
        public void GivenIfStatusIsAcceptedForSentRequest()
        {
          

        }
        
        [When(@"I Select SentRequest DropDownlist")]
        public void WhenISelectSentRequestDropDownlist()
        {
            reqObj.SentRequestLink();

        }
        
        [When(@"I click on Withdraw button")]
        public void WhenIClickOnWithdrawButton()
        {
           
            reqObj.WithdrawRequest();
        }
        
        [Then(@"Request Status should be Withdrawn")]
        public void ThenRequestStatusShouldBeWithdrawn()
        {
            Start.test = Start.extent.StartTest("Withdraw Sent request feature");
            reqObj.ValidateWithdrawRequest();
        }

        [Then(@"click on Completed Button")]
        public void ThenClickOnCompletedButton()
        {
            Start.test = Start.extent.StartTest("Complete Sent request feature");
            reqObj.CompleteRequest();
        }
    }
}




       