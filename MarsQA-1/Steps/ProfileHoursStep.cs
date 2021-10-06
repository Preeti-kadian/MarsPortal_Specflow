using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfileHoursStep
    {
        [Given(@"I click on hours")]
        public void GivenIClickOnHours()
        {
            ProfilePage.AddHours();
        }
        
        [Then(@"I successfully add hours")]
        public void ThenISuccessfullyAddHours()
        {
            Start.test = Start.extent.StartTest("Profile available hours feature");
            ProfilePage.ValidateAddHours();
        }
    }
}
