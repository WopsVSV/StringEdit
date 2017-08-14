using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEdit
{
    public static class Replacer
    {

        public class Result
        {
            public int Count { get; set; }
            public bool Worked { get; set; }
            public byte[] Bytes { get; set; }
            public Result(bool w, byte[] b, int c)
            {
                Worked = w;
                Bytes = b;
                Count = c;
            }
        }

        public static Result ReplaceAll(byte[] src, byte[] search, byte[] repl)
        {
            int count = 0;
            byte[] dst = null;
            byte[] temp = null;
            int index = Finder.FindBytes(src, search);
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

                count++;

                index = Finder.FindBytes(dst, search);
            }

            if (dst == null)
            {
                return new Result(false, new byte[0], 0);
            }

            return new Result(true, dst, count);
        }

        public static Result ReplaceFirst(byte[] src, byte[] search, byte[] repl)
        {
            byte[] dst = null;
            int index = Finder.FindBytes(src, search);
            if (index >= 0)
            {
                dst = new byte[src.Length - search.Length + repl.Length];
                // before found array
                Buffer.BlockCopy(src, 0, dst, 0, index);
                // repl copy
                Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
                // rest of src array
                Buffer.BlockCopy(
                    src,
                    index + search.Length,
                    dst,
                    index + repl.Length,
                    src.Length - (index + search.Length));
            }

            if (dst == null)
            {
                return new Result(false, new byte[0], 0);
            }

            return new Result(true, dst, 1);
        }

        public static string AdjustString(string original, string input)
        {
            if (input.Length < original.Length) {
                while (input.Length != original.Length)
                    input += ' ';
            }
            else if (input.Length > original.Length)
            {
                input = input.Substring(0, original.Length);
            }

            return input;
        }
       
    }
}
