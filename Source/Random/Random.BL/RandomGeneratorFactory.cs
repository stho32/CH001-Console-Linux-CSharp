using Random.BL.Numbers.Interfaces;

namespace Random.BL
{
    public class RandomGeneratorFactory : IRandomGeneratorFactory
    {
        public IRandomNumberGenerator NumberGenerator { get; }
    }
}