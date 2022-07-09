using Mars.Utilities;
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
        public void ClickOnSkillTab(IWebDriver driver)
        {
            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Skills')]", 3);
            //identify the skill tab and click on it
            driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
            Thread.Sleep(2000);
        }
        public void AddSkill(IWebDriver driver)
        {

            //identify add new button and click on it
            IWebElement Create = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            Create.Click();

            //identify skill textbox and type it the skill
            IWebElement skilltextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            skilltextbox.SendKeys("java");

            // select the drop down list
            IWebElement SkillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillLevel.Click();
            Thread.Sleep(2000);
            //wait helpers
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]')]", 3);
            //select intermediate
            IWebElement SkillLeve = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            SkillLeve.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//input[@value='Add']", 3);
            //identify the add option and click on the button
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(3000);


        }
        public string AddSkillCheck(IWebDriver driver)
        {
            IWebElement AddSkillCheck = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return AddSkillCheck.Text;
        }
        public string AddSkillLevel(IWebDriver driver)
        {
            IWebElement AddSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return AddSkillLevel.Text;
        }

        public void EditSkill(IWebDriver driver, string Skill)
        {
            //click on the edit option to update skill
            IWebElement Edit = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            Edit.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]", 3);

            //edit the skill name 
            IWebElement EditSkill = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));

            EditSkill.Clear();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]", 3);

            EditSkill.SendKeys(Skill);

            //identify the dropdwon
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]")).Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[2]", 3);

            //select beginner from the drop down
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[2]")).Click();

            //click on update button
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();


        }
        public string SkillEdited(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editskill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editskill.Text;
        }
        public string SkillLevel(IWebDriver driver)
        {
            IWebElement skilllevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[2]"));
            return skilllevel.Text;
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
