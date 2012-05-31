using System;

namespace core.extensions
{
    public static class Dynamic
    {
        public static void call_as<DynamicType>(this object target, Action<DynamicType> command) where DynamicType : class
        {
            target.downcast_to<DynamicType>().run(command);
        }

        public static void run<T>(this T target, Action<T> command)
        {
            if (null == target) return;
            command(target);
        }
    }
}