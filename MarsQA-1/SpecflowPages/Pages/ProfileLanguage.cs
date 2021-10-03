using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;
using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Model;
using MArsQASpecflow.SpecflowPages.Utils;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfileLanguage 
    {
        private static IWebElement languageTab => Driver.driver.FindElement(By.XPath(" //a[contains(text(),'Languages')]"));

        private static IWebElement languageLevel => Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select"));

        private static IWebElement languageAdd => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement cancelLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
        private static IWebElement addNewLanguageButton => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));

        private static IWebElement addLanguageButton => Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));

        private static IWebElement saveLanguage => Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
        private static IWebElement updateButton => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement cancelUpdate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
        private static IWebElement deleteLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
        private static IWebElement deleteContent => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

        //Add new language
        public static void AddLanguage()
        {
            //Add new language
            languageTab.Click();

            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Language");
            //Read data from excel file
            for (int i = 2; i <= 5; i++)
            {
                Thread.Sleep(2000);
                addNewLanguageButton.Click();
                Driver.TurnOnWait(3);
                languageAdd.SendKeys(ExcelLibHelper.ReadData(i, "Language"));
                Driver.TurnOnWait(2);
                //Select option from drop down list
                SelectElement dropdownLanguage = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                Driver.TurnOnWait(2);
                //Generating random value to select option from dropdown list
                Random rnd = new Random();
                int count = rnd.Next(1, i);
                dropdownLanguage.SelectByIndex(count);
                //Thread.Sleep(500);
                saveLanguage.Click();
                Thread.Sleep(1500);

            }
        }

        //Validate added language
        public static void ValidateAddedLanguage()
        {
           //Validate the language is added sucessfully
            try
            {
                //Start Reports
                Start.test = Start.extent.StartTest("Add Language");
                Start.test.Log(LogStatus.Info, "Adding language");
                String expectedValue = ExcelLibHelper.ReadData(2, "Language");
                //List table data       
                IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
                //Read the row count in table
                for (var i = 1; i < rows.Count; i++)
                {
                    Thread.Sleep(4000);
                    string actualValue = Driver.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    //Verify if expected value is equal to actual value
                    if (expectedValue == actualValue)
                    {
                        Start.test.Log(LogStatus.Pass, " Language added Successful");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "languageAdd");
                        Assert.IsTrue(true);
                    }
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Thread.Sleep(1500);
            
        }



        //Update added language
        public static void UpdateLanguage()
        {
            Driver.TurnOnWait(2);
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Language");
          
            //Update and read language from Excel data
            for (int i = 1; i <= 4; i++)
            {
                Thread.Sleep(1000);
                IWebElement editIcon = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                //Click on Edit icon 
                editIcon.Click();
             //Clear content for language input 
                languageAdd.Clear();
                Driver.TurnOnWait(2); 
                //Read updated language from Excel file
                languageAdd.SendKeys(ExcelLibHelper.ReadData(i+1, "Updated_Language"));
                Thread.Sleep(1000);
                // Select and input value from language level dropdown list
                SelectElement dropdown = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                //Generating random value to select option from dropdown list
                Random rnd = new Random();
                int count = rnd.Next(1, i);
                dropdown.SelectByIndex(count);
                Thread.Sleep(1000);
                //Save updated language
                updateButton.Click();
                Thread.Sleep(3000);
            }

        }

        //Validate updated language
        public static void ValidateUpdatedLanguage()
        {
            //Validate the language is updated sucessfully
            try
            {
                //Start Reports
                Start.test = Start.extent.StartTest("Update Language");
                Start.test.Log(LogStatus.Info, "Updating language");
                String expectedValue = ExcelLibHelper.ReadData(2, "Updated_Language");
                //List table data       
                IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
                //Read the row count in table
                for (var i = 1; i < rows.Count; i++)
                {
                    Thread.Sleep(4000);
                    string actualValue = Driver.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    //Verify if expected value is equal to actual value
                    if (expectedValue == actualValue)
                    {
                        Start.test.Log(LogStatus.Pass, " Language Update Successful");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "languageUpdate");
                        Assert.IsTrue(true);
                    }
                  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Thread.Sleep(1500);

        }


        //Delete added language
        public static void DeleteLanguage()
        {
            IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
            //Read the row count in table
            for (var i = 1; i <=rows.Count; i++)
            {
                
                deleteLanguage.Click();
                Thread.Sleep(3000);

            }

        }
        public static void DeleteLanguageValidate()
        {
       
            try
            {
                //Start Reports
                Start.test = Start.extent.StartTest("Delete Language");
                Start.test.Log(LogStatus.Info, "Deleting language");
             
                //List table data       
                IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
                //Read the row count in table
                for (var i = 1; i < rows.Count; i++)
                {
                    Thread.Sleep(4000);
                    string actualValue = Driver.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    //Verify if actual value is equal to null
                    if (actualValue== null)
                    {
                       
                        Start.test.Log(LogStatus.Pass, " Language delete Successful");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeleteLanguage");
                        
                        
                    }
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Thread.Sleep(1500);
           
        }
    }
}
