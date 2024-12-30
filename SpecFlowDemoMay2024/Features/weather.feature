Feature: weather

A short summary of the feature
Background: 
	Given I navigate to weather site "https://weather.com"


@sanity
Scenario: Verify weather for RCpuram
	#Given I navigate to weather site "https://weather.com"
	When I searched weather for "502032" zipcode
	Then I very results

	@sanity
Scenario: Verify weather for KPHB
	#Given I navigate to weather site "https://weather.com"
	When I searched weather for "500085" zipcode
	Then I very results

Scenario Outline: Verify weather for multiple cities
	#Given I navigate to weather site "https://weather.com"
	When I searched weather for '<zipcode>'
	Then I very results

	Examples: 
	| zipcode |
	| 502032  |
	| 500085  |
	| 21030   |

Scenario: Sample test case
Given I navigate to "https://yahoomail.com"
