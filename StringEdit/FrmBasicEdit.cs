using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrafeTheme;

namespace StringEdit
{
    public partial class FrmBasicEdit : Form
    {
        private int listIndex;
        private string type;
        private FrmMain main;
        private bool worked;

        public FrmBasicEdit(string originalString, int listIndex, string type)
        {
            InitializeComponent();

            txtOriginalString.Text = originalString;
            this.listIndex = listIndex;
            main = (FrmMain) Application.OpenForms["FrmMain"];
            this.type = type;
        }

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e) => Extensions.BorderlessForm_MouseDown(this, sender, e);

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // Check length

            if (txtOriginalString.Text.Length != txtNewString.Text.Length)
            {
                txtNewString.Text = Replacer.AdjustString(txtOriginalString.Text, txtNewString.Text);
                return;
            }

            txtNewString.Enabled = false;

            bool all;
            if (sender as StrafeButton == btnReplace)
                all = false;
            else
                all = true;

            if (type == "Both")
            {
                ReplaceASCII(all);
                ReplaceUTF16(all);
                // TODO: BOTTOM RIGHT OF SCREEN NOTIFICATION
            }
            else if (type == "ASCII")
            {
                ReplaceASCII(all);
            }
            else if (type == "UTF-16")
            {
                ReplaceUTF16(all);
            }

            if (!worked)
            {
                this.Close();
                return;
            }

            if (all)
            {
                main.lstStrings.Items[listIndex].SubItems[1].Text = txtNewString.Text;
            }
            else
            {
                // fuck my life
                int numberOfReplaces = (type == "Both") ? 2 : 1;
                int occurrences = int.Parse(main.lstStrings.Items[listIndex].SubItems[5].Text);

                if (occurrences - numberOfReplaces <= 0)
                {
                    main.lstStrings.Items[listIndex].SubItems[1].Text = txtNewString.Text;
                    main.lstStrings.Items[listIndex].SubItems[4].Text = StringParser.ShannonEntropy(txtNewString.Text).ToString("F");
                }
                else
                {
                    main.lstStrings.Items[listIndex].SubItems[5].Text =
                        (occurrences - numberOfReplaces).ToString();

                    main.AddItem(txtNewString.Text, type, StringParser.ShannonEntropy(txtNewString.Text).ToString("F"),
                        numberOfReplaces.ToString());
                }
            }

            this.Close();
        }

        /// <summary>
        /// Replaces an ASCII encoded string
        /// </summary>
        private void ReplaceASCII(bool all)
        {
            var inputBytes = Encoding.ASCII.GetBytes(txtNewString.Text);
            var result = all ? Replacer.ReplaceAll(FrmMain.fileBytes, Encoding.ASCII.GetBytes(txtOriginalString.Text), inputBytes) : Replacer.ReplaceFirst(FrmMain.fileBytes, Encoding.ASCII.GetBytes(txtOriginalString.Text), inputBytes);
            worked = result.Worked;
            if (result.Worked)
                FrmMain.fileBytes = result.Bytes;
        }

        /// <summary>
        /// Replaces an UTF-16 encoded string
        /// </summary>
        private void ReplaceUTF16(bool all)
        {
            var inputBytes = StringParser.GetUTF16Bytes(txtNewString.Text, false);
            var result = all ? Replacer.ReplaceAll(FrmMain.fileBytes, StringParser.GetUTF16Bytes(txtOriginalString.Text, false), inputBytes) : Replacer.ReplaceFirst(FrmMain.fileBytes, StringParser.GetUTF16Bytes(txtOriginalString.Text, false), inputBytes);
            worked = result.Worked;
            if (result.Worked)
                FrmMain.fileBytes = result.Bytes;
        }
    }
}
