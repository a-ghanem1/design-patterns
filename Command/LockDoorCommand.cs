namespace DesignPatterns.Command;

public class LockDoorCommand : ICommand
{
    private readonly Door _door;
    
    public LockDoorCommand(Door door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Lock();
    }
}