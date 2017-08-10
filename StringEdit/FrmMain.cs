using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringEdit
{
    /// <summary>
    /// Main window for the program
    /// </summary>
    public partial class FrmMain : Form
    {
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
        }

        /// <summary>
        /// Remove the panel covers
        /// </summary>
        private void RemoveCovers()
        {
            pnlCoverEdit.Visible = false;
            pnlCoverBuild.Visible = false;
        }

        /// <summary>
        /// DEBUG ONLY
        /// Increments the version in the build_version.txt
        /// </summary>
        private static string BuildIncrement()
        {
            int version = int.Parse(File.ReadAllText("build_version.txt").Replace("\r", string.Empty));
            version++;
            File.WriteAllText("build_version.txt", version.ToString());

            return version.ToString();
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
        private void tabLoad_DragDrop(object sender, DragEventArgs e)
        {
            // Fill the progress bar
            OnLoadGuiUpdate();

            // We know it's a single file because of the DragEnter event
            string filePath = e.GetDragItems()[0];

            RemoveCovers();           
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
        private void btnToWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sorin.tech");
        }

        /// <summary>
        /// Links the user to the strings dl page
        /// </summary>
        private void btnToStringsWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/sysinternals/downloads/strings");
        }

        /// <summary>
        /// Links the user to the github project
        /// </summary>
        private void btnToGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/WopsVSV/StringEdit");
        }
    }
}
