namespace core.infrastructure
{
    public interface IPublishEvents
    {
        void publish<Event>(Event theEvent);
    }
}