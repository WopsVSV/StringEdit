namespace Strings_Editor
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinStrSize = new System.Windows.Forms.TextBox();
            this.chkUseFilters = new System.Windows.Forms.CheckBox();
            this.grpStrings = new System.Windows.Forms.GroupBox();
            this.lstStrings = new System.Windows.Forms.ListBox();
            this.cmsStrings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditString = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.grpStrings.SuspendLayout();
            this.cmsStrings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warning: Files with a big size may not be able to be loaded.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag and drop any executable to begin.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(146, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.chkUseFilters);
            this.grpSettings.Controls.Add(this.txtMinStrSize);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Location = new System.Drawing.Point(146, 104);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(365, 79);
            this.grpSettings.TabIndex = 3;
            this.grpSettings.TabStop = false;
            this.grpSettings.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum string size:";
            // 
            // txtMinStrSize
            // 
            this.txtMinStrSize.Location = new System.Drawing.Point(179, 18);
            this.txtMinStrSize.Name = "txtMinStrSize";
            this.txtMinStrSize.Size = new System.Drawing.Size(35, 20);
            this.txtMinStrSize.TabIndex = 3;
            this.txtMinStrSize.Text = "4";
            // 
            // chkUseFilters
            // 
            this.chkUseFilters.AutoSize = true;
            this.chkUseFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUseFilters.Checked = true;
            this.chkUseFilters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseFilters.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.chkUseFilters.Location = new System.Drawing.Point(8, 46);
            this.chkUseFilters.Name = "chkUseFilters";
            this.chkUseFilters.Size = new System.Drawing.Size(184, 19);
            this.chkUseFilters.TabIndex = 4;
            this.chkUseFilters.Text = "Use filters (recommended):";
            this.chkUseFilters.UseVisualStyleBackColor = true;
            // 
            // grpStrings
            // 
            this.grpStrings.Controls.Add(this.lstStrings);
            this.grpStrings.Location = new System.Drawing.Point(146, 202);
            this.grpStrings.Name = "grpStrings";
            this.grpStrings.Size = new System.Drawing.Size(365, 232);
            this.grpStrings.TabIndex = 5;
            this.grpStrings.TabStop = false;
            this.grpStrings.Visible = false;
            // 
            // lstStrings
            // 
            this.lstStrings.FormattingEnabled = true;
            this.lstStrings.Location = new System.Drawing.Point(6, 19);
            this.lstStrings.Name = "lstStrings";
            this.lstStrings.Size = new System.Drawing.Size(353, 199);
            this.lstStrings.TabIndex = 0;
            // 
            // cmsStrings
            // 
            this.cmsStrings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditString});
            this.cmsStrings.Name = "cmsStrings";
            this.cmsStrings.Size = new System.Drawing.Size(95, 26);
            // 
            // btnEditString
            // 
            this.btnEditString.Name = "btnEditString";
            this.btnEditString.Size = new System.Drawing.Size(94, 22);
            this.btnEditString.Text = "Edit";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 446);
            this.Controls.Add(this.grpStrings);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strings Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpStrings.ResumeLayout(false);
            this.cmsStrings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUseFilters;
        private System.Windows.Forms.TextBox txtMinStrSize;
        private System.Windows.Forms.GroupBox grpStrings;
        private System.Windows.Forms.ListBox lstStrings;
        private System.Windows.Forms.ContextMenuStrip cmsStrings;
        private System.Windows.Forms.ToolStripMenuItem btnEditString;
    }
}

