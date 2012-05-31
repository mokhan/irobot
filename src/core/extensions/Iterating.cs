using System;
using System.Collections.Generic;
using System.Linq;

namespace core.extensions
{
    public static class Iterating
    {
        public static void each<T>(this IEnumerable<T> items, Action<T> visitor)
        {
            foreach (var item in items ?? Enumerable.Empty<T>()) visitor(item);
        }
    }
}