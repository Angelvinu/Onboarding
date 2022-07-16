Feature: SkillFeature

As a seller of the Mars portal
I would like to Create,Edit and Delete Skill profile details
so that i can see seller's details on the profile page


@AddSkills
Scenario:2-1 Add skills of the seller in profile detail
	Given I logged to profile page
	When I click on skill tab
	And I add skill
	Then I should be able to view edited skill record

@EditSkills
Scenario Outline:2-2 Edit skills of the seller in profile detail
	Given I logged to profile page
	When I click on skill tab
	And I update skill '<Skill>'
	Then '<Skill>' should be updated successfully
	Examples: 
	| Skill |
	| c#    |


@DeleteSkills
Scenario:2-3 Delete Skills of the seller in profile detail
	Given I logged to profile page
	When I click on skill tab
	And I delete the skill
	Then I should be able to delete skill record successfully