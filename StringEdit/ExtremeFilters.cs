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
    public static class ExtremeFilters
    {
        private static string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVXYZWabcdefghijklmnopqrstuvxyzw0123456789";

        /// <summary>
        /// Parses the string by running it through several filters
        /// </summary>
        public static string Parse(string data)
        {
            if (!Filter1(data)) return null;
            if (!Filter2(data)) return null;
            if (!Filter3(data)) return null;
            if (!Filter4(data)) return null;
            if (!Filter5(data)) return null;

            return data;
        }

        /// <summary>
        /// Filter 1
        /// </summary>
        private static bool Filter1(string data)
        {
            if (data.Length != 3) return true;

            int alpha = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (ALPHABET.Contains(data[i]))
                    alpha++;
            }

            if (alpha == 2)
                return false;

           return true; 
        }

        /// <summary>
        /// Filter 2
        /// </summary>
        private static bool Filter2(string data)
        {
            if (data.Length != 4) return true;

            int alpha = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (ALPHABET.Contains(data[i]))
                    alpha++;
            }

            if (alpha == 3)
                return false;

            return true;
        }

        /// <summary>
        /// Filter 3
        /// </summary>
        private static bool Filter3(string data)
        {
            if (data.Length > 6) return true;

            if (!char.IsLower(data[data.Length - 1])) return true;

            bool once = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (i + 1 == data.Length) break;
                if (data[i] == data[i + 1] && char.IsUpper(data[i]))
                {
                    once = true;
                    break;
                }
            }

            if (once) return false;
            return true;
        }

        /// <summary>
        /// Filter 4
        /// </summary>
        private static bool Filter4(string data)
        {
            if (data.Length > 5) return true;

            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (i + 1 == data.Length) break;
                if (data[i] == data[i + 1] && char.IsUpper(data[i]))
                {
                    count++;
                }
            }

            if (count == 2 || count == 3) return false;
            return true;
        }

        /// <summary>
        /// Filter 5
        /// </summary>
        private static bool Filter5(string data)
        {
            if (data.Length >= 12) return true;

            bool ok = true;
            for (int i = 0; i < data.Length; i++)
            {
                if (i + 1 == data.Length) break;
                if (data[i] != data[i + 1])
                {
                    ok = false;
                    break;
                }
            }

            return !ok;
        }
    }
}
