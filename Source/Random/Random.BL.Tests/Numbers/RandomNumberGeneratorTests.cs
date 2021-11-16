using Random.BL.Numbers.Classes;
using Xunit;

namespace Random.BL.Tests;

public class RandomNumberGeneratorTests
{
    [Fact]
    public void Random_number_is_generated()
    {
        var generator = new RandomNumberGenerator();
        var number = generator.GetNumber(1, 10);
        Assert.InRange(number, 1, 10);
    }
}