using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Utils
{
    public static class MyLinq
    {
        /// <summary>
        /// LINK EXTENSIONS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> items, Action<T> function)
        {
            T[] array = items.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                function(array[i]);
            }

            return items;
        }

        public static T FirstOrDefalt<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            Predicate<T> pred = new Predicate<T>(predicate);

            T[] array = items.ToArray();
            T item = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                item = array[i];
                if (pred(item)) 
                {
                    break;
                }
            }

            return item;
        }

    }
}
