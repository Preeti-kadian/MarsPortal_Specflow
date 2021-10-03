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
   public static class ProfileEducation
    {

        #region Education feature web elements

        //Profile edit
        private static IWebElement ProfileEdit => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//section[@class='nav-secondary']//a[@href='/Account/Profile']"));

        //Click on education tab
        private static IWebElement educationTab => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div//form//a[.='Education']"));

        //Click on Add new to Educaiton
        private static IWebElement AddNewEducation => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[4]//table//div"));

        //Enter university in the text box
        private static IWebElement EnterUniversity => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//input[@name='instituteName']"));

        //Choose the country
        private static IWebElement ChooseCountry => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//select[@name='country']"));

        //Choose the skill level option
        private static IWebElement ChooseCountryOpt => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[8]"));

        //Click on Title dropdown
        private static IWebElement ChooseTitle => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//select[@name='title']"));

        //Choose title
        private static IWebElement ChooseTitleOpt => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));

        //Degree
        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//input[@name='degree']"));

        //Year of graduation
        private static IWebElement DegreeYear => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//select[@name='yearOfGraduation']"));

        //Choose Year
        private static IWebElement DegreeYearOpt => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[11]"));

        //Click on Add button
        private static IWebElement AddEdu => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//input[@value='Add']"));

        //Click on Edit education icon
        private static IWebElement editEducation => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//table/tbody/tr/td[6]/span[1]/i"));

        //Click on Save update button
        private static IWebElement updateEdu => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//table//input[@value='Update']"));

        //Click on Delete icon
        private static IWebElement deleteEducation => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[4]//table/tbody/tr/td[6]/span[2]/i"));

        #endregion
        #region Add Education feature
        //Add Education
        public static void AddEducation()
        {

            //Click on profile tab
            ProfileEdit.WaitForElementClickable(Driver.driver, 60);
            ProfileEdit.Click();

            //Click on education tab
            educationTab.WaitForElementClickable(Driver.driver, 60).Click();

            //Click on add new education button
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Education");
            AddNewEducation.WaitForElementClickable(Driver.driver, 60);
            AddNewEducation.Click();
            //Enter the University
            EnterUniversity.SendKeys(ExcelLibHelper.ReadData(2, "University"));

            //Choose Country
            ChooseCountry.Click();
            Driver.TurnOnWait(3);
            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();
            Thread.Sleep(3000);
            ChooseTitleOpt.Click();

            Thread.Sleep(3000);
            //Enter Degree
            Degree.Click();
            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));

            //Year of Graduation
            DegreeYear.Click();
            Thread.Sleep(1500);
            DegreeYearOpt.Click();
            //Click on Add button
            AddEdu.WaitForElementClickable(Driver.driver, 60);
            AddEdu.Click();
            Thread.Sleep(3000);

            //Validate Add Education 
            string actualCountry = Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[4]//table//td[.='Argentina']")).Text;
            string actualUniversity = Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[4]//table//td[.='MDU']")).Text;
            string actualTitle = Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[4]//table//td[.='B.Tech']")).Text;
            if (actualCountry == "Argentina" && actualUniversity == "MDU" && actualTitle == "B.Tech")
            {
                Assert.IsTrue(true);
                Thread.Sleep(4000);
                Start.test.Log(LogStatus.Pass, " Education added Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "AddedEducation");
                Thread.Sleep(6000);
                
            }
            else
            {
                Start.test.Log(LogStatus.Fail, "Test Failed");
            }
            Thread.Sleep(500);
        }

        #endregion

        #region Update Education details
        public static void UpdateEducation()
        {
            //Click on education tab
            educationTab.WaitForElementClickable(Driver.driver, 60).Click();

            //Click on Edit education button
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Education");
            editEducation.WaitForElementClickable(Driver.driver, 60);
            editEducation.Click();
            Thread.Sleep(3000);
            //Enter the University
            EnterUniversity.Clear();
            EnterUniversity.SendKeys(ExcelLibHelper.ReadData(3, "University"));
            updateEdu.WaitForElementClickable(Driver.driver, 60);
            updateEdu.Click();

            //Validate Update Education 
            Thread.Sleep(3000);
            string actualUniversity = Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[4]//table//td[.='ITM']")).Text;

            if (actualUniversity == "ITM")
            {
                Thread.Sleep(2000);
                Assert.IsTrue(true);
                Start.test.Log(LogStatus.Pass, " Education Updated Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "EditedEducation");
                Thread.Sleep(6000);
               
            }
            else
            {
                Start.test.Log(LogStatus.Fail, "Test Failed");
            }
        }
        #endregion

        #region Delete Education
        public static void DeleteEducation()
        {
            //Click on education tab
            educationTab.WaitForElementClickable(Driver.driver, 60).Click();
            educationTab.Click();

            //Click on  Delete icon
            deleteEducation.WaitForElementClickable(Driver.driver, 60);
            deleteEducation.Click();

            //Validate delete Education 

            IWebElement messageDelete = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));
            Driver.TurnOnWait(3);
            Assert.IsTrue(messageDelete.Enabled);
            Start.test.Log(LogStatus.Pass, "Deleted Education successfully");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education deleted");

        }


        #endregion
    }
}
