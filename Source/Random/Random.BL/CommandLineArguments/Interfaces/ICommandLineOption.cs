namespace Random.BL.CommandLineArguments.Interfaces;

public interface ICommandLineOption
{
    string Name { get; }

    bool HasNoValueYet();
    bool TryParseFrom(string[] args, ref int position);
}
