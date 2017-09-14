Feature: SearchPlace_ByDestination
	In order to interact with the Booking.com application
	As a user
	I want to search a place by destination

@mytag
Scenario Outline: Search Place by Destination
	Given I am access the application
	And I have opened Accommodations Page
	When I search by field <destination>
	Then the page returns record found
Examples: 
	| destination     |
	| New York City   |
	| California, USA |
