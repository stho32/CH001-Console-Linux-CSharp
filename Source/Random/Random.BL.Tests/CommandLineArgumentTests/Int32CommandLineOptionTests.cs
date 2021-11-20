using Random.BL.CommandLineArguments;
using Random.BL.CommandLineArguments.Classes;
using Xunit;

namespace Random.BL.Tests.CommandLineArgumentTests;

public class Int32CommandLineOptionTests {
    [Fact]
    public void When_a_numeric_option_is_expected_and_found_it_is_parsed_correctly()
    {
        string[] args = new[] {"numeric", "123"};

        var parser = new Parser(
            new[] {
                new Int32CommandLineOption("numeric", -1)
            });

        parser.TryParse(args);

        Assert.Equal(123, parser.GetInt32Option("numeric"));
    }

    [Fact]
    public void When_the_option_is_not_found_we_still_have_the_default_value() {
        string[] args = new[] {"nothere"};

        var parser = new Parser(
            new[] {
                new Int32CommandLineOption("numeric", -1)
            });

        parser.TryParse(args);

        Assert.Equal(-1, parser.GetInt32Option("numeric"));
    }

    [Fact]
    public void When_the_argument_is_given_but_the_value_is_not_provided_there_is_an_error() {
        throw new Exception("NIY");
    }

    [Fact]
    public void When_the_argument_is_given_but_the_value_has_the_wrong_type_there_is_an_error() {
        throw new Exception("NIY");
    }

}