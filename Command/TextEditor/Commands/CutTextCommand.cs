namespace DesignPatterns.Command.TextEditor.Commands;

public class CutTextCommand : ITextOperationCommand
{
    private string _textToCut;

    public CutTextCommand(string textToCut)
    {
        _textToCut = textToCut;
    }

    public void Execute()
    {
        Console.WriteLine("Cut text...");
    }
}