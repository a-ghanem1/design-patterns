namespace DesignPatterns.Command;

public class TurnOnTvCommand : ICommand
{
    private readonly Tv _tv;

    public TurnOnTvCommand(Tv tv)
    {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.TurnOn();
    }
}