using Rise;
using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class StringExtensions
    {
        public static string EnsureStartsWith(this string str, string pre, StringComparison comparison = StringComparison.Ordinal)
        {
            Check.NotNull(str, nameof(str));

            if (str.StartsWith(pre, comparison))
            {
                return str;
            }

            return pre + str;
        }

        public static string EnsureEndsWith(this string str, string post, StringComparison comparison = StringComparison.Ordinal)
        {
            Check.NotNull(str, nameof(str));

            if (str.EndsWith(post, comparison))
            {
                return str;
            }

            return str + post;
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNotNullOrEmpty(this string s)
        {
            return !s.IsNullOrEmpty();
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNotNullOrWhiteSpace(this string s)
        {
            return !s.IsNullOrWhiteSpace();
        }
    }
}
