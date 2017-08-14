using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        public Extractor extractor;
        public static byte[] fileBytes;
        private string filePath;

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
            pnlCoverBuild.Location = new Point(0,0);
            pnlCoverEdit.Location = new Point(0, 0);
            pnlCoverBuild.BringToFront();
            pnlCoverEdit.BringToFront();

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
                this.filePath = filePath;

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
                    btnReset.Visible = true;
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
            new FrmBasicEdit(lstStrings.SelectedItems[0].SubItems[1].Text, lstStrings.SelectedItems[0].Index, lstStrings.SelectedItems[0].SubItems[2].Text).Show();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            string savePath;
            if (!string.IsNullOrEmpty(txtCustomPath.Text))
                savePath = txtCustomPath.Text;
            else
                savePath = filePath;

            try
            {
                File.WriteAllBytes(savePath, fileBytes);

                // Show checksums
                using (var md5 = MD5.Create())
                {
                    using (var buffer = File.OpenRead(savePath))
                    {
                        txtMD5.Text = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", string.Empty);
                    }
                }
                using (var sha1 = new SHA1CryptoServiceProvider())
                {
                    using (var buffer = File.OpenRead(savePath))
                    {
                        txtSHA1.Text = BitConverter.ToString(sha1.ComputeHash(buffer)).Replace("-", string.Empty);
                    }
                }
                using (var sha256 = new SHA256CryptoServiceProvider())
                {
                    using (var buffer = File.OpenRead(savePath))
                    {
                        txtSHA256.Text = BitConverter.ToString(sha256.ComputeHash(buffer)).Replace("-", string.Empty);
                    }
                }

                MessageBox.Show("File successfully built.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred while writing to the file:\n" + ex.Message);
            }
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (lstStrings.SelectedItems.Count > 0)
            {
                index = lstStrings.SelectedItems[0].Index + 1;
                if (index == lstStrings.Items.Count)
                    return;
            }
            for (var i = index; i < lstStrings.Items.Count; i++)
            {
                ListViewItem item = lstStrings.Items[i];

                if (item.SubItems[1].Text.Contains(txtSearch.Text))
                {
                    if (lstStrings.SelectedIndices.Count > 0)
                        for (int j = 0; j < lstStrings.SelectedIndices.Count; i++)
                        {
                            lstStrings.Items[lstStrings.SelectedIndices[j]].Selected = false;
                        }

                    item.Selected = true;
                    lstStrings.Select();
                    lstStrings.EnsureVisible(item.Index);
                    break;
                }
            }
        }

        private void btnCustomPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Executable files *.exe|*.exe";
            sfd.Title = "Select your custom path";
            sfd.FileOk += (o, args) =>
            {
                txtCustomPath.Text = sfd.FileName;
            };
            sfd.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Visible = false;
            btnNext.Visible = false;
            pbProgress.Progress = 0;
            pbProgress.Visible = false;
            txtCustomPath.Clear();
            txtMD5.Clear();
            txtSHA1.Clear();
            pnlCoverEdit.Visible = true;
            pnlCoverBuild.Visible = true;
        }
    }
}
