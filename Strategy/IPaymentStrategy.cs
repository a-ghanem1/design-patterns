namespace DesignPatterns.Strategy;

public interface IPaymentStrategy
{
    void ProcessPayment(double amount);
}