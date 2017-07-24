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
    public partial class FormReplace : Form
    {
        private FormMain main;
        private int index;

        public FormReplace(string inputText, int lstIndex)
        {
            InitializeComponent();

            txtInputText.Text = inputText;
            index = lstIndex;
            main = (FormMain)Application.OpenForms["FormMain"];

        }

        private void FormReplace_Load(object sender, EventArgs e)
        {
            txtToReplace.Focus();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // Backup
            if (main.chkBackup.Checked && main.firstReplace)
            {
                File.WriteAllBytes(
                    Path.GetDirectoryName(main.filePath) + "/" + Path.GetFileNameWithoutExtension(main.filePath) +
                    "_backup" + Path.GetExtension(main.filePath), main.assemblyBytes);
            }

            // Check length
            if (txtToReplace.Text.Length < txtInputText.Text.Length)
            {
                while (txtToReplace.Text.Length != txtInputText.Text.Length)
                    txtToReplace.Text += " ";
            }
            else if (txtToReplace.Text.Length > txtInputText.Text.Length)
            {
                int cutLength = txtToReplace.Text.Length - txtInputText.Text.Length;
                txtToReplace.Text = txtToReplace.Text.Substring(0, txtInputText.Text.Length);
            }

            int unicodeMods, asciiMods;
            Utility.Result result;

            #region Unicode strings
            var inputBytes = GetRealBytes(txtInputText.Text);
            var replaceBytes = GetRealBytes(txtToReplace.Text);
            result = Utility.ReplaceBytes(main.assemblyBytes, inputBytes, replaceBytes);
            if (result.Worked)
                main.assemblyBytes = result.Bytes;

            unicodeMods = Utility.replacesDone;

            #endregion

            #region ASCII strings
            var inputBytesASCII = System.Text.Encoding.ASCII.GetBytes(txtInputText.Text);
            var replaceBytesASCII = System.Text.Encoding.ASCII.GetBytes(txtToReplace.Text);
            result = Utility.ReplaceBytes(main.assemblyBytes, inputBytesASCII, replaceBytesASCII);
            if (result.Worked)
                main.assemblyBytes = result.Bytes;

            asciiMods = Utility.replacesDone;
            #endregion

            main.lstStrings.Items[index] = txtToReplace.Text;

            MessageBox.Show(
                $"Replaced {unicodeMods + asciiMods} occurences.\nUnicode: {unicodeMods}\nASCII: {asciiMods}");

            this.Close();
        }

        private void chkInstructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Size.Height > 175)
            {
                this.Size = new Size(this.Size.Width, 160);
            }
            else
            {
                this.Size = new Size(this.Size.Width, 280);
            }

        }

        public byte[] GetRealBytes(string inputText)
        {
            byte[] input = System.Text.Encoding.ASCII.GetBytes(inputText);
            byte[] output = new byte[(input.Length - 1) * 2 + 1];

            int index = 0;
            foreach (var b in input)
            {
                output[index] = b;

                if (index != output.Length - 1)
                    output[index + 1] = 0x0;
                index += 2;
            }

            output[output.Length - 1] = input[input.Length - 1];

            return output;
        }
    }
}
