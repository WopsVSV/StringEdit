using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strings_Editor
{
    public partial class FormMain : Form
    {
        private string extractorFile;

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

            // Choose the strings assembly version
            extractorFile = Utility.InternalCheckIsWow64() ? "strings64.exe" : "strings32.exe";

            // Accepts the eula
            AcceptEula();
            System.Threading.Thread.Sleep(100);

            // Parse parameters
            int minSize = int.Parse(cbStringSize.GetItemText(cbStringSize.SelectedItem));
            bool doFilter = minSize <= 4 && chkUseFilters.Checked;

            // Executes the extraction process
            var extractionProcess = GetExtractionProcess($"-nobanner {filePath}");
            extractionProcess.Start();

            // Disables settings groupbox
            grpSettings.Enabled = false;

            // Extracts
            var line = string.Empty;
            while (!extractionProcess.StandardOutput.EndOfStream)
            {
                line = extractionProcess.StandardOutput.ReadLine();

                if (line.Length >= minSize)
                {
                    if (doFilter)
                    {
                        if(StringFilter.Parse(line) != null)
                            lstStrings.Items.Add(line);
                    }
                    else
                    {
                        lstStrings.Items.Add(line);
                    }
                }               
            }

            grpStrings.Visible = true;
        }

        /// <summary>
        /// Checks the necessary assemblies for the job
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            cbStringSize.SelectedIndex = 4;
        }

        /// <summary>
        /// Returns an extraction process with specific parameters
        /// </summary>
        private Process GetExtractionProcess(string arguments)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = extractorFile,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
        }

        /// <summary>
        /// Accepts the eula of the strings assembly
        /// </summary>
        public void AcceptEula()
        {
            var eulaProcess = GetExtractionProcess("-accepteula");
            eulaProcess.Start();
            eulaProcess.WaitForExit();
        }

        private void btnEditString_Click(object sender, EventArgs e)
        {
            if (lstStrings.SelectedItem == null)
                return;

            new FormReplace(lstStrings.SelectedItem.ToString(), lstStrings.SelectedIndex).Show();
        }
    }
}
