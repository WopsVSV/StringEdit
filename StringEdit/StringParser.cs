using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringEdit
{
    public static class StringParser
    {

        public class ItemValues
        {
            public string Encoding { get; set; }
            public string Occurrences { get; set; }
            public string Entropy { get; set; }

            public ItemValues() { }
            public ItemValues(string enc, string occ, string ent)
            {
                Encoding = enc;
                Occurrences = occ;
                Entropy = ent;
            }
        }


        /// <summary>
        /// Returns the encoding, occurrences and entropy of string
        /// </summary>
        public static ItemValues GetValues(byte[] fileBytes, string input)
        {
            ItemValues retVal = new ItemValues();

            int count = 0;

            count += Finder.CountOccurrences(fileBytes, Encoding.UTF8.GetBytes(input));

            if (count != 0)
                retVal.Encoding = "ASCII";
            var oldCount = count;

            count += Finder.CountOccurrences(fileBytes, GetUTF16Bytes(input));

            if (count != oldCount)
            {
                if (oldCount == 0)
                    retVal.Encoding = "UTF-16";
                else
                    retVal.Encoding = "Both";
            }

            retVal.Occurrences = count.ToString();
            retVal.Entropy = ShannonEntropy(input).ToString("F");

            return retVal;
        }

        /// <summary>
        /// Get UTF-16-like bytes
        /// </summary>
        private static byte[] GetUTF16Bytes(string inputText)
        {
            byte[] input = System.Text.Encoding.ASCII.GetBytes(inputText);
            byte[] output = new byte[(input.Length - 1) * 2 + 1];

            int index = 0;
            foreach (var b in input)
            {
                output[index] = b;

                if (index != output.Length - 1)
                    output[index + 1] = 0x0;
                index += 2;
            }

            output[output.Length - 1] = input[input.Length - 1];

            return output;
        }

        /// <summary>
        /// Returns bits of entropy represented in a given string, per 
        /// </summary>
        public static double ShannonEntropy(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!map.ContainsKey(c))
                    map.Add(c, 1);
                else
                    map[c] += 1;
            }

            double result = 0.0;
            int len = s.Length;
            foreach (var item in map)
            {
                var frequency = (double)item.Value / len;
                result -= frequency * (Math.Log(frequency) / Math.Log(2));
            }

            return result;
        }
    }
}
