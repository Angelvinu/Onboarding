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
        public IWebDriver driver;

        public SkillPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //find elements by XPath
        private IWebElement message => driver.FindElement(By.XPath(xpValueXpath));
        private IWebElement SkillTab => driver.FindElement(By.XPath(SkillTabXpath));
        private IWebElement Create => driver.FindElement(By.XPath(CreateXpath));
        private IWebElement skilltextbox => driver.FindElement(By.XPath(skilltextboxXpath));
        private IWebElement SkillLevel => driver.FindElement(By.XPath(SkillLevelXpath));
        private IWebElement SkillLeve => driver.FindElement(By.XPath(SkillLeveXpath));
        private IWebElement ClickOn => driver.FindElement(By.XPath(ClickOnXpath));
        private IWebElement AddSkillCheck1 => driver.FindElement(By.XPath(AddSkillCheckXpath));
        private IWebElement Edit => driver.FindElement(By.XPath(EditXpath));
        private IWebElement EditSkill1 => driver.FindElement(By.XPath(EditSkillXpath));
        private IWebElement DropDown => driver.FindElement(By.XPath(DropDownXpath));
        private IWebElement SelectDropDown => driver.FindElement(By.XPath(SelectDropDownXpath));
        private IWebElement Update => driver.FindElement(By.XPath(UpdateXpath));
        private IWebElement editskill1 => driver.FindElement(By.XPath(EditedSkillXpath));
        private IWebElement Delete => driver.FindElement(By.XPath(DeleteXpath));
        private IWebElement deleteskill2 => driver.FindElement(By.XPath(DeletedSkillXpath));


        //Xpath
        private string xpValueXpath = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span";
        private string SkillTabXpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]";
        private string CreateXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div";
        private string skilltextboxXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input";
        private string SkillLevelXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select";
        private string SkillLeveXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]";
        private string ClickOnXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]";
        private string AddSkillCheckXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]";
        private string EditXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i";
        private string EditSkillXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input";
        private string DropDownXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select";
        private string SelectDropDownXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]";
        private string UpdateXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]";
        private string EditedSkillXpath = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]";
        private string DeleteXpath = "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]";
        private string DeletedSkillXpath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]";
       
        public string GetWelcomeText(IWebDriver driver)
        {
            //get the message as Hii Angel Mary
            WaitHelpers.WaitToBeVisible(driver, "XPath", xpValueXpath, 3);
            //item ui dropdown link 
            return message.Text;
            Thread.Sleep(1500);

        }
    
        public void ClickOnSkillTab(IWebDriver driver)
        {
            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", SkillTabXpath, 3);
            //identify the skill tab and click on it
            SkillTab.Click();
            Thread.Sleep(2000);
        }
        public void AddSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //WaitHelpers.WaitToBeClickable(driver, "XPath", CreateXpath, 5);
            //identify add new button and click on it
            Create.Click();

            //identify skill textbox and type it the skill
            skilltextbox.SendKeys("java");

            // select the drop down list
            SkillLevel.Click();
            Thread.Sleep(2000);
            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath",SkillLeveXpath , 3);
            //select intermediate
            SkillLeve.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", ClickOnXpath, 3);
            //identify the add option and click on the button
            ClickOn.Click();
            Thread.Sleep(3000);


        }
        public string AddSkillCheck(IWebDriver driver)
        {
            return AddSkillCheck1.Text;
        }
      
        public void EditSkill(IWebDriver driver, string Skill)
        {
            //click on the edit option to update skill
            Edit.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditSkillXpath, 3);

            //edit the skill name 
            EditSkill1.Clear();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditSkillXpath, 3);

            EditSkill1.SendKeys(Skill);

            //identify the dropdwon
            DropDown.Click();

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", SelectDropDownXpath, 3);

            //select beginner from the drop down
            SelectDropDown.Click();

            //click on update button
            Update.Click();


        }
        public string SkillEdited(IWebDriver driver)
        {
            Thread.Sleep(2000);
            return editskill1.Text;
        }
       
        public void DeleteSkill(IWebDriver driver)
        {

            //wait helpers
            WaitHelpers.WaitToBeClickable(driver, "XPath", DeleteXpath, 3);

            //identify the remove option and click on delete
            Delete.Click();
            

        }
        public string DeletedSkill(IWebDriver driver)
        {
            return deleteskill2.Text;
        }
    }
       
    
}
