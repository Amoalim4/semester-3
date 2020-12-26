using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharpecoursework
{
    public partial class List_customer : Form
    {
        public List_customer()
        {
            InitializeComponent();
            CustomerClass class_of_customer = new CustomerClass();
            class_of_customer.list_Customer(riclistcustomer.Text);
            riclistcustomer.Text = class_of_customer.listcustomerinfo;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerClass Cclass = new CustomerClass();
            Cclass.UpdateCustomer(riclistcustomer.Text);
            MessageBox.Show("Successfully Updated ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            riclistcustomer.SelectedText = "";
            CustomerClass Cclass = new CustomerClass();
            Cclass.UpdateCustomer(riclistcustomer.Text);
            MessageBox.Show("Successfully Deleted");
        }
    }
}
