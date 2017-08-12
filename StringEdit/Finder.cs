using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringEdit
{
    public static class Finder
    {
        public class Result
        {
            public bool Worked { get; set; }
            public byte[] Bytes { get; set; }
            public Result(bool w, byte[] b)
            {
                Worked = w;
                Bytes = b;
            }
        }

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

        public static Result ReplaceBytes(byte[] src, byte[] search, byte[] repl)
        {
            byte[] dst = null;
            byte[] temp = null;
            int index = FindBytes(src, search);
            while (index >= 0)
            {
                if (temp == null)
                    temp = src;
                else
                    temp = dst;

                dst = new byte[temp.Length - search.Length + repl.Length];

                // before found array
                Buffer.BlockCopy(temp, 0, dst, 0, index);
                // repl copy
                Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
                // rest of src array
                Buffer.BlockCopy(
                    temp,
                    index + search.Length,
                    dst,
                    index + repl.Length,
                    temp.Length - (index + search.Length));

                index = FindBytes(dst, search);
            }

            if (dst == null)
            {
                return new Result(false, new byte[0]);
            }

            return new Result(true, dst);
        }

    }
}
