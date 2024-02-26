namespace DesignPatterns.SolidPrinciples;

public interface IPaymentStrategy
{
    void ProcessPayment(double amount);
}