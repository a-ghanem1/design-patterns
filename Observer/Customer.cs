namespace DesignPatterns.Observer;

public class Customer(string name) : ISubscriber
{
    public string Name { get; set; } = name;

    public void Notify(string message)
    {
        Console.WriteLine("Notifying user: " + Name + " about: " + message);
    }
}