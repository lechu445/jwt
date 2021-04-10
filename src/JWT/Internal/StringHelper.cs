using System;

namespace JWT.Internal
{
    internal static class StringHelper
    {
        internal static string FirstSegment(this string input, char separator)
        {
            var idx = input.IndexOf(separator, StringComparison.OrdinalIgnoreCase);
            return idx != -1 ? input.Substring(0, idx): input;
        }

        internal static int Count(this string input, char character)
        {
            var counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}