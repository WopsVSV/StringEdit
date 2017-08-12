namespace StringEdit
{
    partial class FrmBasicEdit
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
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnReplace = new StrafeTheme.StrafeButton();
            this.btnReplaceAll = new StrafeTheme.StrafeButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewString = new System.Windows.Forms.TextBox();
            this.btnClose = new StrafeTheme.StrafeButton();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.White;
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Controls.Add(this.txtNewString);
            this.pnlBorder.Controls.Add(this.label2);
            this.pnlBorder.Controls.Add(this.txtOriginalString);
            this.pnlBorder.Controls.Add(this.label1);
            this.pnlBorder.Controls.Add(this.btnReplaceAll);
            this.pnlBorder.Controls.Add(this.btnReplace);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(263, 139);
            this.pnlBorder.TabIndex = 0;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown);
            // 
            // btnReplace
            // 
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.EnabledCalc = true;
            this.btnReplace.Location = new System.Drawing.Point(11, 96);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Replace one";
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceAll.EnabledCalc = true;
            this.btnReplaceAll.Location = new System.Drawing.Point(92, 96);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 1;
            this.btnReplaceAll.Text = "Replace all";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "String:";
            // 
            // txtOriginalString
            // 
            this.txtOriginalString.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtOriginalString.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalString.Location = new System.Drawing.Point(59, 22);
            this.txtOriginalString.MaxLength = 32000;
            this.txtOriginalString.Name = "txtOriginalString";
            this.txtOriginalString.ReadOnly = true;
            this.txtOriginalString.Size = new System.Drawing.Size(188, 20);
            this.txtOriginalString.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "New:";
            // 
            // txtNewString
            // 
            this.txtNewString.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewString.Location = new System.Drawing.Point(59, 58);
            this.txtNewString.MaxLength = 32000;
            this.txtNewString.Name = "txtNewString";
            this.txtNewString.Size = new System.Drawing.Size(188, 20);
            this.txtNewString.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.EnabledCalc = true;
            this.btnClose.Location = new System.Drawing.Point(172, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new StrafeTheme.Base.ButtonBase.ClickEventHandler(this.btnClose_Click);
            // 
            // FrmBasicEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 139);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBasicEdit";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.TopMost = true;
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private StrafeTheme.StrafeButton btnReplace;
        private System.Windows.Forms.Label label1;
        private StrafeTheme.StrafeButton btnReplaceAll;
        private StrafeTheme.StrafeButton btnClose;
        private System.Windows.Forms.TextBox txtNewString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOriginalString;
    }
}