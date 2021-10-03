using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));

        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2, "Username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            LoginBtn.Click();
        }

        public static void ClickSignInBtn()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
        }

        public static void Login()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter valid Iname
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("tokas.preeti@gmail.com");

            //Enter invalid password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("tokas112");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}