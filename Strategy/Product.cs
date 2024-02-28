namespace DesignPatterns.Strategy;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    private readonly IPricingStrategy _pricingStrategy;

    public Product(string name, double price, IPricingStrategy pricingStrategy)
    {
        Price = price;
        Name = name;
        _pricingStrategy = pricingStrategy;
    }

    public double CalculatePrice()
    {
        return _pricingStrategy.CalculatePrice(Price);
    }
}