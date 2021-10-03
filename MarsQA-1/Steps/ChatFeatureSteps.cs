using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ChatFeatureSteps
    {
        [Given(@"I click on Chat icon on Home page")]
        public void GivenIClickOnChatIconOnHomePage()
        {
            
        }
        
        [Given(@"I select the user")]
        public void GivenISelectTheUser()
        {
           
        }
        
        [When(@"I type the message and Click on Send button")]
        public void WhenITypeTheMessageAndClickOnSendButton()
        {
            Chat chatObj = new Chat();
            //chatObj.ChatFeature();
            chatObj.ChatRoomSearch();

        }
        
        [Then(@"message sent succesfully to other user\.")]
        public void ThenMessageSentSuccesfullyToOtherUser_()
        {
           
        }
    }
}
