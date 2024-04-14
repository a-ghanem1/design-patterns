namespace DesignPatterns.Command;

public class Tv(string name)
{
    public string Name { get; set; } = name;

    public void TurnOn()
    {
        Console.WriteLine("Turning on tv..");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning off tv..");
    }
}