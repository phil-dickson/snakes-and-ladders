using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders.SpecialSquares
{
    public class MaxSquare : ISpecialSquares
    {
        public Square GetPosition(Square oldPosition, int newPosition)
        {
            return oldPosition;
        }
    }
}