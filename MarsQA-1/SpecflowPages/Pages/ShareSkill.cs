using AutoIt;
using MarsFramework.Global;
using MarsQA_1.Helpers;
using MArsQASpecflow.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    public static class ShareSkill
    {
        //ShareSkill Button
        private static IWebElement ShareSkillButton => Driver.driver.FindElement(By.LinkText("Share Skill"));
        //Title in textbox
        private static IWebElement title => Driver.driver.FindElement(By.Name("title"));
        //Description in textbox
        private static IWebElement description => Driver.driver.FindElement(By.Name("description"));
        //Category Dropdown
        private static IWebElement CategoryDropDown => Driver.driver.FindElement(By.Name("categoryId"));
        //SubCategoryDropDown 
        private static IWebElement SubCategoryDropDown => Driver.driver.FindElement(By.Name("subcategoryId"));
        //Tag names in textbox
        private static IWebElement Tags => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        //Select the Service type
        private static IWebElement ServiceTypeOptions => Driver.driver.FindElement(By.XPath("//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']"));
        //Select the Location Type
        private static IWebElement LocationTypeOption => Driver.driver.FindElement(By.XPath("//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        //Start Date dropdown
        private static IWebElement StartDateDropDown => Driver.driver.FindElement(By.XPath("//input[@placeholder='Start date']"));

        //EndDateDropDown
        private static IWebElement EndDateDropDown => Driver.driver.FindElement(By.Name("endDate"));
        //Skill Trade option
        private static IWebElement SkillTradeOption => Driver.driver.FindElement(By.XPath("//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        //Skill Exchange
        private static IWebElement SkillExchange => Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
        //Credit option
        private static IWebElement Credit => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        //Enter the amount for Credit
        private static IWebElement CreditAmount => Driver.driver.FindElement(By.XPath("//input[@placeholder='Amount']"));
        // Active/Hidden option
        private static IWebElement ActiveOption => Driver.driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        //File upload
        private static IWebElement FileUpload => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        //Save button
        private static IWebElement Save => Driver.driver.FindElement(By.XPath("//input[@value='Save']"));

        public static void ShareSkillLink()
        {
            ShareSkillButton.WaitForElementClickable(Driver.driver, 60);

            //Click on share skill button and navigate to Skill listing page
            ShareSkillButton.Click();
        }

        #region Add service listing
        public static void EnterSkill()
        {
            //Populate the excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkills");

            Thread.Sleep(3000);
            //Enter Title
            title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));

            //Enter Description
            Thread.Sleep(3000);
            description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            #region select a category and sub category
            //Select category
            Thread.Sleep(3000);
            SelectElement categoryDropDownList = new SelectElement(CategoryDropDown);
            Random rnd = new Random();
            int count = rnd.Next(1, 8);
            categoryDropDownList.SelectByIndex(count);

            //Select subcategory
            Thread.Sleep(1000);
            SelectElement subCategoryDropDownList = new SelectElement(SubCategoryDropDown);
            subCategoryDropDownList.SelectByIndex(rnd.Next(1, 5));
            #endregion

            //Input tag and press Enter
            Thread.Sleep(1000);
            Tags.SendKeys(ExcelLibHelper.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            //Select Sevice Type
            Thread.Sleep(1000);
            ServiceTypeOptions.Click();

            //Select Location Type
            Thread.Sleep(1000);
            LocationTypeOption.Click();

            //Select Date 
            Thread.Sleep(5000);
            StartDateDropDown.Clear();
            StartDateDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Startdate"));

            //Select End date
            Thread.Sleep(2000);
            //EndDateDropDown.Clear();
            EndDateDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Enddate"));

            Thread.Sleep(4000);

            #region Select dates, days and time

            //Click on Selected days
            IList<IWebElement> Checkbox = Driver.driver.FindElements(By.XPath("//input[@name='Available']"));

            //Click 0n Start time
            IList<IWebElement> StartTimeDropDown = Driver.driver.FindElements(By.Name("StartTime"));

            //Click on End Time
            IList<IWebElement> EndTimeDropDown = Driver.driver.FindElements(By.Name("EndTime"));
            if (Checkbox.Count != 0)
            {
                //Checkbox.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
                for (int i = 1; i <= Checkbox.Count - 2; i++)
                {
                    //Populate the excel data
                    ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkills");

                    Thread.Sleep(500);

                    if (!Checkbox.ElementAt(i).Selected)
                    {
                        Checkbox.ElementAt(i).Click();
                    }


                    //Select Start Time
                    Thread.Sleep(2000);
                    //StartTimeDropDown.Clear();
                    StartTimeDropDown.ElementAt(i).SendKeys(ExcelLibHelper.ReadData(i + 1, "Starttime"));

                    //Select End Time
                    Thread.Sleep(500);
                    //EndTimeDropDown.Clear();
                    EndTimeDropDown.ElementAt(i).SendKeys(ExcelLibHelper.ReadData(i + 1, "Endtime"));
                }

            }
            #endregion

            #region select skill exchange or credit options

            IWebElement skillTradeRadio1 = Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            IWebElement skillTradeRadio2 = Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));

            if (skillTradeRadio1.Selected)
            {
                Thread.Sleep(4000);
                Credit.Click();
                CreditAmount.SendKeys(ExcelLibHelper.ReadData(2, "Credit"));

            }
            else
            {
                SkillExchange.Click();
                ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkills");
                SkillExchange.SendKeys(ExcelLibHelper.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
            }
            #endregion

            //Upload file
            Thread.Sleep(2);
            FileUpload.Click();
            Driver.TurnOnWait(2);

            //Activate browse window
            AutoItX.WinWaitActive("Open");
            Driver.TurnOnWait(2);

            //Sets input focus to a given control on Open Window
            AutoItX.ControlFocus("Open", "", "Edit1");
            Driver.TurnOnWait(2);

            //// Sets text of a control.
            AutoItX.ControlSetText("Open", "", "Edit1", @"E:\Competition task\marsframework-master\marsframework-master\MarsFramework\ExcelData\Test.txt");
            Driver.TurnOnWait(2);

            //Sends a mouse click command to a given control.
            AutoItX.ControlClick("Open", "", "Button1");

            //Select active type
            Driver.TurnOnWait(2);
            ActiveOption.Click();

 
        }

        public static void SaveSkill()
        {
            //Save Share Skills Listing
            Save.WaitForElementClickable(Driver.driver, 60);
            Save.Click();
            Thread.Sleep(3000);

        }

        #region Validate if Skill saved successfully
        public static void ValidateShareSkill()
        {
           
            Driver.TurnOnWait(5);
            string actualPageTitle = Driver.driver.Title;
            string expectedPageTitle = "ListingManagement";

            try
            {
                //Start the Reports

                Start.test = Start.extent.StartTest("Add a Service Listing");
                Start.test.Log(LogStatus.Info, "Add a listing");
                Driver.TurnOnWait(2);
                //verify if actual and expected page title are same
                Assert.AreEqual(actualPageTitle, expectedPageTitle);
                Driver.TurnOnWait(2);
                Start.test.Log(LogStatus.Pass, "Test Passed, Service listing added Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAddedSuccessfully");
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Driver.TurnOnWait(2);
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Assert.Fail("Test Failed, Skill not saved", ex.Message);
            }

           
        }
        #endregion



        #endregion
    }
}






