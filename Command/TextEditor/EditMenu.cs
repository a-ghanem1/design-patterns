using DesignPatterns.Command.TextEditor.Commands;

namespace DesignPatterns.Command.TextEditor;

public class EditMenu
{
    private readonly Dictionary<string, ITextOperationCommand> _menuItems;

    public EditMenu()
    {
        _menuItems = [];
    }

    public void SetTextCommand(string shortcut, ITextOperationCommand command)
    {
        _menuItems[shortcut] = command;
    }

    public void Click(string shortcut)
    {
        _menuItems[shortcut].Execute();
    }
}