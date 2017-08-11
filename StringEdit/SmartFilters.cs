using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEdit
{
    /// <summary>
    /// A static class for filtering bogus strings
    /// </summary>
    public static class SmartFilters
    {
        /// <summary>
        /// Parses the string by running it through several filters
        /// </summary>
        public static string Parse(string data)
        {
            if (!Filter1(data)) return null;
            if (!Filter2(data)) return null;
            if (!Filter3(data)) return null;

            return data;
        }

        /// <summary>
        /// Filter 1: 
        /// Check if the string is empty or white spaced
        /// </summary>
        private static bool Filter1(string data)
        {
            return !string.Equals(data, string.Empty);
        }

        /// <summary>
        /// Filter 2:
        /// Check for the 3 character junk format:
        /// [CHAR_A][CHAR_B][CHAR_A]
        /// </summary>
        private static bool Filter2(string data)
        {
            if (data.Length != 3) return true;

            if ((data[0] == data[1] && data[2] != data[0]) ||
                (data[0] == data[2] && data[1] != data[0]) ||
                (data[1] == data[2] && data[0] != data[1]))
                return false;

            return true;
        }

        /// <summary>
        /// Filter 3:
        /// Check for 2/4, 4/4, 3/4, 2/3, 3/3 non-alphanumeric characters
        /// </summary>
        private static bool Filter3(string data)
        {
            if (data.Length != 3 && data.Length != 4 && data.Length != 5) return true;

            int count = 0;
            foreach (var chr in data)
                if (!char.IsLetterOrDigit(chr)) count++;

            if (data.Length == 3 && count >= 2) return false;
            if (data.Length == 4 && count >= 2) return false;
            if (data.Length == 5 && count >= 3) return false;

            return true;
        }
    }
}
