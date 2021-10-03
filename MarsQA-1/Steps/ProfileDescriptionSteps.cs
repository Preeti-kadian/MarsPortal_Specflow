using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SellerAddDescriptionToProfileSteps
    {
        [Given(@"I click on description tab")]
        public void GivenIClickOnDescriptionTab()
        {
            ProfilePage.SaveDescription();
        }
        
        [When(@"I save descpription about myself")]
        public void WhenISaveDescpriptionAboutMyself()
        {
            
        }
        
        [Then(@"I successfully save description")]
        public void ThenISuccessfullySaveDescription()
        {
            
        }
    }
}
