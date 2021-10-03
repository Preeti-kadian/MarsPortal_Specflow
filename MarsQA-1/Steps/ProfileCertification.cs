using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerAddCertificationToProfileSteps
    {
        [Given(@"I click on certifications on profile page")]
        public void GivenIClickOnCertificationsOnProfilePage()
        {
            
        }
        
        [Given(@"I click on add new under certifications")]
        public void GivenIClickOnAddNewUnderCertifications()
        {
            
        }
        
        [Given(@"I click on edit icon under certification")]
        public void GivenIClickOnEditIconUnderCertification()
        {
            
        }
        
        [Given(@"I click on delete icon under certification")]
        public void GivenIClickOnDeleteIconUnderCertification()
        {
            
        }
        
        [When(@"I add new certification details")]
        public void WhenIAddNewCertificationDetails()
        {
            
        }
        
        [When(@"I update certification")]
        public void WhenIUpdateCertification()
        {
            
        }
        
        [When(@"I delete a certification")]
        public void WhenIDeleteACertification()
        {
            
        }
        
        [Then(@"I am able to see saved certifications")]
        public void ThenIAmAbleToSeeSavedCertifications()
        {
            ProfileCertification certObj = new ProfileCertification();
            certObj.AddNewCertificate();

        }
        
        [Then(@"certification updated successfully")]
        public void ThenCertificationUpdatedSuccessfully()
        {
            ProfileCertification certObj = new ProfileCertification();
            certObj.EditCertificate();
        }
        
        [Then(@"I successfully delete added certiification")]
        public void ThenISuccessfullyDeleteAddedCertiification()
        {
            ProfileCertification certObj = new ProfileCertification();
            certObj.DeleteCertificate();
        }
    }
}
