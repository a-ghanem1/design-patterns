namespace DesignPatterns.SolidPrinciples;

public class VisaPaymentStrategy : IPaymentStrategy
{
   public void ProcessPayment(double amount)
   {
      Console.WriteLine("Processing visa payments...");
   }
}