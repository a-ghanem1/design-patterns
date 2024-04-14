namespace DesignPatterns.Command;

public class VoiceAssistant
{
    private readonly Dictionary<string, ICommand> _commands;

    public VoiceAssistant()
    {
        _commands = [];
    }

    public void SetCommand(string talkingCommand, ICommand command)
    {
        _commands[talkingCommand] = command;
    }

    public void Say(string talkingCommand)
    {
        _commands[talkingCommand].Execute();
    }
}
