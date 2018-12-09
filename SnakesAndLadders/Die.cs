using System;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders
{
    public class Die : IDie
    {
        private const int MinValue = 1;
        private const int MaxValue = 6;
        private readonly Random random;

        public Die()
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        public int Roll()
        {
            return random.Next(MinValue, MaxValue);
        }
    }
}
