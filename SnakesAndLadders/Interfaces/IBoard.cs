using System.Collections.Generic;

namespace SnakesAndLadders.Interfaces
{
    public interface IBoard
    {
        int FinalSquare { get; set; }
        IDictionary<int, ISpecialSquares> SpecialSquares { get; }
        int StartingSquare { get; set; }
    }
}