using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEdit
{
    public partial class FrmBasicEdit : Form
    {
        private int listIndex;

        public FrmBasicEdit(string originalString, int listIndex)
        {
            InitializeComponent();

            txtOriginalString.Text = originalString;
            this.listIndex = listIndex;
        }

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e) => Extensions.BorderlessForm_MouseDown(this, sender, e);

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
