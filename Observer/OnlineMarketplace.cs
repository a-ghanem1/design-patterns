namespace DesignPatterns.Observer;

public class OnlineMarketplace
{
    public Dictionary<EventType, List<ISubscriber>> Subscribers = [];
    public List<Product> Products { get; set; } = [];
    public List<Offer> Offers { get; set; } = [];

    public OnlineMarketplace()
    {
        initSubscriberEvents();
    }

    private void initSubscriberEvents()
    {
        Subscribers[EventType.NEW_OFFER] = [];
        Subscribers[EventType.NEW_PRODUCT] = [];
        Subscribers[EventType.JOB_OPENING] = [];
    }

    public void Subscribe(EventType eventType, ISubscriber subscriber)
    {
        Subscribers[eventType].Add(subscriber);
    }

    public void Unsubscribe(EventType eventType, ISubscriber subscriber)
    {
        Subscribers[eventType].Remove(subscriber);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        NotifySubscribers(EventType.NEW_PRODUCT, $"New product is added: {product.Name}");
    }

    public void AddOffer(Offer offer)
    {
        Offers.Add(offer);
        NotifySubscribers(EventType.NEW_PRODUCT, $"New offer is added: {offer.Message}");
    }

    public void NotifySubscribers(EventType eventType, string message)
    {
        Subscribers[eventType].ForEach(subscriber => subscriber.Notify(message));
    }
}