namespace Random.BL.Numbers
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly System.Random _random = new();
        
        public int GetNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}