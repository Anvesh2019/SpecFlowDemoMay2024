Feature: Amazon

A short summary of the feature

@smoke
Scenario: Vefiry Home page links navigation
	Given I navigate to "https://amazon.com"
	When I click on "Help" link
	Then I verify related page is loaded

#Scenario: Verify search results in Amazon
#Given I navigate to "https://amazon.com"
#When I search for item "Sonytv 55 inch"
#Then I verify "Sonytv 55 inch" results are displayed
	

Scenario: Verify search results in Amazon
Given I navigate to "https://amazon.com"
When I search for item '<SearchItem>'
Then I verify '<SearchResults>' results are displayed
Examples: 
| SearchItem | SearchResults |
| Sonytv 55 inch           |        Sonytv 55 inch       |
| Philipstv 55 inch           |        Philipstv 55 inch       |
