namespace DesignPatterns.Strategy;

public class GoldMembershipPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(double price)
    {
        return price * 0.9;
    }
}