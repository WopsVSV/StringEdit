using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            main.lstStrings.Items[index] = txtToReplace.Text;
            this.Close();
        }
    }
}
