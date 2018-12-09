using SnakesAndLadders.Enums;

namespace SnakesAndLadders
{
    public class Square
    {
        public Square(int squarePosition, SquareState squareState = SquareState.Normal)
        {
            SquarePosition = squarePosition;
            SquareState = squareState;
        }

        public int SquarePosition { get; set; }

        public SquareState SquareState { get; set; }
    }
}