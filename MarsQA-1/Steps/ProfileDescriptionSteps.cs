using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
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

            ProfilePage.EditDescriptionTab();
        }
        
        [When(@"I save descpription about myself")]
        public void WhenISaveDescpriptionAboutMyself()
        {
            ProfilePage.SaveDescription();
        }
        
        [Then(@"I successfully save description")]
        public void ThenISuccessfullySaveDescription()
        {
            Start.test = Start.extent.StartTest("Profile description feature");
            ProfilePage.ValidateSaveDescription();
        }
    }
}
