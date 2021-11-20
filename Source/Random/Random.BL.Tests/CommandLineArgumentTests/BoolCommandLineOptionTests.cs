using Random.BL.CommandLineArguments;
using Random.BL.CommandLineArguments.Classes;
using Xunit;

namespace Random.BL.Tests.CommandLineArgumentTests;

public class BoolCommandLineOptionTests {
    [Fact]
    public void When_a_bool_option_is_expected_and_found_it_is_true()
    {
        string[] args = new[] {"isnumber"};

        var parser = new Parser(
            new[] {
                new BoolCommandLineOption("isnumber")
            });

        parser.TryParse(args);

        Assert.True(parser.GetBoolOption("isnumber"));
    }

    [Fact]
    public void When_a_bool_option_is_expected_but_not_found_it_is_false() {
        string[] args = new[] {"nothere"};

        var parser = new Parser(
            new[] {
                new BoolCommandLineOption("isnumber")
            });

        parser.TryParse(args);

        Assert.False(parser.GetBoolOption("isnumber"));
    }
}