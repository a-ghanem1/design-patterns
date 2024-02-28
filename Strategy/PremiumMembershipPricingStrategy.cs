namespace DesignPatterns.Strategy;

public class PremiumMembershipPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(double price)
    {
        return price * 0.8;
    }
}