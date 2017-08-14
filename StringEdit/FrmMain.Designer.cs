namespace StringEdit
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.strafeTabControl1 = new StrafeTheme.StrafeTabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.btnNext = new StrafeTheme.StrafeButton();
            this.pbProgress = new StrafeTheme.StrafeCircular();
            this.txtBuild = new System.Windows.Forms.Label();
            this.strafeSeparator1 = new StrafeTheme.StrafeSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.chkBackup = new StrafeTheme.StrafeOnOffBox();
            this.label19 = new System.Windows.Forms.Label();
            this.strafeHeader8 = new StrafeTheme.StrafeHeader();
            this.chkRemoveDuplicates = new StrafeTheme.StrafeOnOffBox();
            this.label18 = new System.Windows.Forms.Label();
            this.strafeHeader7 = new StrafeTheme.StrafeHeader();
            this.chkExtremeFilters = new StrafeTheme.StrafeOnOffBox();
            this.label17 = new System.Windows.Forms.Label();
            this.strafeHeader6 = new StrafeTheme.StrafeHeader();
            this.chkSmartFilters = new StrafeTheme.StrafeOnOffBox();
            this.label16 = new System.Windows.Forms.Label();
            this.strafeHeader5 = new StrafeTheme.StrafeHeader();
            this.chkIgnore = new StrafeTheme.StrafeOnOffBox();
            this.label15 = new System.Windows.Forms.Label();
            this.strafeHeader4 = new StrafeTheme.StrafeHeader();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMinSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.strafeHeader3 = new StrafeTheme.StrafeHeader();
            this.label12 = new System.Windows.Forms.Label();
            this.strafeHeader2 = new StrafeTheme.StrafeHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEncUTF16 = new StrafeTheme.StrafeRadioButton();
            this.chkEncBoth = new StrafeTheme.StrafeRadioButton();
            this.chkEncASCII = new StrafeTheme.StrafeRadioButton();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnFind = new StrafeTheme.StrafeButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.strafeSeparator2 = new StrafeTheme.StrafeSeparator();
            this.label11 = new System.Windows.Forms.Label();
            this.strafeHeader1 = new StrafeTheme.StrafeHeader();
            this.lstStrings = new System.Windows.Forms.ListView();
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEncoding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEntropy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOccurences = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.basicEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCoverEdit = new System.Windows.Forms.Panel();
            this.tabBuild = new System.Windows.Forms.TabPage();
            this.strafeSeparator3 = new StrafeTheme.StrafeSeparator();
            this.label22 = new System.Windows.Forms.Label();
            this.strafeHeader10 = new StrafeTheme.StrafeHeader();
            this.btnCustomPath = new StrafeTheme.StrafeButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomPath = new System.Windows.Forms.TextBox();
            this.btnBuild = new StrafeTheme.StrafeButton();
            this.pnlCoverBuild = new System.Windows.Forms.Panel();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnToGithub = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnToStringsWebsite = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnToWebsite = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.strafeSeparator4 = new StrafeTheme.StrafeSeparator();
            this.label20 = new System.Windows.Forms.Label();
            this.strafeHeader9 = new StrafeTheme.StrafeHeader();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.btnReset = new StrafeTheme.StrafeButton();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.strafeTabControl1.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.cmsList.SuspendLayout();
            this.tabBuild.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // strafeTabControl1
            // 
            this.strafeTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.strafeTabControl1.Controls.Add(this.tabLoad);
            this.strafeTabControl1.Controls.Add(this.tabSettings);
            this.strafeTabControl1.Controls.Add(this.tabEdit);
            this.strafeTabControl1.Controls.Add(this.tabBuild);
            this.strafeTabControl1.Controls.Add(this.tabAbout);
            this.strafeTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strafeTabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.strafeTabControl1.ItemSize = new System.Drawing.Size(40, 180);
            this.strafeTabControl1.Location = new System.Drawing.Point(0, 0);
            this.strafeTabControl1.Multiline = true;
            this.strafeTabControl1.Name = "strafeTabControl1";
            this.strafeTabControl1.OverIndex = -1;
            this.strafeTabControl1.SelectedIndex = 0;
            this.strafeTabControl1.Size = new System.Drawing.Size(807, 546);
            this.strafeTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.strafeTabControl1.TabIndex = 0;
            this.strafeTabControl1.Tag = "";
            // 
            // tabLoad
            // 
            this.tabLoad.AllowDrop = true;
            this.tabLoad.BackColor = System.Drawing.Color.White;
            this.tabLoad.Controls.Add(this.btnReset);
            this.tabLoad.Controls.Add(this.btnNext);
            this.tabLoad.Controls.Add(this.pbProgress);
            this.tabLoad.Controls.Add(this.txtBuild);
            this.tabLoad.Controls.Add(this.strafeSeparator1);
            this.tabLoad.Controls.Add(this.label2);
            this.tabLoad.Controls.Add(this.label1);
            this.tabLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabLoad.Location = new System.Drawing.Point(184, 4);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoad.Size = new System.Drawing.Size(619, 538);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Tag = "#C95858";
            this.tabLoad.Text = "Load";
            this.tabLoad.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabLoad_DragDrop);
            this.tabLoad.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabLoad_DragEnter);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.EnabledCalc = true;
            this.btnNext.Location = new System.Drawing.Point(259, 277);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 27);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.Visible = false;
            this.btnNext.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnNext_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(264, 184);
            this.pbProgress.Max = 100F;
            this.pbProgress.Min = 0F;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Progress = 0F;
            this.pbProgress.ShowMax = false;
            this.pbProgress.Size = new System.Drawing.Size(75, 72);
            this.pbProgress.TabIndex = 5;
            this.pbProgress.Visible = false;
            // 
            // txtBuild
            // 
            this.txtBuild.AutoSize = true;
            this.txtBuild.Location = new System.Drawing.Point(6, 518);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(34, 15);
            this.txtBuild.TabIndex = 3;
            this.txtBuild.Text = "Build";
            // 
            // strafeSeparator1
            // 
            this.strafeSeparator1.Location = new System.Drawing.Point(142, 66);
            this.strafeSeparator1.Name = "strafeSeparator1";
            this.strafeSeparator1.Size = new System.Drawing.Size(337, 6);
            this.strafeSeparator1.TabIndex = 2;
            this.strafeSeparator1.Text = "strafeSeparator1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag and drop an executable file to proceed.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some programs might not allow the tampering of the binaries. \r\nCheck the Terms of" +
    " Service of the program before proceeding.";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.chkBackup);
            this.tabSettings.Controls.Add(this.label19);
            this.tabSettings.Controls.Add(this.strafeHeader8);
            this.tabSettings.Controls.Add(this.chkRemoveDuplicates);
            this.tabSettings.Controls.Add(this.label18);
            this.tabSettings.Controls.Add(this.strafeHeader7);
            this.tabSettings.Controls.Add(this.chkExtremeFilters);
            this.tabSettings.Controls.Add(this.label17);
            this.tabSettings.Controls.Add(this.strafeHeader6);
            this.tabSettings.Controls.Add(this.chkSmartFilters);
            this.tabSettings.Controls.Add(this.label16);
            this.tabSettings.Controls.Add(this.strafeHeader5);
            this.tabSettings.Controls.Add(this.chkIgnore);
            this.tabSettings.Controls.Add(this.label15);
            this.tabSettings.Controls.Add(this.strafeHeader4);
            this.tabSettings.Controls.Add(this.label14);
            this.tabSettings.Controls.Add(this.txtMinSize);
            this.tabSettings.Controls.Add(this.label13);
            this.tabSettings.Controls.Add(this.strafeHeader3);
            this.tabSettings.Controls.Add(this.label12);
            this.tabSettings.Controls.Add(this.strafeHeader2);
            this.tabSettings.Controls.Add(this.panel1);
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabSettings.Location = new System.Drawing.Point(184, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(619, 538);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Tag = "#DFDF20";
            this.tabSettings.Text = "Settings";
            // 
            // chkBackup
            // 
            this.chkBackup.Checked = true;
            this.chkBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBackup.EnabledCalc = true;
            this.chkBackup.Location = new System.Drawing.Point(28, 491);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(38, 23);
            this.chkBackup.TabIndex = 24;
            this.chkBackup.Text = "strafeOnOffBox1";
            this.chkBackup.CheckedChanged += new StrafeTheme.Base.CheckControl.CheckedChangedEventHandler(this.chkBackup_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 471);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "Creates a copy of the executable.";
            // 
            // strafeHeader8
            // 
            this.strafeHeader8.Location = new System.Drawing.Point(24, 440);
            this.strafeHeader8.Name = "strafeHeader8";
            this.strafeHeader8.Size = new System.Drawing.Size(177, 32);
            this.strafeHeader8.TabIndex = 22;
            this.strafeHeader8.Text = "Backup";
            // 
            // chkRemoveDuplicates
            // 
            this.chkRemoveDuplicates.Checked = true;
            this.chkRemoveDuplicates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRemoveDuplicates.EnabledCalc = true;
            this.chkRemoveDuplicates.Location = new System.Drawing.Point(28, 357);
            this.chkRemoveDuplicates.Name = "chkRemoveDuplicates";
            this.chkRemoveDuplicates.Size = new System.Drawing.Size(38, 23);
            this.chkRemoveDuplicates.TabIndex = 21;
            this.chkRemoveDuplicates.Text = "strafeOnOffBox1";
            this.chkRemoveDuplicates.CheckedChanged += new StrafeTheme.Base.CheckControl.CheckedChangedEventHandler(this.chkRemoveDuplicates_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 338);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(235, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "Removes duplicates. Will increase run time.";
            // 
            // strafeHeader7
            // 
            this.strafeHeader7.Location = new System.Drawing.Point(24, 306);
            this.strafeHeader7.Name = "strafeHeader7";
            this.strafeHeader7.Size = new System.Drawing.Size(177, 32);
            this.strafeHeader7.TabIndex = 19;
            this.strafeHeader7.Text = "Remove duplicates";
            // 
            // chkExtremeFilters
            // 
            this.chkExtremeFilters.Checked = false;
            this.chkExtremeFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExtremeFilters.EnabledCalc = true;
            this.chkExtremeFilters.Location = new System.Drawing.Point(353, 357);
            this.chkExtremeFilters.Name = "chkExtremeFilters";
            this.chkExtremeFilters.Size = new System.Drawing.Size(38, 23);
            this.chkExtremeFilters.TabIndex = 18;
            this.chkExtremeFilters.Text = "strafeOnOffBox1";
            this.chkExtremeFilters.CheckedChanged += new StrafeTheme.Base.CheckControl.CheckedChangedEventHandler(this.chkExtremeFilters_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(348, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(248, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Caution: these filters might block valid strings";
            // 
            // strafeHeader6
            // 
            this.strafeHeader6.Location = new System.Drawing.Point(347, 306);
            this.strafeHeader6.Name = "strafeHeader6";
            this.strafeHeader6.Size = new System.Drawing.Size(177, 32);
            this.strafeHeader6.TabIndex = 16;
            this.strafeHeader6.Text = "Extreme filters";
            // 
            // chkSmartFilters
            // 
            this.chkSmartFilters.Checked = true;
            this.chkSmartFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSmartFilters.EnabledCalc = true;
            this.chkSmartFilters.Location = new System.Drawing.Point(353, 225);
            this.chkSmartFilters.Name = "chkSmartFilters";
            this.chkSmartFilters.Size = new System.Drawing.Size(38, 23);
            this.chkSmartFilters.TabIndex = 15;
            this.chkSmartFilters.Text = "strafeOnOffBox1";
            this.chkSmartFilters.CheckedChanged += new StrafeTheme.Base.CheckControl.CheckedChangedEventHandler(this.chkSmartFilters_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "The smart filter will block most bogus strings";
            // 
            // strafeHeader5
            // 
            this.strafeHeader5.Location = new System.Drawing.Point(347, 171);
            this.strafeHeader5.Name = "strafeHeader5";
            this.strafeHeader5.Size = new System.Drawing.Size(177, 32);
            this.strafeHeader5.TabIndex = 13;
            this.strafeHeader5.Text = "Smart filters";
            // 
            // chkIgnore
            // 
            this.chkIgnore.Checked = true;
            this.chkIgnore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIgnore.EnabledCalc = true;
            this.chkIgnore.Location = new System.Drawing.Point(29, 226);
            this.chkIgnore.Name = "chkIgnore";
            this.chkIgnore.Size = new System.Drawing.Size(38, 23);
            this.chkIgnore.TabIndex = 12;
            this.chkIgnore.Text = "strafeOnOffBox1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Works only for managed. Starts at \'#Strings\' offset";
            // 
            // strafeHeader4
            // 
            this.strafeHeader4.Location = new System.Drawing.Point(24, 171);
            this.strafeHeader4.Name = "strafeHeader4";
            this.strafeHeader4.Size = new System.Drawing.Size(177, 32);
            this.strafeHeader4.TabIndex = 10;
            this.strafeHeader4.Text = "Ignore beginning";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Value:";
            // 
            // txtMinSize
            // 
            this.txtMinSize.Location = new System.Drawing.Point(392, 68);
            this.txtMinSize.MaxLength = 2;
            this.txtMinSize.Name = "txtMinSize";
            this.txtMinSize.Size = new System.Drawing.Size(39, 23);
            this.txtMinSize.TabIndex = 8;
            this.txtMinSize.Text = "3";
            this.txtMinSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Choose the minimum length of searched strings";
            // 
            // strafeHeader3
            // 
            this.strafeHeader3.Location = new System.Drawing.Point(347, 15);
            this.strafeHeader3.Name = "strafeHeader3";
            this.strafeHeader3.Size = new System.Drawing.Size(156, 32);
            this.strafeHeader3.TabIndex = 6;
            this.strafeHeader3.Text = "Minimum length";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Choose the type of strings to be searched";
            // 
            // strafeHeader2
            // 
            this.strafeHeader2.Location = new System.Drawing.Point(24, 15);
            this.strafeHeader2.Name = "strafeHeader2";
            this.strafeHeader2.Size = new System.Drawing.Size(156, 32);
            this.strafeHeader2.TabIndex = 4;
            this.strafeHeader2.Text = "String encoding";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkEncUTF16);
            this.panel1.Controls.Add(this.chkEncBoth);
            this.panel1.Controls.Add(this.chkEncASCII);
            this.panel1.Location = new System.Drawing.Point(17, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 85);
            this.panel1.TabIndex = 3;
            // 
            // chkEncUTF16
            // 
            this.chkEncUTF16.Checked = false;
            this.chkEncUTF16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEncUTF16.EnabledCalc = true;
            this.chkEncUTF16.Location = new System.Drawing.Point(12, 56);
            this.chkEncUTF16.Name = "chkEncUTF16";
            this.chkEncUTF16.Size = new System.Drawing.Size(77, 17);
            this.chkEncUTF16.TabIndex = 2;
            this.chkEncUTF16.Text = "UTF-16";
            // 
            // chkEncBoth
            // 
            this.chkEncBoth.Checked = true;
            this.chkEncBoth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEncBoth.EnabledCalc = true;
            this.chkEncBoth.Location = new System.Drawing.Point(12, 10);
            this.chkEncBoth.Name = "chkEncBoth";
            this.chkEncBoth.Size = new System.Drawing.Size(77, 17);
            this.chkEncBoth.TabIndex = 0;
            this.chkEncBoth.Text = "Both";
            // 
            // chkEncASCII
            // 
            this.chkEncASCII.Checked = false;
            this.chkEncASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEncASCII.EnabledCalc = true;
            this.chkEncASCII.Location = new System.Drawing.Point(12, 33);
            this.chkEncASCII.Name = "chkEncASCII";
            this.chkEncASCII.Size = new System.Drawing.Size(77, 17);
            this.chkEncASCII.TabIndex = 1;
            this.chkEncASCII.Text = "ASCII";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.White;
            this.tabEdit.Controls.Add(this.btnFind);
            this.tabEdit.Controls.Add(this.txtSearch);
            this.tabEdit.Controls.Add(this.strafeSeparator2);
            this.tabEdit.Controls.Add(this.label11);
            this.tabEdit.Controls.Add(this.strafeHeader1);
            this.tabEdit.Controls.Add(this.lstStrings);
            this.tabEdit.Controls.Add(this.pnlCoverEdit);
            this.tabEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabEdit.Location = new System.Drawing.Point(184, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(619, 538);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Tag = "#5050FF";
            this.tabEdit.Text = "Edit";
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.EnabledCalc = true;
            this.btnFind.Location = new System.Drawing.Point(535, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(407, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(122, 23);
            this.txtSearch.TabIndex = 6;
            // 
            // strafeSeparator2
            // 
            this.strafeSeparator2.Location = new System.Drawing.Point(31, 72);
            this.strafeSeparator2.Name = "strafeSeparator2";
            this.strafeSeparator2.Size = new System.Drawing.Size(563, 6);
            this.strafeSeparator2.TabIndex = 5;
            this.strafeSeparator2.Text = "strafeSeparator2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Modify the extracted strings from the executable.";
            // 
            // strafeHeader1
            // 
            this.strafeHeader1.Location = new System.Drawing.Point(26, 14);
            this.strafeHeader1.Name = "strafeHeader1";
            this.strafeHeader1.Size = new System.Drawing.Size(75, 32);
            this.strafeHeader1.TabIndex = 3;
            this.strafeHeader1.Text = "Strings";
            // 
            // lstStrings
            // 
            this.lstStrings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colString,
            this.colEncoding,
            this.colLength,
            this.colEntropy,
            this.colOccurences});
            this.lstStrings.ContextMenuStrip = this.cmsList;
            this.lstStrings.FullRowSelect = true;
            this.lstStrings.Location = new System.Drawing.Point(31, 87);
            this.lstStrings.Name = "lstStrings";
            this.lstStrings.Size = new System.Drawing.Size(563, 426);
            this.lstStrings.TabIndex = 2;
            this.lstStrings.UseCompatibleStateImageBehavior = false;
            this.lstStrings.View = System.Windows.Forms.View.Details;
            this.lstStrings.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstStrings_ColumnWidthChanging);
            // 
            // colNumber
            // 
            this.colNumber.Text = "#";
            this.colNumber.Width = 43;
            // 
            // colString
            // 
            this.colString.Text = "String";
            this.colString.Width = 193;
            // 
            // colEncoding
            // 
            this.colEncoding.Text = "Encoding";
            this.colEncoding.Width = 70;
            // 
            // colLength
            // 
            this.colLength.Text = "Length";
            this.colLength.Width = 74;
            // 
            // colEntropy
            // 
            this.colEntropy.Text = "Entropy";
            this.colEntropy.Width = 71;
            // 
            // colOccurences
            // 
            this.colOccurences.Text = "Occurrences";
            this.colOccurences.Width = 87;
            // 
            // cmsList
            // 
            this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicEditToolStripMenuItem,
            this.advancedEditToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelToolStripMenuItem});
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(151, 76);
            // 
            // basicEditToolStripMenuItem
            // 
            this.basicEditToolStripMenuItem.Name = "basicEditToolStripMenuItem";
            this.basicEditToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.basicEditToolStripMenuItem.Text = "Basic edit";
            this.basicEditToolStripMenuItem.Click += new System.EventHandler(this.basicEditToolStripMenuItem_Click);
            // 
            // advancedEditToolStripMenuItem
            // 
            this.advancedEditToolStripMenuItem.Name = "advancedEditToolStripMenuItem";
            this.advancedEditToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.advancedEditToolStripMenuItem.Text = "Advanced edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // pnlCoverEdit
            // 
            this.pnlCoverEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlCoverEdit.Name = "pnlCoverEdit";
            this.pnlCoverEdit.Size = new System.Drawing.Size(17, 17);
            this.pnlCoverEdit.TabIndex = 1;
            this.pnlCoverEdit.Tag = "Cover";
            // 
            // tabBuild
            // 
            this.tabBuild.BackColor = System.Drawing.Color.White;
            this.tabBuild.Controls.Add(this.txtSHA256);
            this.tabBuild.Controls.Add(this.label24);
            this.tabBuild.Controls.Add(this.label23);
            this.tabBuild.Controls.Add(this.txtSHA1);
            this.tabBuild.Controls.Add(this.strafeSeparator4);
            this.tabBuild.Controls.Add(this.label20);
            this.tabBuild.Controls.Add(this.strafeHeader9);
            this.tabBuild.Controls.Add(this.label21);
            this.tabBuild.Controls.Add(this.txtMD5);
            this.tabBuild.Controls.Add(this.strafeSeparator3);
            this.tabBuild.Controls.Add(this.label22);
            this.tabBuild.Controls.Add(this.strafeHeader10);
            this.tabBuild.Controls.Add(this.btnCustomPath);
            this.tabBuild.Controls.Add(this.label3);
            this.tabBuild.Controls.Add(this.txtCustomPath);
            this.tabBuild.Controls.Add(this.btnBuild);
            this.tabBuild.Controls.Add(this.pnlCoverBuild);
            this.tabBuild.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabBuild.Location = new System.Drawing.Point(184, 4);
            this.tabBuild.Name = "tabBuild";
            this.tabBuild.Size = new System.Drawing.Size(619, 538);
            this.tabBuild.TabIndex = 2;
            this.tabBuild.Tag = "#30DF30";
            this.tabBuild.Text = "Build";
            // 
            // strafeSeparator3
            // 
            this.strafeSeparator3.Location = new System.Drawing.Point(24, 52);
            this.strafeSeparator3.Name = "strafeSeparator3";
            this.strafeSeparator3.Size = new System.Drawing.Size(401, 6);
            this.strafeSeparator3.TabIndex = 10;
            this.strafeSeparator3.Text = "strafeSeparator3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(369, 15);
            this.label22.TabIndex = 9;
            this.label22.Text = "Choose a specific path. If not specified, the original will be overriden.";
            // 
            // strafeHeader10
            // 
            this.strafeHeader10.Location = new System.Drawing.Point(19, 8);
            this.strafeHeader10.Name = "strafeHeader10";
            this.strafeHeader10.Size = new System.Drawing.Size(135, 32);
            this.strafeHeader10.TabIndex = 8;
            this.strafeHeader10.Text = "Custom path";
            // 
            // btnCustomPath
            // 
            this.btnCustomPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomPath.Enabled = false;
            this.btnCustomPath.EnabledCalc = true;
            this.btnCustomPath.Location = new System.Drawing.Point(395, 61);
            this.btnCustomPath.Name = "btnCustomPath";
            this.btnCustomPath.Size = new System.Drawing.Size(30, 23);
            this.btnCustomPath.TabIndex = 7;
            this.btnCustomPath.Text = "...";
            this.btnCustomPath.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnCustomPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path:";
            // 
            // txtCustomPath
            // 
            this.txtCustomPath.Location = new System.Drawing.Point(61, 61);
            this.txtCustomPath.Name = "txtCustomPath";
            this.txtCustomPath.ReadOnly = true;
            this.txtCustomPath.Size = new System.Drawing.Size(328, 23);
            this.txtCustomPath.TabIndex = 5;
            // 
            // btnBuild
            // 
            this.btnBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuild.EnabledCalc = true;
            this.btnBuild.Location = new System.Drawing.Point(23, 254);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(100, 30);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnBuild_Click);
            // 
            // pnlCoverBuild
            // 
            this.pnlCoverBuild.Location = new System.Drawing.Point(0, 0);
            this.pnlCoverBuild.Name = "pnlCoverBuild";
            this.pnlCoverBuild.Size = new System.Drawing.Size(21, 19);
            this.pnlCoverBuild.TabIndex = 2;
            this.pnlCoverBuild.Tag = "Cover";
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
            this.tabAbout.Controls.Add(this.label10);
            this.tabAbout.Controls.Add(this.btnToGithub);
            this.tabAbout.Controls.Add(this.label9);
            this.tabAbout.Controls.Add(this.label8);
            this.tabAbout.Controls.Add(this.label7);
            this.tabAbout.Controls.Add(this.btnToStringsWebsite);
            this.tabAbout.Controls.Add(this.label6);
            this.tabAbout.Controls.Add(this.label5);
            this.tabAbout.Controls.Add(this.btnToWebsite);
            this.tabAbout.Controls.Add(this.label4);
            this.tabAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabAbout.Location = new System.Drawing.Point(184, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(619, 538);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Tag = "#FFFFFF";
            this.tabAbout.Text = "About";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Strafe theme by Naywyn";
            // 
            // btnToGithub
            // 
            this.btnToGithub.AutoSize = true;
            this.btnToGithub.Location = new System.Drawing.Point(302, 308);
            this.btnToGithub.Name = "btnToGithub";
            this.btnToGithub.Size = new System.Drawing.Size(43, 15);
            this.btnToGithub.TabIndex = 8;
            this.btnToGithub.TabStop = true;
            this.btnToGithub.Text = "Github";
            this.btnToGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnToGithub_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Website:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "This project is open-source!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Website:";
            // 
            // btnToStringsWebsite
            // 
            this.btnToStringsWebsite.AutoSize = true;
            this.btnToStringsWebsite.Location = new System.Drawing.Point(303, 199);
            this.btnToStringsWebsite.Name = "btnToStringsWebsite";
            this.btnToStringsWebsite.Size = new System.Drawing.Size(50, 15);
            this.btnToStringsWebsite.TabIndex = 4;
            this.btnToStringsWebsite.TabStop = true;
            this.btnToStringsWebsite.Text = "DL Page";
            this.btnToStringsWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnToStringsWebsite_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Strings program by Mark Russinovich";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Website:";
            // 
            // btnToWebsite
            // 
            this.btnToWebsite.AutoSize = true;
            this.btnToWebsite.Location = new System.Drawing.Point(302, 74);
            this.btnToWebsite.Name = "btnToWebsite";
            this.btnToWebsite.Size = new System.Drawing.Size(59, 15);
            this.btnToWebsite.TabIndex = 1;
            this.btnToWebsite.TabStop = true;
            this.btnToWebsite.Text = "sorin.tech";
            this.btnToWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnToWebsite_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Developed by Sorin Vijoaica (Wops)";
            // 
            // strafeSeparator4
            // 
            this.strafeSeparator4.Location = new System.Drawing.Point(24, 148);
            this.strafeSeparator4.Name = "strafeSeparator4";
            this.strafeSeparator4.Size = new System.Drawing.Size(401, 6);
            this.strafeSeparator4.TabIndex = 16;
            this.strafeSeparator4.Text = "strafeSeparator4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(222, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "The checksums generated after the build";
            // 
            // strafeHeader9
            // 
            this.strafeHeader9.Location = new System.Drawing.Point(19, 104);
            this.strafeHeader9.Name = "strafeHeader9";
            this.strafeHeader9.Size = new System.Drawing.Size(135, 32);
            this.strafeHeader9.TabIndex = 14;
            this.strafeHeader9.Text = "Checksums";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "MD5:";
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(76, 157);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(348, 23);
            this.txtMD5.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 190);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 15);
            this.label23.TabIndex = 18;
            this.label23.Text = "SHA1:";
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(76, 186);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.ReadOnly = true;
            this.txtSHA1.Size = new System.Drawing.Size(348, 23);
            this.txtSHA1.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.EnabledCalc = true;
            this.btnReset.Location = new System.Drawing.Point(507, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.Visible = false;
            this.btnReset.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnReset_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 218);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 15);
            this.label24.TabIndex = 19;
            this.label24.Text = "SHA256:";
            // 
            // txtSHA256
            // 
            this.txtSHA256.Location = new System.Drawing.Point(76, 214);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(348, 23);
            this.txtSHA256.TabIndex = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 546);
            this.Controls.Add(this.strafeTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StringEdit <Debug>";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.strafeTabControl1.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.cmsList.ResumeLayout(false);
            this.tabBuild.ResumeLayout(false);
            this.tabBuild.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private StrafeTheme.StrafeTabControl strafeTabControl1;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabBuild;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Panel pnlCoverEdit;
        private System.Windows.Forms.Panel pnlCoverBuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBuild;
        private StrafeTheme.StrafeSeparator strafeSeparator1;
        private System.Windows.Forms.Label label2;
        private StrafeTheme.StrafeCircular pbProgress;
        private StrafeTheme.StrafeButton btnNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel btnToWebsite;
        private System.Windows.Forms.LinkLabel btnToStringsWebsite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel btnToGithub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colString;
        private System.Windows.Forms.ColumnHeader colEncoding;
        private System.Windows.Forms.ColumnHeader colLength;
        private StrafeTheme.StrafeSeparator strafeSeparator2;
        private System.Windows.Forms.Label label11;
        private StrafeTheme.StrafeHeader strafeHeader1;
        private System.Windows.Forms.ColumnHeader colEntropy;
        private System.Windows.Forms.ColumnHeader colOccurences;
        private System.Windows.Forms.Label label12;
        private StrafeTheme.StrafeHeader strafeHeader2;
        private System.Windows.Forms.Panel panel1;
        private StrafeTheme.StrafeRadioButton chkEncUTF16;
        private StrafeTheme.StrafeRadioButton chkEncBoth;
        private StrafeTheme.StrafeRadioButton chkEncASCII;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMinSize;
        private System.Windows.Forms.Label label13;
        private StrafeTheme.StrafeHeader strafeHeader3;
        private StrafeTheme.StrafeOnOffBox chkIgnore;
        private System.Windows.Forms.Label label15;
        private StrafeTheme.StrafeHeader strafeHeader4;
        private StrafeTheme.StrafeOnOffBox chkSmartFilters;
        private System.Windows.Forms.Label label16;
        private StrafeTheme.StrafeHeader strafeHeader5;
        private StrafeTheme.StrafeOnOffBox chkExtremeFilters;
        private System.Windows.Forms.Label label17;
        private StrafeTheme.StrafeHeader strafeHeader6;
        private StrafeTheme.StrafeOnOffBox chkRemoveDuplicates;
        private System.Windows.Forms.Label label18;
        private StrafeTheme.StrafeHeader strafeHeader7;
        private StrafeTheme.StrafeOnOffBox chkBackup;
        private System.Windows.Forms.Label label19;
        private StrafeTheme.StrafeHeader strafeHeader8;
        private System.Windows.Forms.ContextMenuStrip cmsList;
        private System.Windows.Forms.ToolStripMenuItem basicEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        public System.Windows.Forms.ListView lstStrings;
        private StrafeTheme.StrafeButton btnBuild;
        private StrafeTheme.StrafeButton btnCustomPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomPath;
        private StrafeTheme.StrafeSeparator strafeSeparator3;
        private System.Windows.Forms.Label label22;
        private StrafeTheme.StrafeHeader strafeHeader10;
        private StrafeTheme.StrafeButton btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSHA1;
        private StrafeTheme.StrafeSeparator strafeSeparator4;
        private System.Windows.Forms.Label label20;
        private StrafeTheme.StrafeHeader strafeHeader9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMD5;
        private StrafeTheme.StrafeButton btnReset;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Label label24;
    }
}

