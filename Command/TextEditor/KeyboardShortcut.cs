using DesignPatterns.Command.TextEditor.Commands;

namespace DesignPatterns.Command.TextEditor;

public class KeyboardShortcut
{
    private readonly Dictionary<string, ITextOperationCommand> _textCommands;

    public KeyboardShortcut()
    {
        _textCommands = [];
    }

    public void SetTextCommand(string shortcut, ITextOperationCommand command)
    {
        _textCommands[shortcut] = command;
    }

    public void Click(string shortcut)
    {
        _textCommands[shortcut].Execute();
    }
}