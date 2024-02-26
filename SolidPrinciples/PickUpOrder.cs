namespace DesignPatterns.SolidPrinciples;

public class PickUpOrder : Order, IShippingCostCalculator
{
   public double CalculateShippingCost()
   {
      return Price;
   }
}
