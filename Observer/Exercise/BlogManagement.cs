namespace DesignPatterns.Observer.Exercise;

public class BlogManagement
{
    public List<Blog> Blogs { get; set; } = [];
    public List<Newsletter> Newsletters { get; set; } = [];
    public Dictionary<SubscriberType, List<ISubscriber>> Subscribers { get; set; } = [];

    public BlogManagement()
    {
        InitSubscriberEventTypes();
    }

    public void InitSubscriberEventTypes()
    {
        Subscribers[SubscriberType.NEW_BLOGS]  = [];
        Subscribers[SubscriberType.NEWSLETTER] = [];
    }

    public void Subscribe(SubscriberType subscriberType, ISubscriber subscriber)
    {
        Subscribers[subscriberType].Add(subscriber);
    }

    public void Unsubscribe(SubscriberType subscriberType, ISubscriber subscriber)
    {
        Subscribers[subscriberType].Remove(subscriber);
    }

    public void NotifySubscribers(SubscriberType subscriberType, string message)
    {
        Subscribers[subscriberType].ForEach(subscriber => subscriber.Notify(message));
    }

    public void AddNewsletter(Newsletter newsletter)
    {
        Newsletters.Add(newsletter);
        NotifySubscribers(SubscriberType.NEWSLETTER, $"new newsletter: {newsletter.Name}");
    }

    public void AddNewBlogPost(Blog blog)
    {
        Blogs.Add(blog);
        NotifySubscribers(SubscriberType.NEW_BLOGS, $"new blog: {blog.Name}");
    }
}