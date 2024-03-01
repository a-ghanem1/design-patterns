namespace DesignPatterns.Momento.Exercise;

public class CanvasHistory
{
    public Stack<CanvasState> PrevStates { get; set; } = new();

    public void Save(CanvasState state)
    {
        PrevStates.Push(state);
    }

    public CanvasState Undo()
    {
        return PrevStates.Pop();
    }
}