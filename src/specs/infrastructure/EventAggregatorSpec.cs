using System.Data;
using Machine.Specifications;
using core.infrastructure;
using Rhino.Mocks;

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

            It should_not_notify_subscribers_who_are_not_interested_in_that_particular_event = () =>
            {
                uninterested_subscriber.should_not_have_received(x => x.notify(Arg<IDbCommand>.Is.Anything));
            };

            Establish context = () =>
            {
                subscriber = Mock.an<ISubscribeTo<string>>();
                uninterested_subscriber = Mock.an<ISubscribeTo<IDbCommand>>();
            };

            Because of = () =>
            {
                sut.register(uninterested_subscriber);
                sut.register(subscriber);
                sut.publish("hello");
            };

            static ISubscribeTo<string> subscriber;
            static ISubscribeTo<IDbCommand> uninterested_subscriber;
        }
    }
}