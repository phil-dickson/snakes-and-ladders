Feature: DieRole

Scenario: Roll the die
	Given the game is started
	When the player rolls a die
	Then the result should be between 1 to 6 inclusive
