using System.Collections.Generic;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders
{
    public class Board : IBoard
    {
        public Board(int startingSquare, int finalSquare, IDictionary<int, ISpecialSquares> specialSquares)
        {
            StartingSquare = startingSquare;
            FinalSquare = finalSquare;
            SpecialSquares = specialSquares;
        }

        public int StartingSquare { get; set; }

        public int FinalSquare { get; set; }

        public IDictionary<int, ISpecialSquares> SpecialSquares { get; }
    }
}