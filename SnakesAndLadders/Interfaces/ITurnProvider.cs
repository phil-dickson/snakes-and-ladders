using System.Collections.Generic;

namespace SnakesAndLadders.Interfaces
{
    public interface ITurnProvider
    {
        void Add(string name, Token value);
        IDictionary<string, Token> GetPlayers();
        Token GetTurn();
    }
}