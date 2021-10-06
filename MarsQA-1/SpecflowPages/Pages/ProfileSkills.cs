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
using RelevantCodes.ExtentReports;
using MArsQASpecflow.SpecflowPages.Utils;
using MarsFramework.Global;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfileSkills
    {
        private static IWebElement skills => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement addNewSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addSkill => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));


        private static IWebElement addSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement cancelAddSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
        private static IWebElement editSKill => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div/div[@class='row']//form/div[3]//table/tbody[1]/tr/td[3]/span[1]/i"));
        private static IWebElement updateSkillButton => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement cancelSkillUpdate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
        private static IWebElement deleteSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        private static IWebElement skillContent => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));

        public static void SkillsTab()
        {
            //Click on skills tab
            skills.WaitForElementClickable(Driver.driver, 30).Click();
        }

        public static void AddNewSkillButton()
        {
            addNewSkill.WaitForElementClickable(Driver.driver, 30).Click();
        }

        public static void EditSkillIcon()
        {
            SkillsTab();
            //Click on Edit skill icon
            editSKill.WaitForElementClickable(Driver.driver, 30).Click();
        }

        public static void DeleteSkill()
        {
            SkillsTab();
            //Click on delete icon
            deleteSkill.WaitForElementClickable(Driver.driver, 30).Click();
        }

        //Add new Skill
        public static void AddSkills()
        {
            //Add new skill
           
            
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Skills");
            //Read data from excel file
            for (int i = 2; i <=4; i++)
            {
                //Click on Add new button
                Driver.TurnOnWait(2);
                AddNewSkillButton();

                Thread.Sleep(3000);
                addSkill.SendKeys(ExcelLibHelper.ReadData(i, "Skillls"));
                Thread.Sleep(1000);
                //Select option from drop down list
                SelectElement skillsdropdown = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                Driver.TurnOnWait(2);
                //Generating random value to select option from dropdown list
                Random rnd = new Random();
                int count = rnd.Next(1, i);
                skillsdropdown.SelectByIndex(count);

                addSkillButton.Click();
                Thread.Sleep(1500);
            }
        }

        //Validate added skill
        public static void ValidateAddSkills()
        {
            
            //Validate the skills are added sucessfully
            try
            {
                //Start Reports
                Start.test = Start.extent.StartTest("Add skills");
                Start.test.Log(LogStatus.Info, "Adding skills");
                String expectedValue = ExcelLibHelper.ReadData(2, "Skills");
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
                        Start.test.Log(LogStatus.Pass, "Skills added Successful");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAdd");
                        Assert.IsTrue(true);
                    }
                    else
                        Start.test.Log(LogStatus.Fail, "Test Failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Thread.Sleep(1500);

        }
        //Update added skills

    public static void UpdateSkills()
        {
            SkillsTab();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Skills");
   
            //Update and read Skills from Excel data
            for (int i = 1; i <= 3; i++)
            {
            
                //IWebElement editIcon = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                Thread.Sleep(300);
                //Click on Edit skills icon
              
                //Clear content for skills input 
                addSkill.Clear();
                Thread.Sleep(1000);
                //Read updated skills from Excel file
                addSkill.SendKeys(ExcelLibHelper.ReadData(i + 1, "Updated_Skills"));
                
                // Select and input value from Skills level dropdown list
                SelectElement skillsdropdown = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                //Generating random value to select option from dropdown list
                Random rnd = new Random();
                int count = rnd.Next(1, i);
                skillsdropdown.SelectByIndex(count);
                Thread.Sleep(1500);
                //Save updated Skills
                updateSkillButton.Click();
                Thread.Sleep(3000);
                EditSkillIcon();
            }

        }

        public static void ValidateUpdateSkills()
        {
            //Validate the skills are updated sucessfully
            try
            {
                //Start Reports
                Start.test = Start.extent.StartTest("Update Skills");
                Start.test.Log(LogStatus.Info, "Updating Skills");
                String expectedValue = ExcelLibHelper.ReadData(2, "Updated_Skills");
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
                        Start.test.Log(LogStatus.Pass, " Skills Update Successful");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "skillsUpdate");
                        Assert.IsTrue(true);
                    }
                    else
                        Start.test.Log(LogStatus.Fail, "Test Failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Thread.Sleep(1500);

        }


        //Delete skills
        public static void DeleteSkills()
        { 
            SkillsTab();
            Driver.TurnOnWait(2);
            IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr"));
            //Read the row count in table
            for (var i = 1; i <= rows.Count; i++)
            {

                DeleteSkill();
                Thread.Sleep(2000);
            }
        }

        //Validate if skill is deleted successfully
        public static void ValidateDeleteSkills()
        {
            try
            {
                //Start Reports
                Start.test = Start.extent.StartTest("Delete Skills");
                Start.test.Log(LogStatus.Info, "Deleting skills");

                //List table data       
                IList<IWebElement> rows = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
                //Read the row count in table
                for (var i = 1; i < rows.Count; i++)
                {
                    Thread.Sleep(4000);
                    string actualValue = Driver.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    //Verify if actual value is equal to null
                    if (actualValue == null)
                    {
                        Start.test.Log(LogStatus.Pass, " Skills delete Successful");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeleteSkills");
                        Assert.IsTrue(true);
                    }
                    else
                        Start.test.Log(LogStatus.Fail, "Test Failed");
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

