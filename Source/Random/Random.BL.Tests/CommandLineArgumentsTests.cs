using Random.BL.CommandLineArguments;
using Random.BL.CommandLineArguments.Classes;
using Xunit;

namespace Random.BL.Tests;

public class CommandLineArgumentsTests {
    [Fact]
    public void When_a_bool_option_is_expected_and_found_it_is_true()
    {
        string[] args = new[] {"isnumber"};

        var parser = new Parser(
            new[] {
                new BoolCommandLineOption("isnumber")
            });

        parser.Parse(args);

        Assert.True(parser.GetBoolOption("isnumber"));
    }
}