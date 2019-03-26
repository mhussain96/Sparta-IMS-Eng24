Feature: Authentication
	In order to gain access to the rest of the app
	As a user
	I want to be able to see the home page

Scenario: Authentication
	Given I am on the registration page
	And I have entered the valid details in all the fields  
	When I press sign in
	Then I should be on the appropriate page