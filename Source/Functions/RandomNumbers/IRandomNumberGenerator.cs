using System;

namespace Source.Functions.RandomNumbers
{
    public interface IRandomNumberGenerator
    {
        int GetRandomNumber(int start, int exclusiveEnd);
    }

    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random _random = new(); 
        
        public int GetRandomNumber(int start, int exclusiveEnd)
        {
            return _random.Next(start, exclusiveEnd);
        }
    }
}