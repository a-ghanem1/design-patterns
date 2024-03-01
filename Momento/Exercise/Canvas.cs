namespace DesignPatterns.Momento.Exercise;

public class Canvas
{
   public string Content { get; set; }
   public string Color { get; set; }
   public string Border { get; set; }

   public CanvasState Save()
   {
      return new CanvasState(Content, Color, Border);
   }

   public void Restore(CanvasState state)
   {
      Content = state.Content;
      Color   = state.Color;
      Border  = state.Border; 
   }
}