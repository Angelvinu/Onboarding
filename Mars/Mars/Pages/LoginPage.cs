using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            

            //setting a driver interface
           

            //maximise the browser
            driver.Manage().Window.Maximize();

            //launch the turn up portal
            driver.Navigate().GoToUrl("http://localhost:5000");


            try
            {
                //Identify the sign in button
                driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

                //identify username and enter the user name.
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("angelmarsalin@hotmail.com");

                //identify password and enter the password.
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Angel1234");

                //identify login button and click on it.
                IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                login.Click();

                

            }

            catch (Exception)

            {
                Assert.Fail("turnup portal was not sucessfully lunched.");
            }
        }

      
    }
}
