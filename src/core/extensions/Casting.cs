namespace core.extensions
{
    public static class Casting
    {
        public static T DowncastTo<T>(this object item) where T : class
        {
            return item as T;
        }
    }
}