using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carSellManegmentSystem
{
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Newcustomer new_customer = new Newcustomer();
            new_customer.MdiParent = this;
            new_customer.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewCustomerClass Clist = new NewCustomerClass();
            //Clist.list_Customer();

            List_customerD list = new List_customerD();
            list.Show();
        }

        private void carsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarClass cls = new CarClass();
            
        }

        private void mainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
