using MarsQA_1.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class LoginSteps 
    {
        [Given(@"I click on signin button on Login page")]
        public void GivenIClickOnSigninButtonOnLoginPage()
        {
            SignIn.ClickSignInBtn();
        }
        
        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            SignIn.ClickSignInBtn();

        }
        
       [Then(@"I login to my profile successfully\.")]
        public void ThenILoginToMyProfileSuccessfully_()
        {
            Start.test = Start.extent.StartTest("Login feature");
            MarsQA_1.Pages.SignIn.SigninStep();
        }
        
        [Then(@"I should not be logged in\.")]
        public void ThenIShouldNotBeLoggedIn_()
        {
            Start.test = Start.extent.StartTest("Login with invalid credentialsfeature");
            MarsQA_1.Pages.SignIn.InvalidLogin();
        }

   
    
        [When(@"I enter valid Iname and valid password credentials")]
          public void WhenIEnterValidInameAndValidPasswordCredentials()
        {
            SignIn.InvalidLogin();
        }

        [Given(@"I click on login button")]
        public void GivenIClickOnLoginButton()
        {
            SignIn.ClickSignInBtn();
        }

        [When(@"I enter invalid Iname and valid password")]
        public void WhenIEnterInvalidInameAndValidPassword()
        {
            Start.test = Start.extent.StartTest("Login invalid credentials feature");
            SignIn.InvalidLoginButton();
        }






    }
}
