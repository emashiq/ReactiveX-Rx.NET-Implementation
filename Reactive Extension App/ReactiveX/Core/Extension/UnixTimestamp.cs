using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveX.Core.Extension
{
    public static class UnixTimestamp
    {
        /// <summary>
        /// Extension Method for printing Unix time stamp
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        public static void PrintUnixTimestamp<TSource>(this IIObservable<TSource> source)
        {
            Console.WriteLine("Current UTC :"+DateTime.UtcNow);
        }
    }
}
