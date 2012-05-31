using System.Collections.Generic;
using core.extensions;

namespace core.infrastructure
{
    public class ThreadUnsafeEventAggregator : IEventAggregator
    {
        List<object> subscribers = new List<object>();

        public void register<Event>(ISubscribeTo<Event> subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void publish<Event>(Event theEvent)
        {
            subscribers.each(x => x.call_as<ISubscribeTo<Event>>(y => y.notify(theEvent)));
        }
    }
}