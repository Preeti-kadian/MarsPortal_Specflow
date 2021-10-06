using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
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
            ShareSkill.ShareSkillLink();
        }
        
        [When(@"I Enter Valid Skills Details")]
        public void WhenIEnterValidSkillsDetails()
        {
            ShareSkill.EnterSkill();
        }
        
        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            Start.test = Start.extent.StartTest("Share Skill feature");
            ShareSkill.SaveSkill();
        }
        
        [Then(@"my skills should be saved")]
        public void ThenMySkillsShouldBeSaved()
        {
            ShareSkill.ValidateShareSkill();
        }
    }
}
