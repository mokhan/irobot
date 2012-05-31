namespace core.infrastructure
{
    public interface IEventRegistry
    {
        void register<Event>(ISubscribeTo<Event> subscriber);
    }
}