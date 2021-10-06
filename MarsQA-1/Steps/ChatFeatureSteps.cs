using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ChatFeatureSteps
    {
       
        Chat chatObj = new Chat();
        [Given(@"I click on Chat icon on Home page")]
        public void GivenIClickOnChatIconOnHomePage()
        {
            Start.test = Start.extent.StartTest("Chat feature");
            chatObj.ChatIcon();
        }
        
        [Given(@"I select the user")]
        public void GivenISelectTheUser()
        {
            chatObj.ChatRoomSearch();
            chatObj.ValidateChatRoom();
        }
        
        [When(@"I type the message and Click on Send button")]
        public void WhenITypeTheMessageAndClickOnSendButton()
        {
            chatObj.ChatFeature();
           
        }
        
        [Then(@"message sent succesfully to other user\.")]
        public void ThenMessageSentSuccesfullyToOtherUser_()
        {
            chatObj.ValidateChatFeature();
        }
    }
}
