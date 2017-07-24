using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Strings_Editor
{
    public static class Utility
    {
        public static int replacesDone;

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
            replacesDone = 0;
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

                replacesDone++;

                index = FindBytes(dst, search);
            }

            if (dst == null)
            {
                return new Result(false, new byte[0]);
            }
            else
            {
                return new Result(true, dst);
            }
        }

        /// <summary>
        /// Returns the items of a drag&drop event
        /// </summary>
        public static string[] GetDragItems(this DragEventArgs e)
        {
            return (string[])e.Data.GetData(DataFormats.FileDrop, false);
        }

        #region InternalCheckIsWow64
        static bool is64BitProcess = (IntPtr.Size == 8);
        static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );
        #endregion

        /// <summary>
        /// Determines whether or not the system is 64bit or not
        /// </summary>
        /// <returns></returns>
        public static bool InternalCheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
