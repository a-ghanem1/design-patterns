namespace DesignPatterns.ChainOfResponsibility;

public class AuthorizationMiddleware : AbstractMiddlewareHandler
{
    public override bool Handle(Request request)
    {
        Console.WriteLine("Checking if request is authorized...");
        if (!request.IsAuthenticated) {
            Console.WriteLine("request is not authorized");
            return false;
        }
        
        return base.Handle(request);
    }
}