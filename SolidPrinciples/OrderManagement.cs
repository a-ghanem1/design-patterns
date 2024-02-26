namespace DesignPatterns.SolidPrinciples;

public class OrderManagement
{
  public void ProcessOrder(Order order)
  {
    Console.WriteLine($"Processing order: {order.Name} now...");
  }
}