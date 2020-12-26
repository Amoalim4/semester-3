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
    public partial class Add_new_customer : Form
    {
        public Add_new_customer()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            CustomerClass add_new_customer = new CustomerClass();
            string name = txtname.Text;
            string tell = txttell.Text;
            string address = txtaddress.Text;
            string gender = "";
            string passport = txtpassport.Text;
            int age = 0;
            try
            {
                age = int.Parse(txtage.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Please Use only numbers \nno leters , symbols nor spaces");
            }
            
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
            if (add_new_customer.list().Contains(txtpassport.Text))
            {
                MessageBox.Show("This customer is already registred"); 
            }
            else
            {
                if (age != 0)
                {
                    add_new_customer.regester(name, gender, age, address, tell, passport);
                    MessageBox.Show("successfully added");
                }
               
            }
            
        }
        
        
    }
}
