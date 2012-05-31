using System.Collections.Generic;

namespace core
{
    public class ThreadUnsafeEventAggregator : IEventAggregator
    {
        List<object> subscribers = new List<object>();

        public void RegisterFor<Event>(ISubscribeTo<Event> subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Publish<Event>(Event theEvent)
        {
            subscribers.Each(x => x.CallAs<ISubscribeTo<Event>>(y => y.Notify(theEvent)));
        }
    }
}