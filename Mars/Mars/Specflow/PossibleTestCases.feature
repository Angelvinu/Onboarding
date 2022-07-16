Feature: PossibleTestCases

Feature: Profile

As a seller of the Mars portal
I would like to Create,Edit and Delete profile details
so that i can see seller's details on the profile page
 

@Login
Scenario: Signin page successful login with valid credentials.
	Given I login to profile page
	Then I should be able to view Profile page



@AddLanguage
Scenario: Add language of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I add language
	Then I should be able to view edited language record

@EditLanguage
Scenario Outline: Edit language of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I update language '<Language>'
	Then the '<Language>' should be updated
	Examples: 
	| Language |
	| c        |

@DeleteLanguage
Scenario: Delete language]of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I delete the language
	Then I should be able to delete language record successfully
	
@AddSkills
Scenario: Add skills of the seller in profile detail
	Given I login to profile page
	When I click on skill tab
	And I add skill
	Then I should be able to view edited skill record

@EditSkills
Scenario Outline: Edit skills of the seller in profile detail
	Given I login to profile page
	When I click on skill tab
	And I update skill '<Skill>'
	Then '<Skill>' should be updated successfully
	Examples: 
	| Skill |
	| c#    |


@DeleteSkills
Scenario: Delete Skills of the seller in profile detail
	Given I login to profile page
	When I click on skill tab
	And I delete the skill
	Then I should be able to delete skill record successfully

@AddEducation
Scenario: Add Education of the seller in profile detail
	Given I login to profile page
	When I click on Education tab
	And I add Education
	Then I should be able to view edited Education record

@EditEducation
Scenario Outline: Edit Education of the seller in profile detail
	Given I login to profile page
	When I click on Education tab
	And I update Education '<University>','<Degree>'
	Then the '<University>','<Degree>' should be updated
	Examples: 
	| University | Degree     |
	| AUT        | Bioscience |

@DeleteEducation
Scenario: Delete Education of the seller in profile detail
	Given I login to profile page
	When I click on Education tab
	And I delete the Education
	Then I should be able to delete Education record successfully

	
@Editprofilename
Scenario: Edit Profile record of the seller in profile detail
	Given I login to profile page
	When I edit first name and last name 
	And I click on save
	Then I should be able to view profile name updated

	@Editavailability
Scenario:Edit available timings and hours of the seller in profile detail
	Given I login to profile page
	When I select availability from the drop down 
	When I edit available timings and update hours 
	Then I should get a availability updated popup message 
	
@AddCertification
Scenario: Add Certification of the seller in profile detail
	Given I login to profile page
	When I click on Certification tab
	And I add Certification
	Then I should be able to view edited Certification record

@EditCertification
Scenario Outline: Edit Certification of the seller in profile detail
	Given I login to profile page
	When I click on Certification tab
	And I update Certification 
	Then I should be able to view updated Certification

@DeleteCertification
Scenario: Delete Certification of the seller in profile detail
	Given I login to profile page
	When I click on Certification tab
	And I delete the Certification
	Then I should be able to delete Certification record successfully