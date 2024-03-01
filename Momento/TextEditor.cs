namespace DesignPatterns.Momento;

public class TextEditor
{
    public string Content { get; set; }

    public TextEditorState Save()
    {
        return new TextEditorState(Content);
    }

    public void Restore(TextEditorState textEditorState)
    {
        if (textEditorState != null)
        {
            Content = textEditorState.Content;
        }
    }
}