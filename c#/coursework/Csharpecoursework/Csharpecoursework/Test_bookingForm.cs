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
    public partial class Test_bookingForm : Form
    {
        public Test_bookingForm()
        {
            InitializeComponent();
        }

        private void Test_bookingForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void radiofemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiomale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test_BookingClass bookingTest = new Test_BookingClass();

            string Customer_name = txtCustomername.Text;
            string customer_tell = txtcustomerTell.Text;
            string customer_address = txtcustomerAddress.Text;
            int age = 0;
            int timeTaken = 0;
            try
            {
                age = int.Parse(txtage.Text);
                timeTaken = int.Parse(txtTimeTaken.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Use Only numbers in the Age and the Time");
            }
            

            int timeReturn = timeTaken+2;

            string passport = txtPassport.Text;
            string carName = txtcarName.Text;

            string carModal = txtmodel.Text;
            string gender = "";
            string license = txtlicense.Text;

            string Date = dateandTime.Value.ToString(); 

            if (radiofemale.Checked)
            {
                gender = "Female";
            }
            else if (radiomale.Checked)
            {
                gender = "Male";

            }
            else
            {
                MessageBox.Show("Select a gender ");
            }
            if (radioLyes.Checked)
            {
                if (age >= 18 && age <= 80)
                {
                    bookingTest.regester(Date, Customer_name,age,gender,customer_address,customer_tell,passport,carName,carModal,license,timeTaken,timeReturn);
                    MessageBox.Show("Successfully Registred");
                }
                else if (age > 80)
                {
                    MessageBox.Show("Sorry you are Older then the legal Age ");
                }
                else
                {
                    MessageBox.Show("Sorry you are younger then the legal Age ");
                }
            }
            else
            {
                MessageBox.Show("Sorry you must have license");
            }
            

            


         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtlicense.Visible = false;
            lblLicense.Visible = false;
        }

        private void radioLyes_CheckedChanged(object sender, EventArgs e)
        {
            txtlicense.Visible = true;
            lblLicense.Visible = true;
        }
    }
}
