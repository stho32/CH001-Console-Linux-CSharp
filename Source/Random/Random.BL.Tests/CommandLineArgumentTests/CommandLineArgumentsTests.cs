using Random.BL.CommandLineArguments;
using Random.BL.CommandLineArguments.Classes;
using Xunit;

namespace Random.BL.Tests.CommandLineArgumentTests;

public class GeneralTests {
    [Fact]
    public void When_all_parameters_can_be_parsed_then_TryParse_is_satisfied() {
        string[] args = new[] {"isnumber"};

        var parser = new Parser(
            new[] {
                new BoolCommandLineOption("isnumber")
            });

        Assert.True(parser.TryParse(args));
    }

    [Fact]
    public void When_not_all_parameters_can_be_parsed_then_TryParse_is_not_satisfied() {
        string[] args = new[] {"this-is-not-valid"};

        var parser = new Parser(
            new[] {
                new BoolCommandLineOption("isnumber")
            });

        Assert.False(parser.TryParse(args));
    }
}
