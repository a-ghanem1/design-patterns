namespace DesignPatterns.Command;

public class UnlockDoorCommand : ICommand
{
    private readonly Door _door;

    public UnlockDoorCommand(Door door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.UnLock();
    }
}