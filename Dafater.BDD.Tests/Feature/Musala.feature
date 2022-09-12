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
	
Scenario: Test Case 3 Check Email Error message and upload CV
	Given the user Click ‘Careers’ tap from the top
	And Click ‘Check our open positions’ button and verifies URL
	And From the dropdown ‘Select location’ select ‘Anywhere’
	And Choose open position by name and apply
	And Enter wrong details
	And Upload a CV document, and click ‘Send’ button
	Then validation message should appears under email field

	Scenario: Test Case 4 Print in the console the list with available positions by city 
	Given the user Click ‘Careers’ tap from the top
	And Click ‘Check our open positions’ button and verifies URL
	And From the dropdown ‘Select location’ select ‘Anywhere’
	Then Print jobs
	
