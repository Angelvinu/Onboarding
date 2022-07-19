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

        public IWebDriver driver;

        public EducationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //find elements by XPath
        private IWebElement EducationTab => driver.FindElement(By.XPath(EducationTabXpath));
        private IWebElement AddNew => driver.FindElement(By.XPath(AddNewXpath));
        private IWebElement AddCollage => driver.FindElement(By.XPath(AddCollageXpath));
        private IWebElement SelectCollage => driver.FindElement(By.XPath(SelectCollageXpath));
        private IWebElement SelectCountry => driver.FindElement(By.XPath(SelectCountryXpath));
        private IWebElement SelectTitle => driver.FindElement(By.XPath(SelectTitleXpath));
        private IWebElement SelectCourse => driver.FindElement(By.XPath(SelectCourseXpath));
        private IWebElement EnterDegree => driver.FindElement(By.XPath(EnterDegreeXpath));
        private IWebElement EnterYear => driver.FindElement(By.XPath(EnterYearXpath));
        private IWebElement SelectYear => driver.FindElement(By.XPath(SelectYearXpath));
        private IWebElement ClickAdd => driver.FindElement(By.XPath(ClickAddXpath));
        private IWebElement NewCountry1 => driver.FindElement(By.XPath(NewCountryXpath));
        private IWebElement NewUniversity1 => driver.FindElement(By.XPath(NewUniversityXpath));
        private IWebElement NewTitle1 => driver.FindElement(By.XPath(NewTitleXpath));
        private IWebElement NewDegree1 => driver.FindElement(By.XPath(NewDegreeXpath));
        private IWebElement NewYear1 => driver.FindElement(By.XPath(NewYearXpath));
        private IWebElement EditEdu => driver.FindElement(By.XPath(EditEduXpath));
        private IWebElement collegeEdit => driver.FindElement(By.XPath(collegeEditXpath));
        private IWebElement TitleEdit => driver.FindElement(By.XPath(TitleEditXpath));
        private IWebElement YrOfGraduation => driver.FindElement(By.XPath(YrOfGraduationXpath));
        private IWebElement YearEdit => driver.FindElement(By.XPath(YearEditXpath));
        private IWebElement UpdateButton => driver.FindElement(By.XPath(UpdateButtonXpath));
        private IWebElement EditedUniversity2 => driver.FindElement(By.XPath(EditedUniversityXpath));

        private IWebElement EditedDegree2 => driver.FindElement(By.XPath(EditedDegreeXpath));
        private IWebElement EditedYear2 => driver.FindElement(By.XPath(EditedYearXpath));
        private IWebElement DeletedEdu => driver.FindElement(By.XPath(DeletedEduXpath));
        private IWebElement DeletedUniversity3 => driver.FindElement(By.XPath(DeletedUniversityXpath));



        //Xpath
        private string EducationTabXpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]";
        private string AddNewXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div";
        private string AddCollageXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input";
        private string SelectCollageXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select";
        private string SelectCountryXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]";
        private string SelectTitleXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select";
        private string SelectCourseXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]";
        private string EnterDegreeXpath = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input";
        private string EnterYearXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select";
        private string SelectYearXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]";
        private string ClickAddXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]";
        private string NewCountryXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[1]";
        private string NewUniversityXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[2]";
        private string NewTitleXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[3]";
        private string NewDegreeXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr[last()]/td[4]";
        private string NewYearXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[5]";
        private string EditEduXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[1]/i";
        private string collegeEditXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[1]/div[1]/input";
        private string TitleEditXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[2]/input";
        private string YrOfGraduationXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[3]/select";
        private string YearEditXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[3]/select/option[4]";
        private string UpdateButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[3]/input[1]";
        private string EditedUniversityXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[2]";
        private string EditedDegreeXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[4]";
        private string EditedYearXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[5]";
        private string DeletedEduXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i";
        private string DeletedUniversityXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]";





        public void ClickOnEducationTab(IWebDriver driver)
        {
            //Navigate to education tab
            
            WaitHelpers.WaitToBeClickable(driver, "XPath", EducationTabXpath, 5);
            EducationTab.Click();

        }
        public void AddEducation(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddNewXpath, 10);
            //click on add new in education tab
            AddNew.Click();
           
            //Enter College/University name
            AddCollage.SendKeys("Unitec");
           
            //country of the college/ university is selecting 
            SelectCollage.Click();
          
            //New Zealand is selecting as the country
            SelectCountry.Click();
            
            //select Title
            SelectTitle.Click();
          
            //selecting B-Tech as course
            SelectCourse.Click();
            
            //Enter Degree
            EnterDegree.SendKeys("Bachelor");
          
            //click on Year of graduation
            EnterYear.Click();
           
            // Select year of graduation
            SelectYear.Click();
            
            //Click on Add button
            ClickAdd.Click();
            Thread.Sleep(2000);

        }
        public string NewCountry(IWebDriver driver)
        {
            return NewCountry1.Text;

        }
        public string NewUniversity(IWebDriver driver)
        {
         return NewUniversity1.Text;
        }
        public string NewTitle(IWebDriver driver)
        {
            return NewTitle1.Text;
        }

        public string NewDegree(IWebDriver driver)
        {
            return NewDegree1.Text;
        }
        public string NewYear(IWebDriver driver)
        {
            return NewYear1.Text;
        }
        public void EditEducation(IWebDriver driver, string University, string Degree)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditEduXpath, 4);

            //Edit button in education click
            EditEdu.Click();
           
            //Edit University name
            collegeEdit.Clear();
            collegeEdit.SendKeys(University);
          
            //selecting the title and edit title
            TitleEdit.Clear();
            TitleEdit.SendKeys(Degree);
          
            //click on Year of graduation
            YrOfGraduation.Click();
            
            //edit the year of graduation
            YearEdit.Click();

            //Click on update
            UpdateButton.Click();
            Thread.Sleep(1000);
        }
        public string EditedUniversity(IWebDriver driver)
        {
            return EditedUniversity2.Text;
        }
        public string EditedDegree(IWebDriver driver)
        {
            return EditedDegree2.Text;
        }
        public string EditedYear(IWebDriver driver)
        { 
            return EditedYear2.Text;
        }


        public void DeleteEducation(IWebDriver driver)
        {
            try
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", DeletedEduXpath, 5);
                DeletedEdu.Click();
            }

            catch (Exception)
            {
                Assert.Fail("Education record doesnot exsit");
            }
        }
        
        public string DeletedUniversity(IWebDriver driver)
        {
            return DeletedUniversity3.Text;
        }
        

    }
}
