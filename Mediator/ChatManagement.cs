namespace DesignPatterns.Mediator;

public class ChatManagement : IChatMediator
{
    private readonly Dictionary<string, List<User>> Groups;
    public ChatManagement()
    {
        Groups = [];
    }

    public void RegisterUserToGroup(User user, string groupName)
    {
        if (Groups.ContainsKey(groupName)) 
        {
            Groups[groupName] = [];
        }

        Groups[groupName].Add(user);
    }

    public void SendDirectMessage(string message, User fromUser, User toUser)
    {
        Console.WriteLine($"Sending Message from user: {fromUser.Name} to user {toUser.Name}");
        toUser.ReceiveMessage(message, fromUser);
    }

    public void SendGroupMessage(string message, User fromUser, string toGroup)
    {
        Console.WriteLine($"{fromUser.Name} is sending message {message} to group {toGroup}");
        
        var users = Groups[toGroup];
        users.ForEach(user => user.ReceiveGroupMessage(message, fromUser, toGroup));
    }
}