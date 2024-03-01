using DesignPatterns.Momento;

var editor  = new TextEditor();
var history = new TextEditorHistory(); 

editor.Content = "Hello";
history.Save(editor.Save());

editor.Content = "world";
history.Save(editor.Save());

editor.Content = "Momento";
history.Save(editor.Save());

editor.Restore(history.Undo());
Console.WriteLine(editor.Content);

editor.Restore(history.Undo());
Console.WriteLine(editor.Content);

editor.Restore(history.Undo());
Console.WriteLine(editor.Content);


editor.Restore(history.Redo());
Console.WriteLine(editor.Content);