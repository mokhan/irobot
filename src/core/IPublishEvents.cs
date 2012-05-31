namespace core
{
    public interface IPublishEvents
    {
        void Publish<Event>(Event theEvent);
    }
}