using System.Collections.Generic;
using NUnit.Framework;
using SnakesAndLadders.Enums;
using SnakesAndLadders.Interfaces;
using SnakesAndLadders.SpecialSquares;
using TechTalk.SpecFlow;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SnakesAndLadders.Tests.Bindings
{
    [Binding]
    public class GameSteps
    {
        private Game game;
        private int dieOutput;
        private string currentPlayer;
        private SquareState currentSquareState;

        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            var specialSquares = new Dictionary<int, ISpecialSquares>
            {
                { 100, new WinningSquare() },
                { 101, new MaxSquare() }
            };
            game = new Game(new Die(), new Board(1, 100, specialSquares), new TurnProvider());
        }

        [When(@"the player rolls a die")]
        public void WhenThePlayerRollsADie()
        {
            dieOutput = game.Roll();
        }

        [Then(@"the result should be between (.*) to (.*) inclusive")]
        public void ThenTheResultShouldBeBetweenToInclusive(int min, int max)
        {
            Assert.IsTrue(dieOutput >= min && dieOutput <= max);
        }

        [When(@"the token is placed on the board for '(.*)'")]
        public void WhenTheTokenIsPlacedOnTheBoard(string name)
        {
            currentPlayer = name;
            game.CreateNewPlayer(currentPlayer);
        }

        [When(@"the token is moved (.*) spaces")]
        public void WhenTheTokenIsMovedSpaces(int squareCount)
        {
            game.Move(squareCount);
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int squarePosition)
        {
            var currentSquare = game.GetCurrentSquare(currentPlayer);
            currentSquareState = currentSquare.SquareState;

            Assert.AreEqual(squarePosition, currentSquare.SquarePosition);
        }

        [Then(@"the player has won the game")]
        public void ThenThePlayerHasWonTheGame()
        {
            Assert.AreEqual(SquareState.Winning, currentSquareState);
        }

        [Then(@"the player has not won the game")]
        public void ThenThePlayerHasNotWonTheGame()
        {
            Assert.AreNotEqual(SquareState.Winning, currentSquareState);
        }
    }
}
