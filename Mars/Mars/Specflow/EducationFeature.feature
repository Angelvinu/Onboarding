Feature: EducationFeature

As a seller of the Mars portal
I would like to Create,Edit and Delete Education profile details
so that i can see seller's details on the profile page


@AddEducation
Scenario:3-1 Add Education of the seller in profile detail
	Given I signin to profile page
	When I click on Education tab
	And I add Education
	Then I should be able to view edited Education record

@EditEducation
Scenario Outline:3-2 Edit Education of the seller in profile detail
	Given I signin to profile page
	When I click on Education tab
	And I update Education '<University>','<Degree>'
	Then the '<University>','<Degree>' should be updated
	Examples: 
	| University | Degree     |
	| AUT        | Bioscience |

@DeleteEducation
Scenario:3-3 Delete Education of the seller in profile detail
	Given I signin to profile page
	When I click on Education tab
	And I delete the Education
	Then I should be able to delete Education record successfully
	
