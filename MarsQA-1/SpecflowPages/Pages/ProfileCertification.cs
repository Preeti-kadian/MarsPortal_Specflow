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
    class ProfileCertification
    {
        #region  certification feature web elements
        //Profile edit
        private IWebElement ProfileEdit => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//section[@class='nav-secondary']//a[@href='/Account/Profile']"));

        //Certification tab
        public IWebElement certifications => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div//form//a[.='Certifications']"));

        //Add new Certificate
        private IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[5]//table//div[.='Add New']"));

        //Enter Certification Name
        private IWebElement EnterCertificate => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[5]//input[@name='certificationName']"));

        //Certified from
        private IWebElement CertificateFrom => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));

        //Year
        private IWebElement CertificateYear => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[5]//select[@name='certificationYear']"));

        //Choose Opt from Year
        private IWebElement CertificateYearOpt => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]"));

        // edit icon
        private IWebElement editCertificate => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[5]//table/tbody/tr/td[4]/span[1]/i"));

        //Update certficate button
        private IWebElement updateCertificate => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[5]//table//input[@value='Update']"));

        //Delete icon
        private IWebElement deleteCertificate => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[5]//table/tbody/tr/td[4]/span[2]/i"));

        //Add Ceritification
        private IWebElement AddCertificate => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[5]//input[@value='Add']"));
        #endregion

        #region Add certification
        //Add new Certificate
        public void AddNewCertificate()
        {

            //Click on profile tab
            ProfileEdit.WaitForElementClickable(Driver.driver, 60);
            ProfileEdit.Click();

            //Click on certification tab
            certifications.WaitForElementClickable(Driver.driver, 40);
            certifications.Click();

            //Click on Add new certificate button
            AddNewButton.WaitForElementClickable(Driver.driver, 60);
            AddNewButton.Click();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Certification");
            Driver.TurnOnWait(3);
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Certification");
            //Enter Certificate Name
            EnterCertificate.SendKeys(ExcelLibHelper.ReadData(2, "Certification"));

            Driver.TurnOnWait(4);
            //Enter Certified from
            CertificateFrom.Click();
            Driver.TurnOnWait(4);
            CertificateFrom.SendKeys(ExcelLibHelper.ReadData(2, "From "));

            Driver.TurnOnWait(4);
            //Enter the Year
            CertificateYear.Click();
            Driver.TurnOnWait(1);
            CertificateYearOpt.Click();
            AddCertificate.Click();
            Thread.Sleep(500);
            //Validate Add certification 
            string actualCertificateName = Driver.driver.FindElement(By.XPath("//td[normalize-space()='Publishing']")).Text;
            string expectedCertificateName = ExcelLibHelper.ReadData(2, "Certification");
            Assert.AreEqual(actualCertificateName, expectedCertificateName);
            Driver.TurnOnWait(4);
            Start.test.Log(LogStatus.Pass, "Added Certificate successfully");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certficate Added");

        }
        #endregion

        #region Update certification

        public void EditCertificate()
        {

            //Click on profile tab
            ProfileEdit.WaitForElementClickable(Driver.driver, 60);
            ProfileEdit.Click();

            //Click on certification tab
            certifications.WaitForElementClickable(Driver.driver, 40);
            certifications.Click();

            //Click on Add new certificate button
            Thread.Sleep(4000);
            editCertificate.Click();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Certification");
            Thread.Sleep(3000);
            //Enter Certificate Name
            EnterCertificate.Clear();
            EnterCertificate.SendKeys(ExcelLibHelper.ReadData(3, "Certification"));

            //Click on save button
            updateCertificate.WaitForElementClickable(Driver.driver, 60);
            updateCertificate.Click();
            Thread.Sleep(500);
            //Validate Update certification 
            string actualCertificateName = Driver.driver.FindElement(By.XPath("//td[normalize-space()='MBA']")).Text;
            string expectedCertificateName = ExcelLibHelper.ReadData(3, "Certification");
            Assert.AreEqual(actualCertificateName, expectedCertificateName);
            Driver.TurnOnWait(4);
            Start.test.Log(LogStatus.Pass, "Edit Certificate successfully");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certficate updated");
        }
        #endregion

        #region Delete certification
        //Delete Certificate
        public void DeleteCertificate()
        {

            //Click on profile tab
            ProfileEdit.WaitForElementClickable(Driver.driver, 60);
            ProfileEdit.Click();

            //Click on certification tab
            certifications.WaitForElementClickable(Driver.driver, 40);
            certifications.Click();

            Thread.Sleep(4000);
            //Click on save button
            deleteCertificate.Click();
            Thread.Sleep(500);
            //Validate delete certificate
            IWebElement deleteMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));
            Driver.TurnOnWait(4);
            Assert.IsTrue(deleteMessage.Enabled);
            Start.test.Log(LogStatus.Pass, "Deleted certifcation successfully");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certficate deleted");

            #endregion


        }
    }
}
