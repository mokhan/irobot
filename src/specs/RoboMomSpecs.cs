using Machine.Specifications;
using Rhino.Mocks;
using Robocode;
using core;

namespace specs
{
    public class RoboMomSpecs
    {
        Establish context = () =>
        {
            publisher = Mock.An<IPublishEvents>();
            sut = new RoboMom(publisher);
        };

        static RoboMom sut;
        static IPublishEvents publisher;


        public class when_hit
        {
            It should_publish_the_event = () =>
            {
                publisher.AssertWasCalled(x => x.Publish(message));
            };

            Establish context = () =>
            {
                message = new BulletHitEvent("blah", 0, new Bullet(0,0,0,0,"","", false, 0));
            };

            Because of = () =>
            {
                sut.OnBulletHit(message);
            };

            static BulletHitEvent message;
        }
    }

    public static class Mock
    {
        public static T An<T>() where T : class
        {
            return MockRepository.GenerateMock<T>();
        }
    }
}