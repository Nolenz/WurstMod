﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WurstModCodeGen
{
    public static class Extensions
    {
        /// <summary>
        /// This is a good-enough stable hash function that should be fully portable.
        /// https://stackoverflow.com/questions/36845430/persistent-hashcode-for-strings
        /// </summary>
        public static int GetStableHashCode(this string str)
        {
            unchecked
            {
                int hash1 = 5381;
                int hash2 = hash1;

                for (int i = 0; i < str.Length && str[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ str[i];
                    if (i == str.Length - 1 || str[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ str[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }
        
        public static IEnumerable<T> Zip35Deferred<A, B, T>(
            this IEnumerable<A> seqA, IEnumerable<B> seqB, Func<A, B, T> func)
        {
            using (var iteratorA = seqA.GetEnumerator())
            using (var iteratorB = seqB.GetEnumerator())
            {
                while (iteratorA.MoveNext() && iteratorB.MoveNext())
                {
                    yield return func(iteratorA.Current, iteratorB.Current);
                }
            }
        }
    }
}
