namespace DesignPatterns.Command.TextEditor.Commands;

public class DeleteTextCommand : ITextOperationCommand
{
    private string _textToDelete;

    public DeleteTextCommand(string textToDelete)
    {
        _textToDelete = textToDelete;
    }

    public void Execute()
    {
        Console.WriteLine("Delete text...");
    }
}