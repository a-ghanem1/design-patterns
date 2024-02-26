namespace DesignPatterns.SolidPrinciples;

public interface ISubscriptionNotificationService
{
   public void SubscribeToNewProductsAvailability();
   public void SubscribeToSMSNotifications();
}