using System.Collections.Generic;
using System.Linq;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders
{
    public class TurnProvider : ITurnProvider
    {
        private readonly IDictionary<int, KeyValuePair<string, Token>> turns;
        private int currentTurn;


        public TurnProvider()
        {
            turns = new Dictionary<int, KeyValuePair<string, Token>>();
            currentTurn = 0;
        }

        public void Add(string name, Token value)
        {
            turns.Add(turns.Count, new KeyValuePair<string, Token>(name, value));
        }

        public Token GetTurn()
        {
            var currentToken = turns[currentTurn];

            var nextTurn = currentTurn + 1;
            if (nextTurn > turns.Count - 1)
            {
                nextTurn = 0;
            }

            currentTurn = nextTurn;

            return currentToken.Value;
        }

        public IDictionary<string, Token> GetPlayers()
        {
            return turns.Values.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}