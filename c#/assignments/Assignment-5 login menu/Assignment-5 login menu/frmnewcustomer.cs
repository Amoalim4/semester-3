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
    struct new_customer_list
    {
        public String name;
        public String address;
        public char gender;
    }
    public partial class frmnewcustomer : Form
    {
        public frmnewcustomer()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // new object for the structure to store the new
            new_customer_list cust = new new_customer_list();
            

            //new arrey to storethe new info
            new_customer_list[] customer_list = new new_customer_list[5];
            
            cust.name = txtnewname.Text;
            cust.address = txtnewaddress.Text;

            // Gender
            char M_or_f;
            if (rbtnmale.Checked)
            {
                M_or_f = 'M';
            }
            else
            {
                M_or_f = '.';
            }
            if (rbtnfemale.Checked)
            {
                M_or_f = 'F';
            }
            cust.gender = M_or_f;

            // transfaring the new info to the Array
            customer_list[0] = cust;

            //new object to the next page
            frmcustomerlist new_list = new frmcustomerlist(customer_list[0].name, customer_list[0].gender, customer_list[0].address);
            new_list.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
