using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinition
{
    [Binding]
    public class SkillFeatureStepDefinitions : CommonDriver
    {
        LoginPage LoginPageObj;
        SkillPage SkillPageObj;


        [Given(@"I logged to profile page")]
        public void GivenILoggedToProfilePage()
        {
            driver = new ChromeDriver();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"I click on skill tab")]
        public void WhenIClickOnSkillTab()
        {
            SkillPageObj.ClickOnSkillTab(driver);
        }

        [When(@"I add skill")]
        public void WhenIAddSkill()
        {
            SkillPageObj.AddSkill(driver);
        }

        [Then(@"I should be able to view edited skill record")]
        public void ThenIShouldBeAbleToViewEditedSkillRecord()
        {
            string AddSkillCheck = SkillPageObj.AddSkillCheck(driver).ToString();
           
            Assert.That(AddSkillCheck == "java", "Skill doesnot match");
           
        }

        [When(@"I update skill '([^']*)'")]
        public void WhenIUpdateSkill(string p0)
        {
            SkillPageObj.EditSkill(driver, p0);
        }

        [Then(@"'([^']*)' should be updated successfully")]
        public void ThenShouldBeUpdatedSuccessfully(string p0)
        {

            string SkillEdited = SkillPageObj.SkillEdited(driver);
            Assert.That(SkillEdited == p0, "skill doesnot match");
        }

        [When(@"I delete the skill")]
        public void WhenIDeleteTheSkill()
        {
            SkillPageObj.DeletedSkill(driver);
        }

        [Then(@"I should be able to delete skill record successfully")]
        public void ThenIShouldBeAbleToDeleteSkillRecordSuccessfully()
        {
            string DeletedSkill = SkillPageObj.DeletedSkill(driver).ToString();
            Assert.That(DeletedSkill == "c#", "skill was not deleted sucessfully");
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
