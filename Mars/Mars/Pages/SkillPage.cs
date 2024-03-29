﻿using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class SkillPage

    {
        public IWebDriver driver;

        public SkillPage(IWebDriver driver)
        {
            this.driver = driver;
        }

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
    
        public void ClickOnSkillTab(IWebDriver driver)
        {
            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 3);
            //identify the skill tab and click on it
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            Thread.Sleep(2000);
        }
        public void AddSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div]", 5);
            //identify add new button and click on it
            IWebElement Create = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Create.Click();

            //identify skill textbox and type it the skill
            IWebElement skilltextbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skilltextbox.SendKeys("java");

            // select the drop down list
            IWebElement SkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillLevel.Click();
            Thread.Sleep(2000);
            //wait helpers
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]')]", 3);
            //select intermediate
            IWebElement SkillLeve = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            SkillLeve.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]", 3);
            //identify the add option and click on the button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
            Thread.Sleep(3000);


        }
        public string AddSkillCheck(IWebDriver driver)
        {
            IWebElement AddSkillCheck = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return AddSkillCheck.Text;
        }
      
        public void EditSkill(IWebDriver driver, string Skill)
        {
            //click on the edit option to update skill
            IWebElement Edit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            Edit.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 3);

            //edit the skill name 
            IWebElement EditSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

            EditSkill.Clear();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 3);

            EditSkill.SendKeys(Skill);

            //identify the dropdwon
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")).Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]", 3);

            //select beginner from the drop down
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]")).Click();

            //click on update button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();


        }
        public string SkillEdited(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editskill.Text;
        }
       
        public void DeleteSkill(IWebDriver driver)
        {

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]", 3);

            //identify the remove option and click on delete
            IWebElement Delete = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            Delete.Click();
            

        }
        public string DeletedSkill(IWebDriver driver)
        {
            IWebElement deleteskill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return deleteskill.Text;
        }
    }
       
    
}
