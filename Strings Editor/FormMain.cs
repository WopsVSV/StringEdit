using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strings_Editor
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Initializes the components
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks the item dragged
        /// </summary>
        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
          if (e.Data.GetDataPresent(DataFormats.FileDrop, false)  // If data exists
                && e.GetDragItems().Length == 1                     // If it's a single item
                && File.Exists(e.GetDragItems()[0]))                // If it's a file

                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Executes the file loading process
        /// </summary>
        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            // We know it's a single file because of the DragEnter event
            var filePath = e.GetDragItems()[0];
        }

        /// <summary>
        /// Checks the necessary assemblies for the job
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
          
        }

    }
}
