namespace DesignPatterns.Strategy;

public class PaypalPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment with paypal");
        Console.WriteLine("calculating fees of the amount for paypal..");
    }
}