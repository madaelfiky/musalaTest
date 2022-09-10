Feature: Musala Tests

@tc:
Scenario: Test Case 1 Check Error message
	Given the user Scroll to Contact us
	And user click on contact us
	And user enters correct data but invalid emai
	And user click on New button
	When user fill the following form details
		| FieldName      | FieldType     | Input      |
		| Distribution Name  | text          | random     |
		
	And user clicks on edit row button
	
	When user fill the following form details
		| FieldName      | FieldType     | Input      |
		| Percentage Allocation  | text          | 100     |

	And user click on save button	
	Then Success message should appears