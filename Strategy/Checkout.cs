namespace DesignPatterns.Strategy;

public class Checkout
{
    private readonly IPaymentStrategy _paymentStrategy;
    public Checkout(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(double amount)
    {
        _paymentStrategy.ProcessPayment(amount);
    }
}