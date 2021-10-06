using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
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
            ProfileEducation.ProfileEducationTab();
                
        }
        
        [Given(@"I click on add new under education")]
        public void GivenIClickOnAddNewUnderEducation()
        {
            ProfileEducation.AddNewLink();
        }
        
        [Given(@"I click on edit icon under education")]
        public void GivenIClickOnEditIconUnderEducation()
        {
            ProfileEducation.EditLink();
        }
        
        [When(@"I add eductaion details")]
        public void WhenIAddEductaionDetails()
        {
           
            ProfileEducation.AddEducation();
        }
        
        [When(@"I update education")]
        public void WhenIUpdateEducation()
        {
            Start.test = Start.extent.StartTest("Update Education feature");
            ProfileEducation.UpdateEducation();
        }
        
        [When(@"I click on delete icon under education")]
        public void WhenIClickOnDeleteIconUnderEducation()
        {
            Start.test = Start.extent.StartTest("Delete Education feature");
            ProfileEducation.DeleteEducation();
        }
        
        [Then(@"I am able to see the saved education")]
        public void ThenIAmAbleToSeeTheSavedEducation()
        {
            Start.test = Start.extent.StartTest("Add Education feature");
            ProfileEducation.ValidateAddEducation();   
        }
    }
}
