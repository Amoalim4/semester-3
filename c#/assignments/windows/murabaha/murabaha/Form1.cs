using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace murabaha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            double salary = 0;
            double amount = 0;

            double rate = 0;
            double total = 0;

            int month = 0;

            double per_month = 0;
            double aset = 0;
        private void btnApplay_Click(object sender, EventArgs e)
        {
            try
            {
                salary = double.Parse(txtsalary.Text);
                amount = double.Parse(txtamount.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Use only numbers in salary and amount");
            }
            if (comboxperiod.SelectedIndex == 0)
            {
                rate = 0.06;
                month = 6;
            }
            else if (comboxperiod.SelectedIndex == 1)
            {
                rate = 0.12;
                month = 12;
            }
            else if (comboxperiod.SelectedIndex ==2)
            {
                rate = 0.18;
                month = 18;
            }
            else if (comboxperiod.SelectedIndex == 3)
            {
                rate = 0.24;
                month = 24;
            }
            else
            {
                MessageBox.Show("select the period ");
            }
            total = amount * rate +amount;

            per_month = total / month;

            aset = salary * 0.4;

            if (aset>=per_month)
            {
                MessageBox.Show("you are allowed to take Murabaha loan ");
            }
            else
            {
                MessageBox.Show("sorry you are not allowed to take Murabaha loan");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text !=""|| txtamount.Text !="" ||txtsalary.Text.Trim()!="")
            {
                lbldetails.Visible = true;
                

                if (aset >= per_month)
                {
                    lbldetails.Text = (" you asked us to lend you " + amount + " $ \nand you agreed to pay it back within\n" + month + " months and your salary is " + salary + " \nand 40% of your salary "+aset+" $ is more then\n the monthly pay back amount " + per_month +" $ \nso you are allowed ");
                }
                else
                {
                    lbldetails.Text = (" you asked us to lend you " + amount + " $\nand you agreed to pay it back within " + month + " months and your salary is " + salary + "\n and 40% of your salary " + aset + " $ is less then\n the monthly pay back amount " + per_month +" $ \nso ou are not allowed");
                }
            }
            else
            {
                MessageBox.Show("please fill the form 1st");
            }
        }
    }
}
