using System;

namespace core.extensions
{
    public static class Dynamic
    {
        public static void CallAs<DynamicType>(this object target, Action<DynamicType> command) where DynamicType : class
        {
            command(target.DowncastTo<DynamicType>());
        }
    }
}