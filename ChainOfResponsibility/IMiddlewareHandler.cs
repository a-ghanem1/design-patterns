namespace DesignPatterns.ChainOfResponsibility;

public interface IMiddlewareHandler
{
    bool Handle(Request request);
    IMiddlewareHandler Next(IMiddlewareHandler middlewareHandler);
}