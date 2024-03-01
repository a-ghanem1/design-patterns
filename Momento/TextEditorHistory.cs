namespace DesignPatterns.Momento;

public class TextEditorHistory
{
    public Stack<TextEditorState> PrevStates { get; set; } = new();
    public Stack<TextEditorState> NextStates { get; set; } = new();

    public void Save(TextEditorState textEditorState)
    {
        PrevStates.Push(textEditorState);
        NextStates.Clear();
    }

    public TextEditorState Undo()
    {
        if (PrevStates.Count == 0) return null;

        var currentState = PrevStates.Pop();
        NextStates.Push(currentState);

        return currentState;
    }

    public TextEditorState Redo()
    {
        if (NextStates.Count == 0) return null;

        var nextState = NextStates.Pop();
        PrevStates.Push(nextState);

        return nextState;
    }
}