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
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.pnlCoverEdit = new System.Windows.Forms.Panel();
            this.tabBuild = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCoverBuild = new System.Windows.Forms.Panel();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.btnToStringsWebsite = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnToWebsite = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnToGithub = new System.Windows.Forms.LinkLabel();
            this.strafeTabControl1.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.tabEdit.SuspendLayout();
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
            this.strafeTabControl1.Size = new System.Drawing.Size(804, 475);
            this.strafeTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.strafeTabControl1.TabIndex = 0;
            this.strafeTabControl1.Tag = "";
            // 
            // tabLoad
            // 
            this.tabLoad.AllowDrop = true;
            this.tabLoad.BackColor = System.Drawing.Color.White;
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
            this.tabLoad.Size = new System.Drawing.Size(616, 467);
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
            this.btnNext.Location = new System.Drawing.Point(258, 277);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 27);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.Visible = false;
            this.btnNext.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnNext_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(263, 184);
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
            this.txtBuild.Location = new System.Drawing.Point(6, 447);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(34, 15);
            this.txtBuild.TabIndex = 3;
            this.txtBuild.Text = "Build";
            // 
            // strafeSeparator1
            // 
            this.strafeSeparator1.Location = new System.Drawing.Point(141, 66);
            this.strafeSeparator1.Name = "strafeSeparator1";
            this.strafeSeparator1.Size = new System.Drawing.Size(337, 6);
            this.strafeSeparator1.TabIndex = 2;
            this.strafeSeparator1.Text = "strafeSeparator1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag and drop an executable file to proceed.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some programs might not allow the tampering of the binaries. \r\nCheck the Terms of" +
    " Service of the program before proceeding.";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabSettings.Location = new System.Drawing.Point(184, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(616, 467);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Tag = "#DFDF20";
            this.tabSettings.Text = "Settings";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.White;
            this.tabEdit.Controls.Add(this.pnlCoverEdit);
            this.tabEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabEdit.Location = new System.Drawing.Point(184, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(616, 467);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Tag = "#5050FF";
            this.tabEdit.Text = "Edit";
            // 
            // pnlCoverEdit
            // 
            this.pnlCoverEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlCoverEdit.Name = "pnlCoverEdit";
            this.pnlCoverEdit.Size = new System.Drawing.Size(69, 53);
            this.pnlCoverEdit.TabIndex = 1;
            this.pnlCoverEdit.Tag = "Cover";
            // 
            // tabBuild
            // 
            this.tabBuild.BackColor = System.Drawing.Color.White;
            this.tabBuild.Controls.Add(this.pnlCoverBuild);
            this.tabBuild.Controls.Add(this.label3);
            this.tabBuild.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.tabBuild.Location = new System.Drawing.Point(184, 4);
            this.tabBuild.Name = "tabBuild";
            this.tabBuild.Size = new System.Drawing.Size(616, 467);
            this.tabBuild.TabIndex = 2;
            this.tabBuild.Tag = "#30DF30";
            this.tabBuild.Text = "Build";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Test";
            // 
            // pnlCoverBuild
            // 
            this.pnlCoverBuild.Location = new System.Drawing.Point(0, 0);
            this.pnlCoverBuild.Name = "pnlCoverBuild";
            this.pnlCoverBuild.Size = new System.Drawing.Size(99, 75);
            this.pnlCoverBuild.TabIndex = 2;
            this.pnlCoverBuild.Tag = "Cover";
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
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
            this.tabAbout.Size = new System.Drawing.Size(616, 467);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Tag = "#FFFFFF";
            this.tabAbout.Text = "About";
            // 
            // btnToStringsWebsite
            // 
            this.btnToStringsWebsite.AutoSize = true;
            this.btnToStringsWebsite.Location = new System.Drawing.Point(302, 219);
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
            this.label6.Location = new System.Drawing.Point(203, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Strings program by Mark Russinovich";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Website:";
            // 
            // btnToWebsite
            // 
            this.btnToWebsite.AutoSize = true;
            this.btnToWebsite.Location = new System.Drawing.Point(301, 94);
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
            this.label4.Location = new System.Drawing.Point(213, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Developed by Sorin Vijoaica (Wops)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Website:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "This project is open-source!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Website:";
            // 
            // btnToGithub
            // 
            this.btnToGithub.AutoSize = true;
            this.btnToGithub.Location = new System.Drawing.Point(301, 328);
            this.btnToGithub.Name = "btnToGithub";
            this.btnToGithub.Size = new System.Drawing.Size(43, 15);
            this.btnToGithub.TabIndex = 8;
            this.btnToGithub.TabStop = true;
            this.btnToGithub.Text = "Github";
            this.btnToGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnToGithub_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 475);
            this.Controls.Add(this.strafeTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "StringEdit <Debug>";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.strafeTabControl1.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.tabEdit.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
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
    }
}

