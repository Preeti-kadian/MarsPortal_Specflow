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
        public IWebElement markAsReadLink => Driver.driver.FindElement(By.XPath("/html//div[@id='service-search-section']/div[1]/div[2]/div/div/div//a[.='Mark all as read']"));

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

        #region Notification feature
        public void Notification()
        {
            //Click on notification link
            notificationLink.WaitForElementClickable(Driver.driver, 60);
            notificationLink.Click();

            //Click on See All link
            seeAllLink.WaitForElementClickable(Driver.driver, 60);
            seeAllLink.Click();
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


            //Click on Select All
            selectAll.WaitForElementClickable(Driver.driver, 60).Click();
            Thread.Sleep(2000);

            //Click on Load more
            loadMoreLink.WaitForElementClickable(Driver.driver, 60);
            loadMoreLink.Click();

            //Click on show less link
            showLessLink.WaitForElementClickable(Driver.driver, 60);
            showLessLink.Click();

            //Click on Unselect all link
            unselectAll.WaitForElementClickable(Driver.driver, 60);
            unselectAll.Click();


            //Click on top notification checkbox
            notificationCheckBox.WaitForElementClickable(Driver.driver, 60);
            notificationCheckBox.Click();

            try
            {
                //Click on delete button
                deleteButton.WaitForElementClickable(Driver.driver, 60);
                deleteButton.Click();

                Start.test.Log(LogStatus.Pass, " Notification Delete Test Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Notification Delete Successful");
            }
            catch (Exception ex)
            {
                Start.test.Log(LogStatus.Fail, "Test failed");
                Assert.Fail("Test Failed, Notification not deleted", ex.Message);

            }


        }

        #endregion
    }
}
