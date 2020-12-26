using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_Sell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sign_in Sin = new sign_in();
            Sin.MdiParent = this;
            Sin.Show();
        }
    }
}
