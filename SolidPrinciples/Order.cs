namespace DesignPatterns.SolidPrinciples;

public class Order
{
  public string Name { get; set; }
  public double Price { get; set; }

  protected static double SHIPPING_COST = 10.0;
}