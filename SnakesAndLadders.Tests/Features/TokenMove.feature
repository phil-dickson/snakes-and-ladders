Feature: TokenMove

Scenario: Create New Token
	Given the game is started
	When the token is placed on the board for 'New Player'
	Then the token is on square 1
	
Scenario: Move Token
	Given the game is started
	When the token is placed on the board for 'New Player'
	Then the token is on square 1
	When the token is moved 3 spaces
	Then the token is on square 4

Scenario: Move Token Multiple Times
	Given the game is started
	When the token is placed on the board for 'New Player'
	When the token is moved 3 spaces
	Then the token is on square 4
	When the token is moved 4 spaces
	Then the token is on square 8
