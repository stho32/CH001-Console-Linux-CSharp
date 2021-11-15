using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using Source.Functions.RandomNumbers;

namespace Source
{
    static class Program
    {
        static int Main(string[] args)
        {
            // Create a root command with some options
            var rootCommand = new RootCommand
            {
                new Option<bool>(
                    "number",
                    getDefaultValue: () => false,
                    description: "Get a random number"),
            };

            rootCommand.Description = "Random number generator";

            // Note that the parameters of the handler method are matched according to the names of the options
            rootCommand.Handler = CommandHandler.Create<bool>((number) =>
            {
                Console.WriteLine(number.ToString());
                
                if (number)
                {
                    var generator = new RandomNumberGenerator();
                    Console.WriteLine(generator.GetRandomNumber(1, 10));
                }
            });

            // Parse the incoming args and invoke the handler
            return rootCommand.InvokeAsync(args).Result;            
        }
    }
}
