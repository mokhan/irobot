using System;
using Rhino.Mocks;

namespace specs
{
    public static class Mock
    {
        public static T An<T>() where T : class
        {
            return MockRepository.GenerateMock<T>();
        }

        public static void received<T>(this T mock, Action<T> command)
        {
            mock.AssertWasCalled(command);
        }
    }
}