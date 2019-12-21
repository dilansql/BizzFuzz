Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Postive numbers small range
	When I execute the FizzBuzzIterator for the lower range of '1' and a higher range of '10'
	Then I assert the result to be:
	| Number | Result |
	| 1      | 1      |
	| 2      | 2      |
	| 3      | Fizz   |
	| 4      | 4      |
	| 5      | Buzz   |
	| 6      | Fizz   |
	| 7      | 7      |
	| 8      | 8      |
	| 9      | Fizz   |
	| 10     | Buzz   |
	
	

