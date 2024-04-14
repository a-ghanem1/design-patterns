namespace DesignPatterns.Command;

public class Door(string name)
{
    public string Name { get; set; } = name;

    public void Lock()
    {
        Console.WriteLine("Locking door..");
    }

    public void UnLock()
    {
        Console.WriteLine("UnLocking door..");
    }
}