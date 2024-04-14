namespace DesignPatterns.Command.TextEditor.Commands;

public class CopyTextCommand : ITextOperationCommand
{
   private string _textToCopy;

   public CopyTextCommand(string textToCopy)
   {
      _textToCopy = textToCopy;
   }

   public void Execute()
   {
      Console.WriteLine("Copy text...");
   }
}