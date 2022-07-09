Feature: Profile

As a seller of the Mars portal
I would like to Create,Edit and Delete profile details
so that i can see seller's details on the profile page
 

@Login
Scenario: Signin page successful login with valid credentials.
	Given I login to profile page
	Then I should be able to view Profile page



@AddLanguage
Scenario:1 Add language of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I add language
	Then I should be able to view edited language record

@EditLanguage
Scenario Outline:2 Edit language of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I update language '<Language>'
	Then the '<Language>' should be updated
	Examples: 
	| Language |
	| c        |

@DeleteLanguage
Scenario:3 Delete language]of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I delete the language
	Then I should be able to delete language record successfully
	
@AddSkills
Scenario:4 Add skills of the seller in profile detail
	Given I login to profile page
	When I click on skill tab
	And I add skill
	Then I should be able to view edited skill record

@EditSkills
Scenario Outline:5 Edit skills of the seller in profile detail
	Given I login to profile page
	When I click on skill tab
	And I update skill '<Skill>'
	Then '<Skill>' should be updated successfully
	Examples: 
	| Skill |
	| c#    |


@DeleteSkills
Scenario:6 Delete Skills of the seller in profile detail
	Given I login to profile page
	When I click on skill tab
	And I delete the skill
	Then I should be able to delete skill record successfully

@AddEducation
Scenario:7 Add Education of the seller in profile detail
	Given I login to profile page
	When I click on Education tab
	And I add Education
	Then I should be able to view edited Education record

@EditEducation
Scenario Outline:8 Edit Education of the seller in profile detail
	Given I login to profile page
	When I click on Education tab
	And I update Education '<University>','<Degree>'
	Then the '<University>','<Degree>' should be updated
	Examples: 
	| University | Degree     |
	| AUT        | Bioscience |

@DeleteEducation
Scenario:9 Delete Education of the seller in profile detail
	Given I login to profile page
	When I click on Education tab
	And I delete the Education
	Then I should be able to delete Education record successfully
	