using Rhino.Mocks;

namespace specs
{
    public static class Mock
    {
        public static T An<T>() where T : class
        {
            return MockRepository.GenerateMock<T>();
        }
    }
}