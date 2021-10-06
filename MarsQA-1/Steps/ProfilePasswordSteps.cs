using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature.Profile
{
    [Binding]
    public class ProfilePasswordSteps
    {
        [Given(@"the user is on Profile tab")]
        public void GivenTheUserIsOnProfileTab()
        {
            ProfilePage.ProfileTab();
        }
        
        [Given(@"the user Clicks on User tab and changepassword link")]
        public void GivenTheUserClicksOnUserTabAndChangepasswordLink()
        {
            ProfilePage.UserNameLink();
            ProfilePage.PasswordLink();
            
        }
        
        [Given(@"the user inputs current password,new password and confirmpassword")]
        public void GivenTheUserInputsCurrentPasswordNewPasswordAndConfirmpassword()
        {
            ProfilePage.EnterNewPassword();
        }
        
        [Given(@"Clicks on save button the details are saved")]
        public void GivenClicksOnSaveButtonTheDetailsAreSaved()
        {
            ProfilePage.SavePassword();
        }
    }
}
