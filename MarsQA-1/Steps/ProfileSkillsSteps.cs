using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;


namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerAddSkillsToProfileSteps
    {
        [Given(@"I click on skills on profile page")]
        public void GivenIClickOnSkillsOnProfilePage()
        {
            ProfileSkills.SkillsTab();
        }
        
        [Given(@"I click on add new under skills")]
        public void GivenIClickOnAddNewUnderSkills()
        {
            ProfileSkills.AddNewSkillButton();
                
        }
        
        [Given(@"I click on edit icon under skills")]
        public void GivenIClickOnEditIconUnderSkills()
        {
            ProfileSkills.EditSkillIcon();
        }
        
        [When(@"I add skills")]
        public void WhenIAddSkills()
        {
            ProfileSkills.AddSkills();
        }
        
        [When(@"I update skills")]
        public void WhenIUpdateSkills()
        {
            ProfileSkills.UpdateSkills();

        }
        
        [When(@"I click on delete icon under skills")]
        public void WhenIClickOnDeleteIconUnderSkills()
        {
            ProfileSkills.DeleteSkills();
        }
        
        [Then(@"I am able to see the added skills")]
        public void ThenIAmAbleToSeeTheAddedSkills()
        {
            Start.test = Start.extent.StartTest("Add skills feature");
            ProfileSkills.ValidateAddSkills();
        }
        
        [Then(@"Update skills successfully")]
        public void ThenUpdateSkillsSuccessfully()
        {
            Start.test = Start.extent.StartTest("Update skills feature");
            ProfileSkills.ValidateUpdateSkills();
        }
        
        [Then(@"delete saved skills successfully")]
        public void ThenDeleteSavedSkillsSuccessfully()
        {
            Start.test = Start.extent.StartTest("Delete skills feature");
            ProfileSkills.ValidateDeleteSkills();
        }
    }
}
