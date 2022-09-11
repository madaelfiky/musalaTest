Feature: Musala Tests

@tc:
Scenario: Test Case 1 Check Error message
	Given the user Scroll to Contact us
	And user click on contact us
	When user enters correct data but invalid email
	Then validation message should appears under email field

	
Scenario: Test Case 2 Check URLs and Profile Picture
	Given the user Click ‘Company’ tap from the top and verifies URL
	And Verify that there is ‘Leadership’ section
	And Click the Facebook link from the footer
	Then Verify that the correct URL and Musala Soft profile picture appears
	

