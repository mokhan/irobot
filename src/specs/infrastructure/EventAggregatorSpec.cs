using Machine.Specifications;
using core.infrastructure;

namespace specs.infrastructure
{
    public class EventAggregatorSpec
    {
        Establish context = () =>
        {
            sut = new ThreadUnsafeEventAggregator();
        };

        static IEventAggregator sut;

        public class when_publishing
        {
            It should_notify_all_interested_subscribers = () =>
            {
                subscriber.received(x => x.notify("hello"));
            };

            Establish context = () =>
            {
                subscriber = Mock.An<ISubscribeTo<string>>();
            };

            Because of = () =>
            {
                sut.register(subscriber);
                sut.publish("hello");
            };

            static ISubscribeTo<string> subscriber;
        }
    }
}