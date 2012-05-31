namespace core.infrastructure
{
    public interface ISubscribeTo<Event>
    {
        void Notify(Event subscribedEvent);
    }
}