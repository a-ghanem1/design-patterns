namespace DesignPatterns.Command;

public class Light(string name)
{
    public string Name { get; set; } = name;

    public void TurnOn()
    {
        Console.WriteLine("Turning on light..");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning off light..");
    }
}