using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinition 
 {
    [Binding]
    public class LanguageFeatureStepDefinitions :CommonDriver
    {
        LoginPage LoginPageObj;
        LanguagePage LanguagePageObj;


        [Given(@"I login to profile page")]
        public void GivenILoginToProfilePage()
        {
            driver = new ChromeDriver();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"I click on language tab")]
        public void WhenIClickOnLanguageTab()
        {
            LanguagePageObj.ClickOnLanguageTab(driver);
        }

        [When(@"I add language")]
        public void WhenIAddLanguage()
        {
            LanguagePageObj.AddLanguage(driver);
        }

        [Then(@"I should be able to view edited language record")]
        public void ThenIShouldBeAbleToViewEditedLanguageRecord()
        {
            string addLang = LanguagePageObj.AddLang(driver).ToString();

            Assert.That(addLang == "Java", "language doesnot match");
        }

        [When(@"I update language '([^']*)'")]
        public void WhenIUpdateLanguage(string p0)
        {
            LanguagePageObj.EditLanguage(driver, p0);
        }

        [Then(@"the '([^']*)' should be updated")]
        public void ThenTheShouldBeUpdated(string p0)
        {
            string UpdateLang = LanguagePageObj.UpdateLang(driver).ToString();
            Assert.That(UpdateLang == p0, "language doesnot match");
        }

        [When(@"I delete the language")]
        public void WhenIDeleteTheLanguage()
        {
            LanguagePageObj.DeleteLanguage(driver);
        }

        [Then(@"I should be able to delete language record successfully")]
        public void ThenIShouldBeAbleToDeleteLanguageRecordSuccessfully()
        {
            string DelLang = LanguagePageObj.DelLang(driver).ToString();
            Assert.That(DelLang != "c", "language was not deleted successfully");
        }

        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
    }
}



