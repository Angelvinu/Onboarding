Feature: LanguageFeature

As a seller of the Mars portal
I would like to Create,Edit and Delete Language profile details
so that i can see seller's details on the profile page


@AddLanguage
Scenario:1-1 Add language of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I add language
	Then I should be able to view edited language record

@EditLanguage
Scenario Outline:1-2 Edit language of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I update language '<Language>'
	Then the '<Language>' should be updated
	Examples: 
	| Language |
	| c        |

@DeleteLanguage
Scenario:1-3 Delete language]of the seller in profile detail
	Given I login to profile page
	When I click on language tab
	And I delete the language
	Then I should be able to delete language record successfully
	

