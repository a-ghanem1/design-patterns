namespace DesignPatterns.Command;

public class SmartHomeMobileApplication
{
    public void Execute(ICommand command)
    {
        command.Execute();
    }
}