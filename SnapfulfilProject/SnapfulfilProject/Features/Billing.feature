Feature: Billing
	I open billing page

@Billing
Scenario Outline: I open billing page
	Given I login the web site
	When I open menu
	And I click submenu 'billing'
	Then I get billing page
