namespace DesignPatterns.ChainOfResponsibility;
public class AbstractMiddlewareHandler : IMiddlewareHandler
{
    private IMiddlewareHandler NextHandler;

    public IMiddlewareHandler Next(IMiddlewareHandler middlewareHandler)
    {
        NextHandler = middlewareHandler;
        return middlewareHandler;
    }

    public virtual bool Handle(Request request)
    {
        if (NextHandler is not null) {
            return NextHandler.Handle(request);
        }

        return true;
    }
}