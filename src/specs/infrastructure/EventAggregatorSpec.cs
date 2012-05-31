using Machine.Specifications;
using Rhino.Mocks;
using core;
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
                handler.AssertWasCalled(x => x.Notify("hello"));
            };

            Establish context = () =>
            {
                handler = MockRepository.GenerateMock<ISubscribeTo<string>>();
            };

            Because of = () =>
            {
                sut.RegisterFor(handler);
                sut.Publish("hello");
            };

            static ISubscribeTo<string> handler;
        }
    }
}