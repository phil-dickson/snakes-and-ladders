namespace SnakesAndLadders.Interfaces
{
    public interface IGame
    {
        void CreateNewPlayer(string playerName);
        Square GetCurrentSquare(string playerName);
        void Move(int cellCount);
        int Roll();
    }
}