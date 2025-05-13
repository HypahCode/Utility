using System.Text;

namespace Hypah.Utility.Text
{
    public static class StringExtensions
    {
        public static string Between(this string str, string start, string end)
        {
            return str.Between(start, end, StringComparison.Ordinal);
        }

        public static string Between(this string str, string start, string end, StringComparison comparison)
        {
            int startIndex = str.IndexOf(start, comparison) + start.Length;
            int endIndex = str.IndexOf(end, startIndex, comparison);
            if (startIndex < 0 || endIndex < 0)
                return string.Empty;
            return str.Substring(startIndex, endIndex - startIndex);
        }

        public static string Between(this string str, string start, string end, int startOffset)
        {
            int startIndex = str.IndexOf(start, startOffset, StringComparison.Ordinal) + start.Length;
            int endIndex = str.IndexOf(end, startIndex, StringComparison.Ordinal);
            if (startIndex < 0 || endIndex < 0)
                return string.Empty;
            return str.Substring(startIndex, endIndex - startIndex);
        }

        public static int IndexOfReverse(this string haystack, string needle, int startIndex)
        {
            var revHaystack = new string(haystack.Reverse().ToArray());
            var revNeedle = new string(needle.Reverse().ToArray());
            var revIndex = haystack.Length - startIndex;
            var idx = revHaystack.IndexOf(revNeedle, revIndex);
            if (idx == -1)
            {
                return -1;
            }
            return haystack.Length - idx - needle.Length;
        }
    }
}
