namespace DesignPatterns.Bridge;

public class HDVideoQuality : VideoQuality
{
    public void Render()
    {
        Console.WriteLine("Rendering HD video");
    }
}