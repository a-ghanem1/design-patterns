namespace DesignPatterns.ChainOfResponsibility;

public record Request(
    string Type,
    bool IsAuthenticated,
    bool IsAuthorized,
    bool HasPassedTheSecurityChecks
);