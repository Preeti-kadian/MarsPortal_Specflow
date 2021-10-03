
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerAddLanguageToProfileSteps
    {
        [Given(@"I am on profile page")]
        public void GivenIAmOnProfilePage()
        {

        }

        [Given(@"I click on add new under language")]
        public void GivenIClickOnAddNewUnderLanguage()
        {
        
           ProfileLanguage.AddLanguage();
           
        }
        
        [Given(@"I click on edit icon under language")]
        public void GivenIClickOnEditIconUnderLanguage()
        {
            ProfileLanguage.UpdateLanguage();
        }
        
      
        
        [When(@"I click on delete icon under language")]
        public void WhenIClickOnDeleteIconUnderLanguage()
        {
            ProfileLanguage.DeleteLanguage();
        }
     
            [When(@"I add languages")]
            public void WhenIAddLanguages()
        {
           
        }

        
            [Then(@"I am able to see the added languages")]
            public void ThenIAmAbleToSeeTheAddedLanguages()
        {
            ProfileLanguage.ValidateAddedLanguage();
        }

        [Then(@"delete succesful message displayed")]
        public void ThenDeleteSuccesfulMessageDisplayed()
        {
            ProfileLanguage.DeleteLanguageValidate();
        }
      
           [When(@"I update languages")]
            public void WhenIUpdateLanguages()
        {
            
        }

     
            [Then(@"Update succesful message displayed")]
            public void ThenUpdateSuccesfulMessageDisplayed()
        {
            ProfileLanguage.ValidateUpdatedLanguage();
        }


    }
}
