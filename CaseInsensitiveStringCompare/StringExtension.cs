using System;

namespace CaseInsensitiveStringCompare
{
    public static partial class StringExtension
    {
        public static bool Contains(this string input, string value, bool caseSensitive)
        {
            if (caseSensitive)
                return input.Contains(value);

            return input.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) != -1;
        }
    }
}