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
    class SearchSkill
    {
        #region Initialise the web element
        //Search skills input box
        public IWebElement searchSkillsTextbox=> Driver.driver.FindElement(By.XPath("//div[@class='four wide column']//input[@placeholder='Search skills']"));

        //Search skills icon
        public IWebElement searchSkillsIcon => Driver.driver.FindElement(By.XPath("//i[@class='search link icon']"));

        //Search user input box
        public IWebElement searchUserTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Search user']"));

        //Search user input box
        public IWebElement searchUserLink => Driver.driver.FindElement(By.XPath(" //*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span"));

        //All category link
        public IWebElement allCategories => Driver.driver.FindElement(By.XPath("/html//div[@id='service-search-section']//section[@class='search-results']//div[@role='list']/a[1]/b[.='All Categories']"));

        //Search Category
        public IWebElement categoryType => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[3]/div/section/div/div[1]/div[1]/div/a[2]/b"));

        //Search subCategory
        public IWebElement subCategoryType => Driver.driver.FindElement(By.XPath("/html//div[@id='service-search-section']//section[@class='search-results']//div[@role='list']/a[3]/b[.='Logo Design']"));

        // Online search filter
        public IWebElement onlineFilter => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Online']"));

        //Filter offline search filter
        public IWebElement offlineFilter => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Onsite']"));

        //Show all filter
        public IWebElement showAllFilter => Driver.driver.FindElement(By.XPath("//button[normalize-space()='ShowAll']"));

        //Filtered skill
        //Show all filter
        public IWebElement filteredSkill => Driver.driver.FindElement(By.XPath("//em[normalize-space()='Skills: Test']"));

        #endregion

        public void SearchSkillIcon()
        {
            //Click on search skills icon
            searchSkillsIcon.WaitForElementClickable(Driver.driver, 60);
            searchSkillsIcon.Click();
        }

        #region Search skills
        public void SearchSkillsByCategory()
        {
            //Click on search skills icon
            SearchSkillIcon();

            Thread.Sleep(3000);
            //Populate the excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SearchSkills");
            //Enter skills to be searched
            searchSkillsTextbox.WaitForElementClickable(Driver.driver, 60);
            searchSkillsTextbox.SendKeys(ExcelLibHelper.ReadData(2, "SearchSkill"));

        }

        public void SearchUser()
        {
            SearchSkillsByCategory();
            //Enter user name
            searchUserTextbox.WaitForElementClickable(Driver.driver, 60);
            searchUserTextbox.SendKeys(ExcelLibHelper.ReadData(2, "User"));
            Driver.TurnOnWait(4);
         
        }

        public void ClickSearchUser()
        {
            searchUserLink.Click();
        }
        public void FilterSkills()
        {
            SearchUser();
            //Click on online filter
            onlineFilter.WaitForElementClickable(Driver.driver, 60);
            onlineFilter.Click();

            //Click on offline filter
            Driver.TurnOnWait(2);
            offlineFilter.Click();

            //Click on ShowAll filter
            showAllFilter.Click();

        }

        public void ValidateSearchFilter()
        {
            FilterSkills();
            //Validate filter
            Driver.TurnOnWait(2);
            Assert.IsTrue(filteredSkill.Displayed);
            Start.test.Log(LogStatus.Pass, "Test Passed, Skill filtered");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Search filtered");
            Driver.TurnOnWait(4);
        }
        #endregion
    }
}
