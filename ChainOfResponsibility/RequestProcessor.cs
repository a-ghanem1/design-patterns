namespace DesignPatterns.ChainOfResponsibility;

public class RequestProcessor
{
    private readonly IMiddlewareHandler _middlewareHandlerChain;
    public RequestProcessor(IMiddlewareHandler middlewareHandlerChain)
    {
        _middlewareHandlerChain = middlewareHandlerChain;
    }

    public Response ProcessRequest(Request request)
    {
        if (_middlewareHandlerChain.Handle(request))
        {
            return new Response("failed", false);
        }

        Console.WriteLine("Processing request");
        return new Response("OK", true);
    }
}