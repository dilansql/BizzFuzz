Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: FizzBuzz with a value of 3
	Given I have a '3'
	When I execute Fizbuzz
	Then the assert the Fizbuzz result to be 'Fizz'

Scenario Outline: FizzBuzz with a variety of values
	Given I have a '<Value>'
	When I execute Fizbuzz
	Then the assert the Fizbuzz result to be '<Result>'
	Examples: 
		| Value | Result   |
		| -16   | -16      |
		| -15   | FizzBuzz |
		| -14   | -14      |
		| -13   | -13      |
		| -12   | Fizz     |
		| -11   | -11      |
		| -10   | Buzz     |
		| -9    | Fizz     |
		| -8    | -8       |
		| -7    | -7       |
		| -6    | Fizz     |
		| -5    | Buzz     |
		| -4    | -4       |
		| -3    | Fizz     |
		| -2    | -2       |
		| -1    | -1       |
		| 0     | 0        |
		| 1     | 1        |
		| 2     | 2        |
		| 3     | Fizz     |
		| 4     | 4        |
		| 5     | Buzz     |
		| 6     | Fizz     |
		| 7     | 7        |
		| 8     | 8        |
		| 9     | Fizz     |
		| 10    | Buzz     |
		| 11    | 11       |
		| 12    | Fizz     |
		| 13    | 13       |
		| 14    | 14       |
		| 15    | FizzBuzz |
		| 16    | 16       |

#Scenario: Add two numbers
#	Given I have entered the 'lowestNumber' and the 'HighestNumber'
#	And the number is divisable by 'DivisableNumber'
#	Then the result should be 'Ouput'
#
#Scenario Outline: Add two numbers
#	Given I have entered the 'lowestNumber' and the 'HighestNumber'
#	And the number is divisable by 'DivisableNumber'
#	Then the result should be '<Ouput>'
#
#	Examples:
#		|LowestNumber| HighestNumber|DivisableNumber|Ouput|