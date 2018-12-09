using System;
using System.Collections.Generic;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders
{
    public class Token : IToken
    {
        private readonly IDictionary<int, ISpecialSquares> specialSquares;
        private readonly int maxCell;

        public Token(IBoard board)
        {
            specialSquares = board.SpecialSquares;
            maxCell = board.FinalSquare + 1;
            CurrentPosition = new Square(board.StartingSquare);
        }

        public Square CurrentPosition { get; set; }

        public Square Move(int count)
        {
            var newPosition = Math.Min(maxCell, CurrentPosition.SquarePosition + count);

            if (specialSquares.ContainsKey(newPosition))
            {
                CurrentPosition = specialSquares[newPosition].GetPosition(CurrentPosition, newPosition);
                return CurrentPosition;
            }

            CurrentPosition = new Square(newPosition);
            return CurrentPosition;
        }
    }
}