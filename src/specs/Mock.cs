using System;
using Rhino.Mocks;

namespace specs
{
    public static class Mock
    {
        public static T an<T>() where T : class
        {
            return MockRepository.GenerateMock<T>();
        }

        public static void received<T>(this T mock, Action<T> command)
        {
            mock.AssertWasCalled(command);
        }

        public static void should_not_have_received<T>(this T mock, Action<T> command)
        {
            mock.AssertWasNotCalled(command);
        }
    }
}