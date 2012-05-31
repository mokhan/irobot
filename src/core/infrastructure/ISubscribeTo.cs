namespace core.infrastructure
{
    public interface ISubscribeTo<Event>
    {
        void notify(Event subscribedEvent);
    }
}