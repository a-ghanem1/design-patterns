namespace DesignPatterns.Bridge;

public interface INotificationBuilder
{
    INotificationBuilder SetContent(string content);
    INotificationBuilder SetSender(string sender);
    INotificationBuilder SetRecipient(string recipient);
    INotificationBuilder SetTimestamp(string timestamp);

    
}