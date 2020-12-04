Feature: Calculate with two numbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@mytag
Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 7
	When the two numbers are multiplied
	Then the result should be 35

@mytag
Scenario: Subtract two numbers
	Given the first number is 50
	And the second number is 34
	When the two numbers are subtracted
	Then the result should be 16

@mytag
Scenario: Divide two numbers
	Given the first number is 35
	And the second number is 7
	When the two numbers are divided
	Then the result should be 5
