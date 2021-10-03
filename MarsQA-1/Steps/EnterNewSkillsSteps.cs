using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class EnterNewSkillsSteps
    {
        [Given(@"I click on Share skill button on Profile page")]
        public void GivenIClickOnShareSkillButtonOnProfilePage()
        {
           
        }
        
        [When(@"I Enter Valid Skills Details")]
        public void WhenIEnterValidSkillsDetails()
        {
            
        }
        
        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            ShareSkill.EnterSkill();
        }
        
        [Then(@"my skills should be saved")]
        public void ThenMySkillsShouldBeSaved()
        {
            
        }
    }
}
