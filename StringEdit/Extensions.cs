using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
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

    }
}
