namespace core.infrastructure
{
    public interface IEventRegistry
    {
        void RegisterFor<Event>(ISubscribeTo<Event> subscriber);
    }
}