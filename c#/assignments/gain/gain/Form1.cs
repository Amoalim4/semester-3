using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclik_Click(object sender, EventArgs e)
        {
            lblname.Text = "name  " + txtname.Text;
            lblname.Text = "adres  " + lblselectsate.Text;
            lbladres.Text = "" + txtohone.Text;
            int new_year = 2020;
            int year = Convert.ToInt16(txtyear.Text);
            int age = new_year - year;
            lblage.Text = "age" + age.ToString();
            int salary = Convert.ToInt16(txtsalary.Text);
            int peryear = 12 * salary;
            lblsalery.Text = "$" + peryear.ToString();
            lblselectyy.Text = cmbstate.Text;

            
            
            
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
        }

      
    }
}
