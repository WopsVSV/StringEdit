using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringEdit
{
    public static class Finder
    {

        /// <summary>
        /// Counts the number of occurrences of bytes found
        /// </summary>
        public static int CountOccurrences(byte[] src, byte[] find)
        {
            int retVal = 0;
            int matchIndex = 0;
            // handle the complete source array
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i] == find[matchIndex])
                {
                    if (matchIndex == (find.Length - 1))
                    {
                        retVal++;
                        continue;
                    }
                    matchIndex++;
                }
                else if (src[i] == find[0])
                {
                    matchIndex = 1;
                }
                else
                {
                    matchIndex = 0;
                }

            }
            return retVal;
        }

        /// <summary>
        /// Find the index of the find bytes in src
        /// </summary>
        public static int FindBytes(byte[] src, byte[] find)
        {
            int index = -1;
            int matchIndex = 0;
            // handle the complete source array
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i] == find[matchIndex])
                {
                    if (matchIndex == (find.Length - 1))
                    {
                        index = i - matchIndex;
                        break;
                    }
                    matchIndex++;
                }
                else if (src[i] == find[0])
                {
                    matchIndex = 1;
                }
                else
                {
                    matchIndex = 0;
                }

            }
            return index;
        }

     

    }
}
