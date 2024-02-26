namespace DesignPatterns.Observer;

public interface ISubscriber
{
    void Notify(string message);
}