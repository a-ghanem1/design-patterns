namespace DesignPatterns.ChainOfResponsibility;

public class AuthenticationMiddleware : AbstractMiddlewareHandler
{
    public override bool Handle(Request request)
    {
        Console.WriteLine("Checking if request is Authenticated...");
        if (!request.IsAuthenticated) {
            Console.WriteLine("request is not authenticated");
            return false;
        }
        
        return base.Handle(request);
    }
}