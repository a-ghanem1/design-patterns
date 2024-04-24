namespace DesignPatterns.Builder;

public class MessengerNotification
{
    public string Content { get; set; }
    public string Sender { get; set; }
    public string Recipient { get; set; }
    public string Timestamp { get; set; }
    public List<string> Attachments { get; set; }
    public string Theme { get; set; }
}