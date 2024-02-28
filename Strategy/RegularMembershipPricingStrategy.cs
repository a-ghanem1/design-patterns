namespace DesignPatterns.Strategy;

public class RegularMembershipPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(double price)
    {
        return price;
    }
}