namespace DesignPatterns.Mediator;

public interface IChatMediator
{
    void SendDirectMessage(string message, User fromUser, User toUser);
    void SendGroupMessage(string message, User fromUser, string toGroup);
    void RegisterUserToGroup(User user, string groupName);
}