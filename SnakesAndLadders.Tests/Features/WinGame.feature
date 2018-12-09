Feature: WinGame

Scenario: Player wins the game
	Given the game is started
	When the token is placed on the board for 'New Player'
	When the token is moved 96 spaces
	Then the token is on square 97
	When the token is moved 3 spaces
	Then the token is on square 100
	And the player has won the game

Scenario: Player does not win the game
	Given the game is started
	When the token is placed on the board for 'New Player'
	When the token is moved 96 spaces
	Then the token is on square 97
	When the token is moved 4 spaces
	Then the token is on square 97
	And the player has not won the game
