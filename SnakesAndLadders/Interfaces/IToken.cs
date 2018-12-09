namespace SnakesAndLadders.Interfaces
{
    public interface IToken
    {
        Square CurrentPosition { get; set; }

        Square Move(int count);
    }
}