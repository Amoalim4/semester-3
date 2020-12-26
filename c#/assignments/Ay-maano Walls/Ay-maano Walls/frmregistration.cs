using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_maano_Walls
{
    public partial class frmregistration : Form
    {
        public frmregistration()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            frminvoces invoce = new frminvoces(txtname.Text,txtphone.Text,txtaddress.Text,cbxmembership.Text);
           
            invoce.Show();
        }
    }
}
 