using Random.BL.Numbers;
using Random.BL;

var factory = new RandomGeneratorFactory();
var generator = factory.NumberGenerator;

Console.WriteLine(generator.GetNumber(1, 10));