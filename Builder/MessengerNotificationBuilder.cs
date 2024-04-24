using DesignPatterns.Builder;

namespace DesignPatterns.Bridge;

public class MessengerNotificationBuilder : INotificationBuilder
{
    private string _content;
    private string _sender;
    private string _recipient;
    private string _timestamp;
    private List<string> _attachments;
    private string _theme;

    public INotificationBuilder SetAttachments(List<string> attachments)
    {
        _attachments = attachments;
        return this;
    }

    public INotificationBuilder SetTheme(string theme)
    {
        _theme = theme;
        return this;
    }

    public INotificationBuilder SetContent(string content)
    {
        _content = content;
        return this;
    }

    public INotificationBuilder SetRecipient(string recipient)
    {
        _recipient = recipient;
        return this;
    }

    public INotificationBuilder SetSender(string sender)
    {
        _sender = sender;
        return this;
    }

    public INotificationBuilder SetTimestamp(string timestamp)
    {
        _timestamp = timestamp;
        return this;
    }

    public MessengerNotification Build()
    {
        return new MessengerNotification
        {
            Content = _content,
            Sender = _sender,
            Recipient = _recipient,
            Timestamp = _timestamp,
            Theme = _theme,
            Attachments = _attachments
        };
    }
}