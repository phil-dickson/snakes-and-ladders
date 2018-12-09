using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders
{
    public class Game : IGame
    {
        private readonly IDie die;
        private readonly IBoard board;
        private readonly ITurnProvider turnProvider;

        public Game(IDie die, IBoard board, ITurnProvider turnProvider)
        {
            this.die = die;
            this.board = board;
            this.turnProvider = turnProvider;
        }

        public void CreateNewPlayer(string playerName)
        {
            turnProvider.Add(playerName, new Token(board));
        }

        public Square GetCurrentSquare(string playerName)
        {
            return turnProvider.GetPlayers()[playerName].CurrentPosition;
        }

        public int Roll()
        {
            return die.Roll();
        }

        public void Move(int cellCount)
        {
            turnProvider.GetTurn().Move(cellCount);
        }
    }
}