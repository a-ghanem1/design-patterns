namespace DesignPatterns.SolidPrinciples;

public class MasterCardPaymentStrategy : IPaymentStrategy
{
   public void ProcessPayment(double amount)
   {
      Console.WriteLine("Processing master card payments...");
   }
}