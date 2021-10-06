using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerAddCertificationToProfileSteps
    {
        ProfileCertification certObj = new ProfileCertification();
        [Given(@"I click on certifications on profile page")]
        public void GivenIClickOnCertificationsOnProfilePage()
        {
            certObj.CertificationTab();

        }
        
        [Given(@"I click on add new under certifications")]
        public void GivenIClickOnAddNewUnderCertifications()
        {
            certObj.AddButton();
                
        }


        [When(@"I add new certification details")]
        public void WhenIAddNewCertificationDetails()
        {
            certObj.AddNewCertificate();
        }
        [Then(@"I am able to see saved certifications")]
        public void ThenIAmAbleToSeeSavedCertifications()
        {
            Start.test = Start.extent.StartTest("Add Certification feature");

            certObj.ValidateAddCertificate();

        }

        [Given(@"I click on edit icon under certification")]
        public void GivenIClickOnEditIconUnderCertification()
        {
            certObj.EditButton();
        }
        
        [Given(@"I click on delete icon under certification")]
        public void GivenIClickOnDeleteIconUnderCertification()
        {
            certObj.DeleteButton();
        }
        
        
        [When(@"I update certification")]
        public void WhenIUpdateCertification()
        {
            certObj.EditCertificate();
        }
        [Then(@"certification updated successfully")]
        public void ThenCertificationUpdatedSuccessfully()
        {
            Start.test = Start.extent.StartTest("Update Certification feature");

            certObj.ValidateUpdateCertficate();
        }

        [When(@"I delete a certification")]
        public void WhenIDeleteACertification()
        {
            certObj.DeleteCertificate();
        }
        
        [Then(@"I successfully delete added certiification")]
        public void ThenISuccessfullyDeleteAddedCertiification()
        {

            Start.test = Start.extent.StartTest("Delete certification feature");

            certObj.ValidateDeleteCertificate();
        }
    }
}
