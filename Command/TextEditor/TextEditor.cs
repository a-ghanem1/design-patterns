using DesignPatterns.Command.TextEditor.Commands;

namespace DesignPatterns.Command.TextEditor;

public class TextEditor
{
    public void Execute(ITextOperationCommand command)
    {
        command.Execute();
    }
}