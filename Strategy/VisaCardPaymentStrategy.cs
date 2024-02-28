namespace DesignPatterns.Strategy;

public class VisaCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment with visa");
        Console.WriteLine("calculating fees of the amount for visa..");
    }
}