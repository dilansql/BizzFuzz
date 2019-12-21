Feature: OrderNumberLIst
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


@mytag
Scenario Outline: OrderListOfNUmber with a variety of values
	When I execute OrderListOfNUmber and I have '<Value1>' and '<Value2>'
	Then the assert the OrderListOfNUmber result to be '<ExpectedResult>'
	Examples: 
	| Value1 | Value2 | ExpectedResult          |
	| -5     | -4     | -5,-4                   |
	| -10    | -15    | -15,-14,-13,-12,-11,-10 |
	| 1      | 0      | 0,1                     |
	| 10     | 15     | 10,11,12,13,14,15       |            