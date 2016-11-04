Feature: Login
	I login on the website

@login
Scenario Outline: I login on the website
	Given I navigate to login page
	When I enter <username> and <password>
	And I submit logon form
	Then I get home page
Examples: 
| username | password |
| SUPERUSER | BZE1994 |
