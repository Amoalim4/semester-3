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
    public partial class frminvoces : Form
    {
        public frminvoces( String name, String phone, String address ,String membership )
        {
            InitializeComponent();
            txtname.Text = name;
            cbxmembership.Text = membership;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //declaring new variabls 
            
            double previousm3 = double.Parse(txtprevious.Text);
            double newm3 = double.Parse(txtnewm3.Text);
            double meter3 =newm3 - previousm3 ;
            double invoce=0.0;
            //
            if (newm3 > previousm3)
            {
                if (cbxmembership.SelectedIndex == 0)
                {
                    invoce = meter3 * 0.85;
                }
                if (cbxmembership.SelectedIndex == 1)
                {
                    invoce = meter3 * 0.95;
                }
                if (cbxmembership.SelectedIndex == 2)
                {
                    invoce = meter3 * 1.05;
                }
                lblinvoce.Text = invoce.ToString();
            }
            else
            {
                MessageBox.Show("waraa ciyaata iga daa");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnewm3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
