using MarsQA_1.SpecflowPages.Pages;
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
          
        }
        
        [Given(@"I click on add new under skills")]
        public void GivenIClickOnAddNewUnderSkills()
        {
            ProfileSkills.AddSkills();
        }
        
        [Given(@"I click on edit icon under skills")]
        public void GivenIClickOnEditIconUnderSkills()
        {
            
        }
        
        [When(@"I add skills")]
        public void WhenIAddSkills()
        {
            
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
            ProfileSkills.ValidateAddSkills();
        }
        
        [Then(@"Update skills successfully")]
        public void ThenUpdateSkillsSuccessfully()
        {
            ProfileSkills.ValidateUpdateSkills();
        }
        
        [Then(@"delete saved skills successfully")]
        public void ThenDeleteSavedSkillsSuccessfully()
        {
            ProfileSkills.ValidateDeleteSkills();
        }
    }
}
