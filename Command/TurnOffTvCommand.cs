namespace DesignPatterns.Command;

public class TurnOffTvCommand : ICommand
{
    private readonly Tv _tv;

    public TurnOffTvCommand(Tv tv)
    {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.TurnOff();
    }
}