using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEdit
{
    /// <summary>
    /// Main window for the program
    /// </summary>
    public partial class FrmMain : Form
    {
        // Objects
        private Extractor extractor;
        private byte[] fileBytes;

        // To be replace on final release
        private const int BUILD_NO = 27;

        /// <summary>
        /// Initialises the GUI components
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads crucial information for the program
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Displays the build number accordingly
            txtBuild.Text = "Build " + BUILD_NO;

            // Hides the Build & Edit tabs
            pnlCoverBuild.Size = new Size(tabBuild.Width, tabBuild.Height);
            pnlCoverEdit.Size = new Size(tabBuild.Width, tabBuild.Height);

            // Adjusts listview
            Extensions.AdjustViewColumns(lstStrings);
        }

        /// <summary>
        /// Checks the dragged item
        /// </summary>
        private void tabLoad_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)  // If data exists
                && e.GetDragItems().Length == 1                     // If it's a single item
                && File.Exists(e.GetDragItems()[0]))                // If it's a file

                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Act with the dropped file
        /// </summary>
        private async void tabLoad_DragDrop(object sender, DragEventArgs e)
        {
            // Clear list
            lstStrings.Items.Clear();

            // Fill the progress bar
            OnLoadGuiUpdate();

            await Task.Run(() =>
            {
                // Check if settings are valid
                if (!txtMinSize.Text.All(char.IsDigit) && !string.IsNullOrEmpty(txtMinSize.Text))
                {
                    MessageBox.Show("Invalid string size!");
                    return;
                }

                // We know it's a single file because of the DragEnter event
                string filePath = e.GetDragItems()[0];

                // Copy if necessary
                if (Globals.CreateBackup)
                    File.Copy(filePath,
                        Path.GetDirectoryName(filePath) + "/" + Path.GetFileNameWithoutExtension(filePath) +
                        "_original" + Path.GetExtension(filePath), true);

                fileBytes = File.ReadAllBytes(filePath);

                extractor = new Extractor(filePath);
                extractor.Extract(GetArguments());

                foreach (var item in extractor.ExtractedStrings)
                {
                    StringParser.ItemValues values = StringParser.GetValues(fileBytes, item);

                    AddItem(item, values.Encoding, values.Entropy, values.Occurrences);
                }

                // Remove panel covers
                InvokeUI(() =>
                {
                    pnlCoverEdit.Visible = false;
                    pnlCoverBuild.Visible = false;
                });
            });

           
        }

        /// <summary>
        /// Invokes an action on the UI thread
        /// </summary>
        private void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }

        public void AddItem(string str, string encoding, string entropy, string occurrences)
        {
            InvokeUI(() =>
            {
                lstStrings.Items.Add(lstStrings.Items.Count.ToString());
                lstStrings.Items[lstStrings.Items.Count - 1].SubItems.AddRange(new[] { str, encoding, str.Length.ToString(), entropy, occurrences });
            });
        }

        /// <summary>
        /// Brings the user to the next tab
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            strafeTabControl1.SelectedTab = tabEdit;
        }

        /// <summary>
        /// Loads the progress bar and displays the next button
        /// </summary>
        private void OnLoadGuiUpdate()
        {
            pbProgress.Visible = true;
            var tmrProgress = new Timer { Interval = 8 };
            tmrProgress.Tick += (p1, p2) =>
            {
                if (pbProgress.Progress >= 100f)
                {
                    tmrProgress.Stop();
                    btnNext.Visible = true;
                }
                pbProgress.Progress += 1f;
            };
            tmrProgress.Start();
        }

        /// <summary>
        /// Links the user to the website
        /// </summary>
        private void btnToWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://sorin.tech");

        /// <summary>
        /// Links the user to the strings dl page
        /// </summary>
        private void btnToStringsWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/sysinternals/downloads/strings");

        /// <summary>
        /// Links the user to the github project
        /// </summary>
        private void btnToGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://github.com/WopsVSV/StringEdit");

        /// <summary>
        /// Cancels the width resize
        /// </summary>
        private void lstStrings_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstStrings.Columns[e.ColumnIndex].Width;
        }

        /// <summary>
        /// Determines additional arguments based on settings
        /// </summary>
        private string GetArguments()
        {
            string retVal = string.Empty;

            if (chkEncASCII.Checked)
                retVal += "-a";
            if (chkEncUTF16.Checked)
                retVal += "-u";

            int minSize = int.Parse(txtMinSize.Text);
            if (minSize > 3)
                retVal += " -n " + minSize;

            int indexOfStrings = Finder.FindBytes(fileBytes, Encoding.ASCII.GetBytes("#Strings"));
            if (indexOfStrings != 0)
            {
                retVal += " -f " + indexOfStrings;
            }

            return retVal;
        }

        /// <summary>
        /// Changes the global flag accordingly
        /// </summary>
        private void chkSmartFilters_CheckedChanged(object sender, EventArgs e)
        {
            Globals.UseSmartFilters = chkSmartFilters.Checked;
        }

        /// <summary>
        /// Changes the global flag accordingly
        /// </summary>
        private void chkExtremeFilters_CheckedChanged(object sender, EventArgs e)
        {
            Globals.UseExtremeFilters = chkExtremeFilters.Checked;
        }

        /// <summary>
        /// Changes the global flag accordingly
        /// </summary>
        private void chkRemoveDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            Globals.RemoveDuplicates = chkRemoveDuplicates.Checked;
        }

        /// <summary>
        /// Changes the global flag accordingly
        /// </summary>
        private void chkBackup_CheckedChanged(object sender, EventArgs e)
        {
            Globals.CreateBackup = chkBackup.Checked;
        }

        /// <summary>
        /// Opens the basic edit form
        /// </summary>
        private void basicEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBasicEdit(lstStrings.SelectedItems[0].SubItems[1].Text, lstStrings.SelectedItems[0].Index).Show();
        }
    }
}
