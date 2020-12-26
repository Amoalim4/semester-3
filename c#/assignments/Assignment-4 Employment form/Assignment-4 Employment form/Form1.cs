using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_Employment_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            lbladdress.Text = txtaddress.Text;
            lbldepartment.Text = txtdepartment.Text;
            lblname.Text = txtname.Text;
            lblstate.Text = cmbstates.Text;
            lbltell.Text = txttell.Text;
            lblposition.Text = txtposition.Text;

            //  year and age
            int curent_year = 2020;
            int year_of_brith = int.Parse(txtyear.Text);
            int age = curent_year - year_of_brith;
            lblage.Text = age.ToString();

            // salary per year
            double salary = double.Parse(txtsalary.Text);
            double salary_per_year = salary * 12;
            lblsalary.Text = salary_per_year.ToString();

            // married or not

            bool married;

            if (rbnyes.Checked)
            {
                married = true;
            }
            else
            {
                married = false;
            }
            lblmarried.Text = married.ToString();


            // Hobies   --> check list box
            lbxhobies.Items.Clear();
            for (int i = 0; i < clbhobies.CheckedIndices.Count; i++)
            {
                lbxhobies.Items.Add(clbhobies.CheckedItems[i]);
            }


            // object to the next page

            thank_you Registration_saved = new thank_you(txtname.Text, txttell.Text, txtaddress.Text);
            Registration_saved.Show();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnyes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
