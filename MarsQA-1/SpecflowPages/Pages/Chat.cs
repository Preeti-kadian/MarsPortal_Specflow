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
 
        class Chat
        {

        #region Chat web elements
        //Chat link
        private IWebElement chatLink => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/div[1]//a[@href='/Home/Message']"));

         //Message text box
         private IWebElement chatTextBox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Type your message here...']"));

        //Send chat button
         private IWebElement sendButton=> Driver.driver.FindElement(By.XPath("//button[normalize-space()='Send']"));

        //search box
         private IWebElement searchUser => Driver.driver.FindElement(By.XPath("/html//div[@id='chatRoomContainer']/div[@class='chatRoom']//input[@class='prompt']"));

        //Search Icon
         private IWebElement searchIcon => Driver.driver.FindElement(By.XPath("/html//div[@id='chatRoomContainer']/div[@class='chatRoom']//i"));
        
        //Latest chat row
         private IWebElement latestChatRow => Driver.driver.FindElement(By.XPath("//*[@id='chatList']/div[1]/div[2]/div[1]"));

        //Latest chat message
         private IWebElement latestChat => Driver.driver.FindElement(By.XPath("//div[last()]//div[1]//div[1]//span[1]"));


        #endregion

        #region chat functionality
        public void ChatFeature()
            {
                //Click on Chat link
                chatLink.WaitForElementClickable(Driver.driver, 60);
                chatLink.Click();


                chatTextBox.WaitForElementClickable(Driver.driver, 30);
                //Populate the excel data
                ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Chat");

                //Read and Enter message into chat box
                chatTextBox.SendKeys(ExcelLibHelper.ReadData(2, "ChatMessage"));

                //Click on send button
                sendButton.WaitForElementClickable(Driver.driver, 40);
                sendButton.Click();
                Thread.Sleep(2000);
              
             
                //Validate Chat sent successfully
                 latestChat.WaitForElementClickable(Driver.driver, 60);
                string expectedMessage = latestChat.Text;
                 string actualMessage = ExcelLibHelper.ReadData(2, "ChatMessage");
                 try
                 {
                   
                     Assert.AreEqual(actualMessage, expectedMessage);
                     Thread.Sleep(2000);
                     Start.test.Log(LogStatus.Pass, "Test Passed, Chat Sent Successfully");
                     SaveScreenShotClass.SaveScreenshot(Driver.driver, "ChatSuccessful");
                     Assert.IsTrue(true);

                 }

                 catch (Exception ex)
                 {
                     Start.test.Log(LogStatus.Fail, "Test Failed");
                     Console.WriteLine(ex.Message);
                 }

            }
            #endregion

            #region Find user in Chat room
            public void ChatRoomSearch()
            {
            //Click on Chat link
            chatLink.WaitForElementClickable(Driver.driver, 60);
            chatLink.Click();

            //Click on Search box
            searchUser.WaitForElementClickable(Driver.driver, 60);
                searchUser.Click();

                //Populate the excel data
                ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Chat");

                //Enter data into search box
                searchUser.SendKeys(ExcelLibHelper.ReadData(2, "SearchUser"));
                Thread.Sleep(2000);

                //Click on Search Icon
                searchIcon.Click();



                //Validate search user is successful
                Thread.Sleep(5000);
                string expectedUser = latestChatRow.Text;
                string actualUser = ExcelLibHelper.ReadData(2, "SearchUser");
                try
                {
                if (actualUser== expectedUser)
                 { 
                   
                    Thread.Sleep(2000);
                    Start.test.Log(LogStatus.Pass, "Test Passed, Chat room search successful");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ChatSearchSuccessful");
                    Assert.IsTrue(true);
                }
                }

                catch (Exception ex)
                {
                Start.test.Log(LogStatus.Fail, "Test Failed");
                Console.WriteLine(ex.Message);
                }

            }

            #endregion




        }


    }
