using System;
using System.Collections.Generic;
using System.Linq;

namespace OverLoad
{

 
        internal static class OverLoad
        {
           public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Console.WriteLine("OverLoad Where");
            return System.Linq.Enumerable.Where(source, predicate);
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            Console.WriteLine("OverLoad Select");
            return System.Linq.Enumerable.Select(source, selector);
        }

        }
    

}
