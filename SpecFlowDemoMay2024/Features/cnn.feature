Feature: cnn

A short summary of the feature

@tag1
Scenario: Verify CNN headers
	Given I navigate to "https://cnn.com"
	When I clicked on link world
	Then I verify world news

	@sanity
Scenario: Verify CNN footers
	Given I navigate to "https://cnn.com"
	When I clicked on link world
	Then I verify world news
