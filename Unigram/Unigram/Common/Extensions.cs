﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unigram.Common
{
    public static class Extensions
    {
        public static string TrimEnd(this string input, string suffixToRemove)
        {
            if (input != null && suffixToRemove != null && input.EndsWith(suffixToRemove))
            {
                return input.Substring(0, input.Length - suffixToRemove.Length);
            }
            else return input;
        }

        public static void AddRange<T>(this IList<T> list, IList<T> source)
        {
            foreach (var item in source)
            {
                list.Add(item);
            }
        }

        public static void AddRange<T>(this IList<T> list, params T[] source)
        {
            foreach (var item in source)
            {
                list.Add(item);
            }
        }

        public static List<T> Buffered<T>(int count)
        {
            var result = new List<T>(count);
            for (int i = 0; i < count; i++)
            {
                result.Add(default(T));
            }

            return result;
        }
    }
}
