namespace core.infrastructure
{
    public interface IPublishEvents
    {
        void Publish<Event>(Event theEvent);
    }
}