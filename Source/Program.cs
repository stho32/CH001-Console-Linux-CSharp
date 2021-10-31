using System;

namespace Source
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumberGenerator = new Random();
            var randomNumber = randomNumberGenerator.Next() % 10;
            Console.WriteLine("using random: " + randomNumber);
        }
    }
}
