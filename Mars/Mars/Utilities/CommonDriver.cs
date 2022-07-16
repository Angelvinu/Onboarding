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

        LanguagePage LanguagePageObj;
        LoginPage LoginPageObj;

        [SetUp]
        public void LoginAction()
        {
            driver = new ChromeDriver();
            LoginPageObj.LoginSteps(driver);
            LanguagePageObj.GetWelcomeText(driver);
        }
        [OneTimeTearDown]

        public void TestClose()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
