using Random.BL.Numbers.Interfaces;
using Random.BL.Numbers.Classes;

namespace Random.BL;

public interface IRandomGeneratorFactory
{
    IRandomNumberGenerator NumberGenerator { get; }
}
