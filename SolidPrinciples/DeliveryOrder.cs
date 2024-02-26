namespace DesignPatterns.SolidPrinciples;

public class DeliveryOrder : Order, IShippingCostCalculator
{
   public double CalculateShippingCost()
   {
      return Price + SHIPPING_COST;
   }
}