namespace core
{
    public interface ISubscribeTo<Event>
    {
        void Notify(Event subscribedEvent);
    }
}