using SnakesAndLadders.Enums;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders.SpecialSquares
{
    public class WinningSquare : ISpecialSquares
    {
        public Square GetPosition(Square oldPosition, int newPosition)
        {
            return new Square(newPosition, SquareState.Winning);
        }
    }
}