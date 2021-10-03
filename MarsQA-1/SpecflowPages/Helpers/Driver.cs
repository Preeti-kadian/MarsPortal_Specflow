using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        

        //Initialize the browser
        public static IWebDriver driver { get; set; }

      
        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait(2);

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string Url
        {
            get { return ConstantHelpers.Url; }
        }

        public static object SeleniumExtras { get; private set; }


        //Implicit Wait
        public static void TurnOnWait(int v)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(Url);
        }

        //Close the browser
        public static void Close()
        {
            driver.Quit();
        }

    }
}
