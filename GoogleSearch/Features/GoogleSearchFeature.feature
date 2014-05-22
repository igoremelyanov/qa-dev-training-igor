Feature: Google Search
	As an ensd user,
	I would like to visit the google search page
	And then I would like to search an item so that
	I can view thr search results

@mytag
Scenario: Google Search
	Given I am on Google home page
	When I search for text "selenium"
	Then I sholud see the search results
