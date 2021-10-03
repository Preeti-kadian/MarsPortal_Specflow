using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerAddAvaiabilityToProfileSteps
    {
        [Given(@"I click on availiablity")]
        public void GivenIClickOnAvailiablity()
        {
            
        }
        
        [When(@"I select otion from dropdown list")]
        public void WhenISelectOtionFromDropdownList()
        {
            ProfilePage.SelectAvailibilty();
        }
        
        
        
        [Then(@"I successfully save availability")]
        public void ThenISuccessfullySaveAvailability()
        {
          
        }

        [Then(@"availability delete successful")]
        public void ThenAvailabilityDeleteSuccessful()
        {
           
        }


    }
}
