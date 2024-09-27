Feature: Google

Google test cases

@RegressionTesting
Scenario: Search for Bus ticket
	Given I navigate to <url>
	When I searched ticket from <fromCity> to <toCity>
	Then I verify search results
	And I verify the test results for google
	Examples: 
	| url                 | fromCity   | toCity    |
	| https://Abhibus.com | Hyderabad  | Chirala   |
	| https://Abhibus.com | Vijayawada | Hyderabad |
	


@RegressionTesting
Scenario: Search in google site
Given I navigate to Google site
When I search for '<country>'
Then I verify search results are displayed for '<country>'
Examples: 
| country |
| India   |
| China   |
| Japan   |

Scenario: Search for country
Given I navigate to "https://google.com"
When I entered "userid" and "password"
Then I verify Search results displayed

Scenario: Search in Google
Given I navigate to <site>
|site|
| https://google.com |
When I search for <keyword>
|India|
Then I verify Search results displayed
And i click on Search button



@RegressionTesting
Scenario: Search in Amazon
Given I navigate to Amazon site
When I search for TV '<model>'
Then I verify search results are displayed for TV '<model>'
Examples: 
| model |
| Sony   |
| Philips   |
| TCL   |


Scenario: Verify SonyTV search
Given I navigate to "https://google.com"
When I search for "SonyTV 55 Inch"
Then I verify the search results

