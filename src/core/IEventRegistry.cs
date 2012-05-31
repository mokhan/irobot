namespace core
{
    public interface IEventRegistry
    {
        void RegisterFor<Event>(ISubscribeTo<Event> subscriber);
    }
}