using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        ProfilePage ProfilePageObj = new ProfilePage();
        LoginPage LoginPageObj = new LoginPage();

        [SetUp]
        public void LoginAction()
        {
            driver = new ChromeDriver();
            LoginPageObj.LoginSteps(driver);
            ProfilePageObj.GetWelcomeText(driver);
        }
        [OneTimeTearDown]

        public void TestClose()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
