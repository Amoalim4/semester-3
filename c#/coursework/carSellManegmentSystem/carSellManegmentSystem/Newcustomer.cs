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
    public partial class Newcustomer : Form 
    {
        public Newcustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsavenewcustomer_Click(object sender, EventArgs e)
        {
            string name = txtnewCname.Text;
            string tell = txtnewCtell.Text;
            string address = txtnewCaddress.Text;
            string gender = "";
            string passport = txtnewCpassport.Text;
            int age = int.Parse(txtnewCage.Text);
            if (radiomale.Checked)
            {
                gender = "Male";
            }
            
           else if (radiofemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Select gender");
            }
            NewCustomerClass Newcustomer = new NewCustomerClass();
            Newcustomer.regesterNewCustomer(name, gender, age, address, tell, passport);

            mainpage main = new mainpage();
            main.Show();
        }

       
    }
}
