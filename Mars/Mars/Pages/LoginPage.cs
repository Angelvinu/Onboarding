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
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //find elements by XPath
        private IWebElement SignIn => driver.FindElement(By.XPath(SignInXpath));
        private IWebElement UserName => driver.FindElement(By.XPath(UserNameXpath));
        private IWebElement Password => driver.FindElement(By.XPath(PasswordXpath));
        private IWebElement LoginIn => driver.FindElement(By.XPath(LoginInXpath));


        //Xpath
        private string SignInXpath = "//*[@id='home']/div/div/div[1]/div/a";
        private string UserNameXpath = "/html/body/div[2]/div/div/div[1]/div/div[1]/input";
        private string PasswordXpath = "/html/body/div[2]/div/div/div[1]/div/div[2]/input";
        private string LoginInXpath = "/html/body/div[2]/div/div/div[1]/div/div[4]/button";

        public void LoginSteps(IWebDriver driver)
        {
           

            //maximise the browser
            driver.Manage().Window.Maximize();

            //launch the turn up portal
            driver.Navigate().GoToUrl("http://localhost:5000");


            try
            {
                //Identify the sign in button
                SignIn.Click();

                //identify username and enter the user name.
                UserName.SendKeys("angelmarsalin@hotmail.com");

                //identify password and enter the password.
                Password.SendKeys("Angel1234");

                //identify login button and click on it.
                LoginIn.Click();

                

            }

            catch (Exception)

            {
                Assert.Fail("turnup portal was not sucessfully lunched.");
            }
        }

      
    }
}
