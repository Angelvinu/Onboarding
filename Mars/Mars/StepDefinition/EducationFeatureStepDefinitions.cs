using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinition
{
    [Binding]
    public class EducationFeatureStepDefinitions : CommonDriver
    {
        LoginPage LoginPageObj;
        EducationPage EducationPageObj;


        [Given(@"I signin to profile page")]
        public void GivenISigninToProfilePage()
        {
            driver = new ChromeDriver();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"I click on Education tab")]
        public void WhenIClickOnEducationTab()
        {
            EducationPageObj.ClickOnEducationTab(driver);
        }

        [When(@"I add Education")]
        public void WhenIAddEducation()
        {
            EducationPageObj.AddEducation(driver);
        }

        [Then(@"I should be able to view edited Education record")]
        public void ThenIShouldBeAbleToViewEditedEducationRecord()
        {
            string NewCountry = EducationPageObj.NewCountry(driver).ToString();
            string NewUniversity = EducationPageObj.NewUniversity(driver).ToString();
            string NewTitle = EducationPageObj.NewTitle(driver).ToString();
            string NewDegree = EducationPageObj.NewDegree(driver).ToString();
            string NewYear = EducationPageObj.NewYear(driver).ToString();

            Assert.That(NewCountry == "New Zealand", "Added country doesnot match sucecssfully");
            Assert.That(NewUniversity == "Unitec", "Added University doesnot match successfully");
            Assert.That(NewTitle == "B.Tech", "Added Title doesnot match successfully");
            Assert.That(NewDegree == "Bachelor", "Added Degree doesnot match successfully");
            Assert.That(NewYear == "2019", "Added Year doesnot match successfully");
        }

        [When(@"I update Education '([^']*)','([^']*)'")]
        public void WhenIUpdateEducation(string p0, string p1)
        {
            EducationPageObj.EditEducation(driver, p0, p1);
        }

        [Then(@"the '([^']*)','([^']*)' should be updated")]
        public void ThenTheShouldBeUpdated(string aUT, string bioscience)
        {
            string EditedUniversity = EducationPageObj.EditedUniversity(driver).ToString();
            string EditedDegree = EducationPageObj.EditedDegree(driver).ToString();
            string EditedYear = EducationPageObj.EditedYear(driver).ToString();

            Assert.That(EditedUniversity == "AUT", "University was not updated successfully");
            Assert.That(EditedDegree == "Bioscience", "Degree was not updated successfully");
            Assert.That(EditedYear == "2020", "Year was not updated successfully");
        }

        [When(@"I delete the Education")]
        public void WhenIDeleteTheEducation()
        {
            EducationPageObj.DeleteEducation(driver);
        }

        [Then(@"I should be able to delete Education record successfully")]
        public void ThenIShouldBeAbleToDeleteEducationRecordSuccessfully()
        {
            string DeletedUniversity = EducationPageObj.DeletedUniversity(driver).ToString();
            Assert.That(DeletedUniversity != "AUT", "University was not deleted successfully");
        }

        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

    }
}
