namespace DesignPatterns.Bridge;

public class SDVideoQuality : VideoQuality
{
    public void Render()
    {
        Console.WriteLine("Rendering SD video");
    }
}