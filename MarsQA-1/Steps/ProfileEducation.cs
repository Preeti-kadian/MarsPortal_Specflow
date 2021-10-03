using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerAddEducationDetailsSteps
    {
        [Given(@"I click on education on profile page")]
        public void GivenIClickOnEducationOnProfilePage()
        {
            
        }
        
        [Given(@"I click on add new under education")]
        public void GivenIClickOnAddNewUnderEducation()
        {
            
        }
        
        [Given(@"I click on edit icon under education")]
        public void GivenIClickOnEditIconUnderEducation()
        {
           
        }
        
        [When(@"I add eductaion details")]
        public void WhenIAddEductaionDetails()
        {
            ProfileEducation.AddEducation();
        }
        
        [When(@"I update education")]
        public void WhenIUpdateEducation()
        {
            ProfileEducation.UpdateEducation();
        }
        
        [When(@"I click on delete icon under education")]
        public void WhenIClickOnDeleteIconUnderEducation()
        {
            ProfileEducation.DeleteEducation();
        }
        
        [Then(@"I am able to see the saved education")]
        public void ThenIAmAbleToSeeTheSavedEducation()
        {
            
        }
    }
}
