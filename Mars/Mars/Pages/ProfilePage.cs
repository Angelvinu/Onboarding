using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class ProfilePage
    {
        public string GetWelcomeText(IWebDriver driver)
        {
            //get the message as Hii Angel Mary
            string xpValue = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span";
            WaitHelpers.WaitToBeVisible(driver, "XPath", xpValue, 3);
            IWebElement message = driver.FindElement(By.XPath(xpValue));
            //item ui dropdown link 
            return message.Text;
            Thread.Sleep(1500);

        }
        public void ClickOnLanguageTab(IWebDriver driver)
        {
            Thread.Sleep(1500);
            //identify the language tab and click on it
            string lanValue = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
            WaitHelpers.WaitToBeClickable(driver, "XPath", lanValue, 3);
            driver.FindElement(By.XPath(lanValue)).Click();
            Thread.Sleep(1500);
        }
        public void AddLanguage(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //string AddButton = "//div[@data-tab='first']//div[@class ='ui teal button ']";
            //WaitHelpers.WaitToBeClickable(driver, "XPath", AddButton, 3);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            Thread.Sleep(1500);
            //add language
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Java");

            // select the drop down list
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
            //Select basic 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")).Click();

            //identify the add language and click on the button
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(1500);

        }
        public string AddLang(IWebDriver driver)
        {
            IWebElement AddLang = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));

            return AddLang.Text;
        }
        public string LangLevel(IWebDriver driver)
        {
            IWebElement LangLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));

            return LangLevel.Text;

        }
        public void EditLanguage(IWebDriver driver, string Language)
        {
            Thread.Sleep(3000);
            //click on edit language
            IWebElement EditLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            EditLanguage.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]", 3);

            //edit the language 
            IWebElement EditLang = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditLang.Clear();

            //wait helpers
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]", 3);
            Thread.Sleep(4000);
            EditLang.SendKeys(Language);

            Thread.Sleep(3000);
            //click on update button
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]")).Click();
            Thread.Sleep(3000);

        }
        public string UpdateLang(IWebDriver driver)
        {
            IWebElement UpdateLang = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

            return UpdateLang.Text;
        }
        public void DeleteLanguage(IWebDriver driver)
        {
        
                //Thread.Sleep(3000);
                //wait helpers.
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 4);
                IWebElement DelLang = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                DelLang.Click();
           
                Assert.That(DelLang.Text != "c", "language was not deleted successfully");
            
           

        }


        
    }
}
