using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_login_menu
{
    public partial class frmcustomerlist : Form
    {
        public frmcustomerlist(String name, char gender, String address)

        {
            InitializeComponent();
            lbxnames.Items.Clear();
            lbxaddress.Items.Clear();
            lbxgender.Items.Clear();
            
                
                lbxnames.Items.Add (name);
                lbxaddress.Items.Add(address);
                lbxgender.Items.Add( gender.ToString());
            
        }

        public frmcustomerlist()
        {
            // TODO: Complete member initialization
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmcustomerlist_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
