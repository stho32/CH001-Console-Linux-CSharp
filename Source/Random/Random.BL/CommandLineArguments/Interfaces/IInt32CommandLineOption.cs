namespace Random.BL.CommandLineArguments.Interfaces;

public interface IInt32CommandLineOption : ICommandLineOption {
    int GetValue();
}