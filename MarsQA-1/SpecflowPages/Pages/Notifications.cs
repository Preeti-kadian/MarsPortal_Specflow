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
    class Notifications
    {
        #region Initialize web driver
        //Notification link
        public IWebElement notificationLink => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div"));

        //Click on "See All" link
        public IWebElement seeAllLink => Driver.driver.FindElement(By.LinkText("See All..."));

        //Mark As Read link
        public IWebElement markAsReadLink => Driver.driver.FindElement(By.XPath("//div/div[1]/div[2]/div/div/div[2]//a[.='Mark all as read']"));

        //Select All button
        public IWebElement selectAll => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Select all']"));

        //Unselect All button
        public IWebElement unselectAll => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[2]"));

        //notification checkbox
        public IWebElement notificationCheckBox => Driver.driver.FindElement(By.XPath("//input[@value='0']"));

        // Delete button
        public IWebElement deleteButton => Driver.driver.FindElement(By.XPath("/html//div[@id='notification-section']//div[@name='NotificationBody']/div[3]/div[1]/div[3]"));

        //Maerk Selection as read
        public IWebElement markSelectionAsRead => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[4]"));

        //Load more button
        public IWebElement loadMoreLink => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Load More...']"));

        //Show less button
        public IWebElement showLessLink => Driver.driver.FindElement(By.XPath("//a[normalize-space()='...Show Less']"));


        #endregion

        public void NotificationLink()
        {
            //Click on notification link
            notificationLink.WaitForElementClickable(Driver.driver, 60);
            notificationLink.Click();
        }

        public void ValidateNavigate()
        {
            NotificationLink();
            try 
            { 
            string dashboardActualTitle = Driver.driver.Title;
            string expectedTitle = "Dashboard";
            Assert.AreEqual(dashboardActualTitle, expectedTitle);
            Driver.TurnOnWait(2);
            Start.test.Log(LogStatus.Pass, "Test Passed, Navigation successful");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "User on dashboard page");
            Thread.Sleep(3000);
            Assert.IsTrue(true);

        }
            catch (Exception ex)
            {
                Driver.TurnOnWait(2);
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Assert.Fail("Test Failed, navigation not successful", ex.Message);
            }

        }

        public void MarkAll()
        {
          
           
            Thread.Sleep(6000);
            //Click on mark all as read
            markAsReadLink.WaitForElementClickable(Driver.driver, 40).Click();
        }

        public void UnSelectAllNotification()
        {
           
           
            Thread.Sleep(3000);
            //SelectAllLink();

            unselectAll.WaitForElementClickable(Driver.driver, 30).Click();
        }

        public void SeeAllLink()
        {
            Thread.Sleep(4000);
            NotificationLink();
            seeAllLink.WaitForElementClickable(Driver.driver, 60);
            seeAllLink.Click();

        }


        public void SelectAllLink()
        {
            Thread.Sleep(2000);
            //SeeAllLink();
            //Click on Select All
            selectAll.WaitForElementClickable(Driver.driver, 60).Click();
            Thread.Sleep(2000);
        }

        public void LoadMoreLink()
        {
            Thread.Sleep(2000);
            //SelectAllLink();
            //Click on Load more
            loadMoreLink.WaitForElementClickable(Driver.driver, 60);
            loadMoreLink.Click();
        }

        public void ShowLessLink()
        {
            Thread.Sleep(2000);
            LoadMoreLink();
            //Click on show less link
            showLessLink.WaitForElementClickable(Driver.driver, 60);
            showLessLink.Click();
        }

        public void ValidateShowLessNotDisplayed()
        {
            if(showLessLink.Displayed==false)
            {
                Assert.IsTrue(true);
            }
        }
       

        public void UnselectAllLink()
        {
            Thread.Sleep(2000);
            SelectAllLink();
            //Click on Unselect all link
            unselectAll.WaitForElementClickable(Driver.driver, 60);
            unselectAll.Click();
        }
        public void CheckAll()
        {
            Thread.Sleep(2000);
            //UnselectAllLink();
            Thread.Sleep(2000);
            //Click on Unselect all link
            notificationCheckBox.WaitForElementClickable(Driver.driver, 60);
            notificationCheckBox.Click();
        }

        public void DeleteNotification()
        {
            
            Thread.Sleep(3000);
            //Click on Select all
            SelectAllLink();

            //Click on delete button
            deleteButton.WaitForElementClickable(Driver.driver, 60);
            deleteButton.Click();
        }

        public void ValidateDeleteNotification()
        {
           
            //Click on Select All
            SelectAllLink();

            try
            {
                //Click on delete button
                DeleteNotification();

        Start.test.Log(LogStatus.Pass, " Notification Delete Test Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Notification Delete Successful");
            }
            catch (Exception ex)
            {
                Start.test.Log(LogStatus.Fail, "Test failed");
                Assert.Fail("Test Failed, Notification not deleted", ex.Message);

            }
        }

        #region Notification feature
        public void ValidateSeeAllNotification()
        {
            //Click on notification link
            NotificationLink();

            //Click on See All link
            SeeAllLink();
            Driver.TurnOnWait(1);
        
            //Validate See all link  
            try
            {
                string expectedTitle = "Dashboard";
                string actualTitle = Driver.driver.Title;
                Assert.AreEqual(expectedTitle, actualTitle);
                Driver.TurnOnWait(2);
               
                Start.test.Log(LogStatus.Pass, " Notification See all feature successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Notification view Successful");
            }
            catch (Exception ex)
            {
                Start.test.Log(LogStatus.Fail, "Test failed");
                Assert.Fail("Test Failed, Notifications not viewed", ex.Message);

            }
            Thread.Sleep(3000);


     
        }

        #endregion
    }
}
