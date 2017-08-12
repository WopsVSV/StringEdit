using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StringEdit
{
    public static class Extensions
    {
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

        /// <summary>
        /// Adjusts the list view columns
        /// </summary>
        public static void AdjustViewColumns(ListView view)
        {
            int w = view.Size.Width - SystemInformation.VerticalScrollBarWidth;
            // NOTE: can't use ClientSize.Width if vertical scrollbar is already shown, wing it
            switch (view.BorderStyle)
            {
                case BorderStyle.Fixed3D: w -= 4; break;
                case BorderStyle.FixedSingle: w -= 2; break;
            }
            for (int ix = 0; ix < view.Columns.Count; ++ix)
            {
                if (view.Columns[ix].Width < w) w -= view.Columns[ix].Width;
                else
                {
                    view.Columns[ix].Width = w;
                    // Hide columns that can't fit
                    for (int jx = ix + 1; jx < view.Columns.Count; ++jx)
                        view.Columns[jx].Width = 0;
                    return;
                }
            }
            // Widen last column to fill view
            view.Columns[view.Columns.Count - 1].Width += w;
        }

        #region Move borderless form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void BorderlessForm_MouseDown(Form frm, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(frm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

    }
}
