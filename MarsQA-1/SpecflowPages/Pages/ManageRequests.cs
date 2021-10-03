using MarsFramework.Global;
using MarsQA_1.Helpers;
using MArsQASpecflow.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageRequests
    {
        #region Initialize web elements
        // Manage request tab
        public IWebElement manageRequest => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//section[@class='nav-secondary']/div/div[1]"));

        //Received request
        public IWebElement sentRequest => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//section[@class='nav-secondary']//div[@class='menu transition visible']/a[@href='/Home/SentRequest']"));

        //Sent Requests
        public IWebElement receivedRequest => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//section[@class='nav-secondary']//div[@class='menu transition visible']/a[@href='/Home/ReceivedRequest']"));

        //Accept button in Received request
        public IWebElement acceptButton => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Accept']"));

        //Decline button in Received request
        public IWebElement declineButton => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Decline']"));

        //Withdraw button in Sent request   
        public IWebElement withdrawButton => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Withdraw']"));

        //Complete button for accepted request
        public IWebElement completeButton => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Complete']"));

        //Status message for complete request
        public IWebElement completeStatus => Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));

        //status fore request declined
        public IWebElement declineStatus => Driver.driver.FindElement(By.XPath("//td[normalize-space()='Declined']"));

        //status for request withdrawn
        public IWebElement withdrawStatus => Driver.driver.FindElement(By.XPath("/html//div[@id='sent-request-section']//table/tbody/tr[1]/td[5]"));

        #endregion

        #region Accept receive request
        public void AcceptReceivedRequest()
        {
            //Click on Manage request
            manageRequest.WaitForElementClickable(Driver.driver, 60);
            manageRequest.Click();

            //Click Received request
            receivedRequest.WaitForElementClickable(Driver.driver, 60);
            receivedRequest.Click();

            //Click on accept button
            acceptButton.WaitForElementClickable(Driver.driver, 60);
            acceptButton.Click();

            //Click on complete button
            completeButton.WaitForElementClickable(Driver.driver, 60);
            completeButton.Click();
            Thread.Sleep(2000);

            //Validate request complete
            try
            {
                if (completeStatus.Text == "Request has been updated")
                {
                    Start.test.Log(LogStatus.Pass, "Test Passed, Request completed");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "completed successful");
                }
            }
            catch (Exception ex)
            {
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Assert.Fail("Test Failed, Complete not successful", ex.Message);

            }
        }
        #endregion

        #region Decline Accept Request
        public void DeclineRequest()
        {
            //Click on Manage request
            manageRequest.WaitForElementClickable(Driver.driver, 60);
            manageRequest.Click();

            //Click Received request
            receivedRequest.WaitForElementClickable(Driver.driver, 60);
            receivedRequest.Click();

            //Click on Withdraw button
            declineButton.WaitForElementClickable(Driver.driver, 60);
            declineButton.Click();

            Thread.Sleep(3000);
            Assert.IsTrue(declineStatus.Text == "Declined");

            Driver.TurnOnWait(3);

            Start.test.Log(LogStatus.Pass, "Test Passed, Request declined");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Decline successful");
        }
        #endregion

        #region Withdraw sent request
        public void WithdrawRequest()
        {
            //Click on Manage request
            manageRequest.WaitForElementClickable(Driver.driver, 60);
            manageRequest.Click();

            //Click Sent request
            sentRequest.WaitForElementClickable(Driver.driver, 60);
            sentRequest.Click();

            //Click on withdraw button
            withdrawButton.WaitForElementClickable(Driver.driver, 60);
            withdrawButton.Click();

            //Validate withdrawn request
            Thread.Sleep(3000);
            Assert.IsTrue(withdrawStatus.Text == "Withdrawn");

            Driver.TurnOnWait(4);

            Start.test.Log(LogStatus.Pass, "Test Passed, Request withdrawn");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Withdraw successful");

        }
        #endregion 

    }
}
