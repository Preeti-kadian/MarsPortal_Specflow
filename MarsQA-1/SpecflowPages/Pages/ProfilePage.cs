using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;
using MArsQASpecflow.SpecflowPages.Utils;
using RelevantCodes.ExtentReports;
using MarsFramework.Global;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfilePage
    {

        private static IWebElement profileTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
        private static IWebElement description => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private static IWebElement languages => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));

        private static IWebElement education => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private static IWebElement certifications => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private static IWebElement earnTarget => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));

        //Description details
        private static IWebElement editDescriptionIcon = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private static IWebElement descriptionText => Driver.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
        private static IWebElement descriptionSave => Driver.driver.FindElement(By.XPath("//button[@type='button']"));

        //Availability functionality
        private static IWebElement availability => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private static IWebElement selectAvailability => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
        private static IWebElement cancelAvaialbility => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));

        //Hours details
        private static IWebElement hours => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private static IWebElement selectAvailabilityHours => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
        private static IWebElement cancelHours => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));

        //Password details
        #region Password Change web elements
        //Account holder name
        private static IWebElement userName => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/div[1]/div[2]/div/span"));

        //change password link    3
        /// <summary>
        /// 
        /// </summary>
        private static IWebElement changePasswordLink => Driver.driver.FindElement(By.LinkText("Change Password"));

        //current password text box
        private static IWebElement currentPassword => Driver.driver.FindElement(By.XPath("//body[@class='dimmable dimmed']/div[4]//form//input[@name='oldPassword']"));

        //new password text box
        private static IWebElement newPassword => Driver.driver.FindElement(By.XPath("//body[@class='dimmable dimmed']/div[4]//form//input[@name='newPassword']"));

        //confirm password text box
        private static IWebElement confirmPassword => Driver.driver.FindElement(By.XPath("//body[@class='dimmable dimmed']/div[4]//form//input[@name='confirmPassword']"));
        
        //Account holder name
        private static IWebElement savePassword => Driver.driver.FindElement(By.XPath("//body[@class='dimmable dimmed']/div[4]//form//button[@role='button']"));

        #endregion

        public static void ProfileTab()
        {
            profileTab.WaitForElementClickable(Driver.driver, 30).Click();
        }

        public static void EditDescriptionTab()
        {
            
            editDescriptionIcon.WaitForElementClickable(Driver.driver, 40).Click();
        }
        // Save Description
        public static void SaveDescription()
        {
            
            descriptionText.WaitForElementClickable(Driver.driver, 30);
          
            //Read description from Excel file
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Description");
            Thread.Sleep(1000);
            descriptionText.Clear();
            Thread.Sleep(2000);
            descriptionText.SendKeys(ExcelLibHelper.ReadData(2, "Description"));
           
           
        }

        public static void ValidateSaveDescription()
        {
            //Save description added from Excel
            descriptionSave.WaitForElementClickable(Driver.driver, 40).Click();
            Thread.Sleep(2000);
            
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles.Last());
            // verify Description is save successfully 
            Assert.AreEqual(Driver.driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Description has been saved successfully");
            Driver.driver.SwitchTo().DefaultContent();

        }


        //Add Availability
        public static void SelectAvailibilty()
        {
            //Click on edit availablity
            availability.Click();
        }
        public static void SelectAvailabilityDrop()
        {
            //Select options from dropdown list
            SelectElement dropSelectAvailability = new SelectElement(selectAvailability);
            Random rnd = new Random();
            int count = rnd.Next(1, 2);
            dropSelectAvailability.SelectByIndex(count);
            Thread.Sleep(3000);
        }

        public static void ValidateProfileAvailability()
        {
            try
            {
                SelectAvailabilityDrop();
               Start.test.Log(LogStatus.Pass, "Added Availability successfully");
               SaveScreenShotClass.SaveScreenshot(Driver.driver, "Availability updated");

            }

            catch (Exception ex)
            {
                //Start.test.Log(LogStatus.Fail, "Test failed");
               Console.WriteLine("Test Failed, Availability not set", ex.Message);

            }


        }
        public static void DeleteAvailability()
        {
            cancelAvaialbility.WaitForElementClickable(Driver.driver, 40).Click();
        }

        public static  void AddHours()
        {
            hours.WaitForElementClickable(Driver.driver, 60).Click();
        }

        //Add Hours
        public static void ValidateAddHours()
        {
            //Click on add hours icon 
           
            Thread.Sleep(3000);
           
            try
            {

                //Select available hours option
             
                SelectElement dropAvailabilityHours = new SelectElement(selectAvailabilityHours);
                Random rnd = new Random();
                int count = rnd.Next(1, 3);
                Thread.Sleep(2000);
                dropAvailabilityHours.SelectByIndex(count);
               Start.test.Log(LogStatus.Pass, "Added Hours successfully");
              SaveScreenShotClass.SaveScreenshot(Driver.driver, "Hours added");

            }
            catch (Exception ex)
            {
               Start.test.Log(LogStatus.Fail, "Test failed");
                Console.WriteLine("Test Failed, Hours not added", ex.Message);

            }
        }
        public static void DeleteHours()
        {
            cancelHours.WaitForElementClickable(Driver.driver, 40).Click();
                
        }

        public static void UserNameLink()
        {
            //Click on account holder name
            userName.WaitForElementClickable(Driver.driver, 60);
            userName.Click();

        }

        public static void PasswordLink()
        {
            //Click on Change passwordlink
            changePasswordLink.WaitForElementClickable(Driver.driver, 60);
            changePasswordLink.Click();

        }

        //Reset Password
        public static void EnterNewPassword()
            {
                Driver.TurnOnWait(3);
                //Populate the excel data
                ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ChangePassword");
                //Enter old password
                currentPassword.SendKeys(ExcelLibHelper.ReadData(2, "CurrentPassword"));

               //Enter new password
                Driver.TurnOnWait(3);
                newPassword.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));

               //Enter confirm password
                Driver.TurnOnWait(3);
                confirmPassword.SendKeys(ExcelLibHelper.ReadData(2, "ConfirmPassword"));


            }
        
        public static void SavePassword()
        {
            savePassword.WaitForElementClickable(Driver.driver, 60);
            savePassword.Click();
            Thread.Sleep(500);
            Start.test.Log(LogStatus.Info, "Password reset successfully");
        }
    }
}


