Feature: Login
	As a registered user of Giftrete
	I would like to login
	So that I can use the site

@mytag
Scenario: Login to the site
	Given I navigate to the site
	When I click on login link 
	And I enter username
	And I enter password
	And I click on login button
	Then I am logged in to the site
