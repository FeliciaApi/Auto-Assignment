Feature: Registration
	As a user of the site
	I would like to register
	So that i can login to the site

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	When I click on register link
	And I enter firstname
	And I enter lastname
	And I enter email
	And I enter mobile number
	And I enter password
	And I confirm password
	And I click on signUp
	Then  I should be registered




