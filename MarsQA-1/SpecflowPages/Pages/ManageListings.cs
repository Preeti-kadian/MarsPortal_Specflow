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
    public static class ManageListings
    {
        //Manage listing link
        private static IWebElement manageListingsLink => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Manage Listings']"));
        //View icon
        private static IWebElement view => Driver.driver.FindElement(By.XPath("/html//div[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i[@class='eye icon']"));
       //Delete icon
        private static IWebElement delete => Driver.driver.FindElement(By.XPath("//i[@class='remove icon']"));
        //Edit button/Icon
        private static IWebElement edit => Driver.driver.FindElement(By.XPath("/html//div[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        //Click on Yes or No
        private static IWebElement clickActionsButton => Driver.driver.FindElement(By.XPath("//div[@class='actions']"));
       //Yes button
        private static IWebElement clickYesButton => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
       //No button
        private static IWebElement clickNoButton => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));
       //Category type button
        private static IWebElement categoryType => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
       //title of the page
        private static IWebElement titleText => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        //Select Description for the top row
        private static IWebElement descriptionText => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));

        //Delete confirmation  Message
        private static IWebElement messageDisplay => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/h3"));
        //Enter the Title in textbox
        private static IWebElement title => Driver.driver.FindElement(By.Name("title"));
        //Enter the Description in textbox
        private static IWebElement description => Driver.driver.FindElement(By.Name("description"));
        // Save button
        private static IWebElement Save => Driver.driver.FindElement(By.XPath("//input[@value='Save']"));

        private static IWebElement languageTab => Driver.driver.FindElement(By.XPath(""));


        #region Edit service listings
        public static void EditServiceListing()
        {
            //Click on ManageListing Link
            manageListingsLink.WaitForElementClickable(Driver.driver, 60);
            manageListingsLink.Click();

            //Click on edit service Icon
            edit.WaitForElementClickable(Driver.driver, 60);
            edit.Click();

            //Populate the excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListings");

            Thread.Sleep(2000);
            //Edit the title and read from Excel
            title.Clear();
            Thread.Sleep(2);
            title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));

            //Enter Description
            description.Clear();
            Thread.Sleep(2);
            description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            //Click on Save listing button
            Save.WaitForElementClickable(Driver.driver, 60);
            Save.Click();

            #region Validate edit service listing functionality

            Thread.Sleep(2);
            string expectedTitle = "Software Testing";
            string expectedDescription = "Experience in both Manual and Automatic Testing";

            try
            {
                //Start the Reports

                Thread.Sleep(1000);
                Start.test = Start.extent.StartTest("Edit a Service Listing");
                Start.test.Log(LogStatus.Info, "Editing a listing");
                titleText.WaitForElementClickable(Driver.driver, 60);

                //Verify if expected value and actual values are same for Title and description content
                Assert.IsTrue((titleText.Text == expectedTitle && descriptionText.Text == expectedDescription));
                Thread.Sleep(2000);
                Start.test.Log(LogStatus.Pass, "Test Passed, Service listing edited Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsEditedSuccessfully");
                Assert.IsTrue(true);
            }

            catch (Exception ex)
            {
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Console.WriteLine(ex.Message);
            }

            #endregion


        }
        #endregion

        #region View service Listing
        public static void ViewListing()
        {

            //Click on ManageListing Link
            manageListingsLink.WaitForElementClickable(Driver.driver, 60);
            manageListingsLink.Click();

            //Click on View Listing icon
            view.WaitForElementClickable(Driver.driver, 60);
            view.Click();

            //Validate view listing feature
            Driver.TurnOnWait(3);
            string actualPageTitle = Driver.driver.Title;
            string expectedPageTitle = "Service Detail";

            try
            {
                //Start the Reports

                Start.test = Start.extent.StartTest("View a Service Listing");
                Start.test.Log(LogStatus.Info, "View listing");
                Driver.TurnOnWait(2);
                //verify if actual and expected page title are same
                Assert.AreEqual(actualPageTitle, expectedPageTitle);
                Driver.TurnOnWait(2);
                Start.test.Log(LogStatus.Pass, "Test Passed, Service listing viewed");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "ViewSuccessfully");
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Driver.TurnOnWait(2);
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Assert.Fail("Test Failed, Skill not viewed", ex.Message);
            }
        }
        #endregion

        #region Delete Service Listing
        public static void DeleteListings()
        {

            //wait for element to be clickable
            manageListingsLink.WaitForElementClickable(Driver.driver, 60);
            //click on Manage listing Link
            manageListingsLink.Click();

            //click on delete link
            delete.WaitForElementClickable(Driver.driver, 60);
            delete.Click();

            //Wait for Click Yes button element
            clickYesButton.WaitForElementClickable(Driver.driver, 60);
            //Confirm Delete operation
            clickYesButton.Click();


            #region Validate delete listings functionality

            Thread.Sleep(5000);
            //wait for TitleText to be clickable
            string actualMessageDisplay = "You do not have any service listings!";
            string expectedMessageDisplay = messageDisplay.Text;

            try
            {
                //Start the Reports

                Driver.TurnOnWait(2);
                Start.test = Start.extent.StartTest("Delete a Service Listing");
                Start.test.Log(LogStatus.Info, "Delete a listing");
                Thread.Sleep(2000);
                //verify if skill listing is deleted deleted 
                Assert.AreEqual(actualMessageDisplay, expectedMessageDisplay);

               Start. test.Log(LogStatus.Pass, "Test Passed, Service listing deleted Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsdeleteSuccessful");
                Assert.IsTrue(true);

            }

            catch (Exception ex)
            {
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Console.WriteLine(ex.Message);
            }


            #endregion

        }
        #endregion
    }
}

