namespace DesignPatterns.Strategy;

public class BankTransferPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment with bank transfer");
    }
}