namespace DesignPatterns.Mediator;

public class User
{
    public string Name { get; set; }
    private readonly IChatMediator _chatMediator;

    public User(string name, IChatMediator chatMediator)
    {
        Name = name;

        _chatMediator = chatMediator;
    }

    public void SendDirectMessage(string message, User user)
    {
        _chatMediator.SendDirectMessage(message, this, user);
    }

    public void SendGroupMessage(string message, string groupName)
    {
        _chatMediator.SendGroupMessage(message, this, groupName);
    }

    public void ReceiveMessage(string message, User user)
    {
        Console.WriteLine($"Receiving message {message} from user {user.Name}");
    }

    public void ReceiveGroupMessage(string message, User user, string groupName)
    {
        Console.WriteLine($"Receiving message {message} from group {groupName}, user {user.Name}");
    }
}