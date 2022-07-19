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
    public class LanguagePage
    {
        //Define class with two objects
        public IWebDriver driver;
        

        //Form constructor 

        public LanguagePage(IWebDriver driver)
        {
            //initialising driver object
            this.driver = driver;
        }

        //find elements by XPath
        private IWebElement message => driver.FindElement(By.XPath(xpValue));
        private IWebElement lanValue1 => driver.FindElement(By.XPath(lanValue));
        private IWebElement AddButton => driver.FindElement(By.XPath(AddButtonXpath));
        private IWebElement AddLanguage1 => driver.FindElement(By.XPath(AddLanguageXpath));
        private IWebElement DropDown => driver.FindElement(By.XPath(DropDownXpath));
        private IWebElement SelectOption => driver.FindElement(By.XPath(SelectOptionXpath));
        private IWebElement AddNow => driver.FindElement(By.XPath(AddNowXpath));
        private IWebElement AddLang1 => driver.FindElement(By.XPath(AddLangXpath));
        private IWebElement LangLevel1 => driver.FindElement(By.XPath(LangLevelXpath));
        private IWebElement EditLanguage1 => driver.FindElement(By.XPath(EditLanguageXpath));
        private IWebElement EditLang => driver.FindElement(By.XPath(EditLangXpath));
        private IWebElement UpdateButton => driver.FindElement(By.XPath(UpdateButtonXpath));
        private IWebElement UpdateLang2 => driver.FindElement(By.XPath(UpdateLanguageXpath));
        private IWebElement DelLang2 => driver.FindElement(By.XPath(DelLangXpath));
        private IWebElement DelLang3 => driver.FindElement(By.XPath(DelLanguageXpath));


        //XPath
        private string xpValue = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span";
        private string lanValue = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
        private string AddButtonXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div";
        private string AddLanguageXpath = "//input[@placeholder='Add Language']";
        private string DropDownXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select";
        private string SelectOptionXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]";
        private string AddNowXpath = "//input[@value='Add']";
        private string AddLangXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]";
        private string LangLevelXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]";
        private string EditLanguageXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i";
        private string EditLangXpath = "//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]";
        private string UpdateButtonXpath = "//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]";
        private string UpdateLanguageXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]";
        private string DelLangXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i";
        private string DelLanguageXpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";



        public string GetWelcomeText(IWebDriver driver)
        {
            //get the message as Hii Angel Mary
            WaitHelpers.WaitToBeVisible(driver, "XPath", xpValue, 3);
            
            //item ui dropdown link 
            return message.Text;
            Thread.Sleep(1500);

        }
        public void ClickOnLanguageTab(IWebDriver driver)
        {
            
            //identify the language tab and click on it
            WaitHelpers.WaitToBeClickable(driver, "XPath", lanValue, 5);
            lanValue1.Click();
            
        }
        public void AddLanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddButtonXpath, 5);
            AddButton.Click();
            Thread.Sleep(1500);

            //add language
            AddLanguage1.SendKeys("Java");

            // select the drop down list
            DropDown.Click();

            //Select basic 
            SelectOption.Click();

            //identify the add language and click on the button
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddNowXpath, 5);
            AddNow.Click();
            Thread.Sleep(1500);

        }
        public string AddLang(IWebDriver driver)
        {

            return AddLang1.Text;
        }
        public string LangLevel(IWebDriver driver)
        {
            return LangLevel1.Text;
        }
        public void EditLanguage(IWebDriver driver, string Language)
        {
            Thread.Sleep(3000);
            //click on edit language
            EditLanguage1.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditLangXpath, 3);

            //edit the language 
            EditLang.Clear();

            //wait helpers
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]", 3);
            Thread.Sleep(4000);
            EditLang.SendKeys(Language);

            WaitHelpers.WaitToBeClickable(driver, "XPath", UpdateButtonXpath, 3);
            //click on update button
            UpdateButton.Click();
            Thread.Sleep(3000);

        }
        public string UpdateLang(IWebDriver driver)
        {
            return UpdateLang2.Text;
        }
        public void DeleteLanguage(IWebDriver driver)
        {

            //wait helpers.
            WaitHelpers.WaitToBeClickable(driver, "XPath", DelLangXpath, 4);
                DelLang2.Click();   
        }
        public string DelLang(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", DelLanguageXpath, 5);
            //Identify editedlanguage and click
            return DelLang3.Text;

        }


    }
}
