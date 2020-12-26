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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain logout = new frmmain();
            logout.MdiParent = this;
            logout.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewcustomer new_customer = new frmnewcustomer();
            new_customer.MdiParent = this;
            new_customer.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomerlist customer_list = new frmcustomerlist();
            customer_list.MdiParent = this;
            customer_list.Show();
        }
    }
}
