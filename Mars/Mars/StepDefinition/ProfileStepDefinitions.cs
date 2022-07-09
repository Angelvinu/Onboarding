using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        ProfilePage ProfilePageObj = new ProfilePage();
        LoginPage LoginPageObj = new LoginPage();
        [Given(@"I login to profile page")]
        public void GivenILoginToProfilePage()
        {
            driver = new ChromeDriver();
            LoginPageObj.LoginSteps(driver);
        }

        [Then(@"I should be able to view Profile page")]
        public void ThenIShouldBeAbleToViewProfilePage()
        {
           string message = ProfilePageObj.GetWelcomeText(driver);
            Assert.That(message == "Hi Angel Mary", "not matched");
        }



        [When(@"I click on language tab")]
        public void WhenIClickOnLanguageTab()
        {
            
            ProfilePageObj.ClickOnLanguageTab(driver);
        }

        [When(@"I add language")]
        public void WhenIAddLanguage()
        {
            ProfilePageObj.AddLanguage(driver);
        }

        [Then(@"I should be able to view edited language record")]
        public void ThenIShouldBeAbleToViewEditedLanguageRecord()
        {
            string addLang = ProfilePageObj.AddLang(driver).ToString();
            
            Assert.That(addLang == "Java", "language doesnot match");
            
        }
        [When(@"I update language '([^']*)'")]
        public void WhenIUpdateLanguage(string p0)
        {
            ProfilePageObj.EditLanguage(driver, p0);
        }

        [Then(@"the '([^']*)' should be updated")]
        public void ThenTheShouldBeUpdated(string p0)
        {
           
        string UpdateLang = ProfilePageObj.UpdateLang(driver).ToString();
        Assert.That(UpdateLang == p0, "language doesnot match");
        
        }

       
        [When(@"I delete the language")]
        public void WhenIDeleteTheLanguage()
        {
            ProfilePageObj.DeleteLanguage(driver);
        }

        [Then(@"I should be able to delete language record successfully")]
        public void ThenIShouldBeAbleToDeleteLanguageRecordSuccessfully()
        {

            

        }
      
        SkillPage SkillPageObj = new SkillPage();

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
            string AddSkillLevel = SkillPageObj.AddSkillLevel(driver).ToString();
            Assert.That(AddSkillCheck == "java", "Skill doesnot match");
            Assert.That(AddSkillLevel == "Intermediate", "skill level doesnot match");
        }
        [When(@"I update skill '([^']*)'")]
        public void WhenIUpdateSkill(string p0)
        {
            SkillPageObj.EditSkill(driver,p0);
        }

        [Then(@"'([^']*)' should be updated successfully")]
        public void ThenShouldBeUpdatedSuccessfully(string p0)
        {
            string SkillEdited = SkillPageObj.SkillEdited(driver);
            //string SkillLevel = SkillPageObj.SkillLevel(driver).ToString();
            Assert.That(SkillEdited == p0, "skill doesnot match");
            //Assert.That(SkillLevel == "Beginner", "skill level doesnot match");
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
        EducationPage EducationPageObj = new EducationPage();

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
            Assert.That(NewTitle == "B.Tech","Added Title doesnot match successfully");
            Assert.That(NewDegree == "Bachelor", "Added Degree doesnot match successfully");
            Assert.That(NewYear == "2019", "Added Year doesnot match successfully");

        }

        [When(@"I update Education '([^']*)','([^']*)'")]
        public void WhenIUpdateEducation(string p0, string p1)
        {
            EducationPageObj.EditEducation(driver,p0,p1);
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
         
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }

    }
}
