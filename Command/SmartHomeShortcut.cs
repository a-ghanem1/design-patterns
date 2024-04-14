namespace DesignPatterns.Command;

public class SmartHomeShortcut
{
    private readonly Dictionary<string, ICommand> _commands;

    public SmartHomeShortcut()
    {
        _commands = [];
    }

    public void SetCommand(string shortcut, ICommand command)
    {
        _commands[shortcut] = command;
    }

    public void OpenShortcut(string shortcut)
    {
        _commands[shortcut].Execute();
    }
}
