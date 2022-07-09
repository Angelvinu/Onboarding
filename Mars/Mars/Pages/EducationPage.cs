using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class EducationPage
    {

        public void ClickOnEducationTab(IWebDriver driver)
        {

            //Navigate to education tab
            string EducationTab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]";
            WaitHelpers.WaitToBeClickable(driver, "XPath", EducationTab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

        }
        public void AddEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //click on add new in education tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            //Enter College/University name
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys("Unitec");
            //country of the college/ university is selecting 
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).Click();
            //New Zealand is selecting as the country
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]")).Click();
            //select Title
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).Click();
            //selecting B-Tech as course
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]")).Click();
            //Enter Degree
            driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Bachelor");
            //click on Year of graduation
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();
            // Select year of graduation
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]")).Click();
            //Click on Add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
            Thread.Sleep(2000);

        }
        public string NewCountry(IWebDriver driver)
        {
            IWebElement NewCountry = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[1]"));
            return NewCountry.Text;

        }
        public string NewUniversity(IWebDriver driver)
        {
            IWebElement NewUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[2]"));
            return NewUniversity.Text;
        }
        public string NewTitle(IWebDriver driver)
        {
            IWebElement NewTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[3]"));
            return NewTitle.Text;

        }

        public string NewDegree(IWebDriver driver)
        {
            IWebElement NewDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[4]"));
            return NewDegree.Text;

        }
        public string NewYear(IWebDriver driver)
        {
            IWebElement NewYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[5]"));
            return NewYear.Text;


        }
        public void EditEducation(IWebDriver driver, string University, string Degree)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[1]/i", 4);

            //Edit button in education click
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[1]/i")).Click();
            //Edit University name
            IWebElement collegeEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[1]/div[1]/input"));
            collegeEdit.Clear();
            collegeEdit.SendKeys(University);
            //selecting the title and edit title
            IWebElement TitleEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[2]/input"));
            TitleEdit.Clear();
            TitleEdit.SendKeys(Degree);
            //click on Year of graduation
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[3]/select")).Click();
            //edit the year of graduation
            IWebElement YearEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[3]/select/option[4]"));
            YearEdit.Click();

            //Click on update
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[3]/input[1]")).Click();
            Thread.Sleep(1000);
        }
        public string EditedUniversity(IWebDriver driver)
        {
            IWebElement EditedUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[2]"));
            return EditedUniversity.Text;
        }
        public string EditedDegree(IWebDriver driver)
        {
            IWebElement EditedDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[4]"));
            return EditedDegree.Text;
        }
        public string EditedYear(IWebDriver driver)
        {
            IWebElement EditedYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[5]"));
            return EditedYear.Text;
        }


        public void DeleteEducation(IWebDriver driver)
        {
            try
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i", 5);
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i")).Click();
            }

            catch (Exception)
            {
                Assert.Fail("Education row was not successfully deleted");
            }
        }

        

    }
}
