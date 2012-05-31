namespace core.extensions
{
    public static class Casting
    {
        public static T downcast_to<T>(this object item) where T : class
        {
            return item as T;
        }
    }
}