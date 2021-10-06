using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
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
            ProfilePage.SelectAvailibilty();
        }
        
        [When(@"I select otion from dropdown list")]
        public void WhenISelectOtionFromDropdownList()
        {
            ProfilePage.SelectAvailabilityDrop();
                
        }
        
        [Then(@"I successfully save availability")]
        public void ThenISuccessfullySaveAvailability()
        {
            Start.test = Start.extent.StartTest("Profile Availability feature");
            ProfilePage.SelectAvailibilty();
        }

        [Then(@"availability delete successful")]
        public void ThenAvailabilityDeleteSuccessful()
        {
            Start.test = Start.extent.StartTest("Profile Availability Delete feature");
            ProfilePage.DeleteAvailability();
        }

        [When(@"I click on delete availiablity icon")]
        public void WhenIClickOnDeleteAvailiablityIcon()
        {
            
        }


    }
}
