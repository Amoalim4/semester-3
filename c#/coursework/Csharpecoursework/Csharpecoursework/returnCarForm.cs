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
    public partial class returnCarForm : Form
    {
        public returnCarForm()
        {
            InitializeComponent();
            
        }
        //public string commmentsE { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnCarForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chbcomment_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            string CustomerName = txtCustomername.Text;
            string date = DTbtn.Value.ToString();
            string carName = txtcarname.Text;
            string model = txtmodel.Text;
            //string all = txtexp.Text;

            
           

            Test_BookingClass book = new Test_BookingClass();
            book.list();
            if (book.list().Contains(txtcarname.Text) && book.list().Contains(txtmodel.Text)) 
            {
                if (txtCustomername.Text == "" || txtCustomername.Text == " ")
                {
                    MessageBox.Show("Please tell us your name");
                }
                else
                {
                    
                    if (txtcarname.Text == "" || txtcarname.Text == " " || txtmodel.Text == "" || txtmodel.Text == " ")
                    {
                        MessageBox.Show("add car details");
                    }
                    else
                    {

                        if (txtExp.Text == "" || txtExp.Text == " ")
                        {
                            MessageBox.Show("Please Add some comments");
                            
                        }
                        else
                        {
                            book.Comments = txtExp.Text;
                            book.carReturned(CustomerName, date, carName, model);
                            MessageBox.Show(" Data recorded Thank you");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("sorry this car is not registerd as out of testing ");
            }
	
        }

        private void btnAddcomment_Click(object sender, EventArgs e)
        {
            //CommentForm cmn = new CommentForm();
            
            //cmn.Show();
        }
    }
}
