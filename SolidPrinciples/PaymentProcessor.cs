namespace DesignPatterns.SolidPrinciples;

public class PaymentProcessor
{
  private readonly IPaymentStrategy _paymentStrategy;
  public PaymentProcessor(IPaymentStrategy paymentStrategy)
  {
    _paymentStrategy = paymentStrategy;
  }

  public void ProcessPayment(Order order)
  {
    Console.WriteLine($"Processing payment of order: {order.Name}");
    Console.WriteLine($"Issuing payment for amount: {order.Price}");
    _paymentStrategy.ProcessPayment(order.Price);
  }
}