namespace DesignPatterns.Observer.Exercise;

public class User(string name) : ISubscriber
{
    public string Name { get; set; } = name;

    public void Notify(string message)
    {
        Console.WriteLine($"{Name} is receiving a message ${message}");
    }
}