using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_window_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        xissab math = new xissab();
        double result = 0;


        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (txtsecondnumber.Text == "" && txtfirstnumber.Text == "")
            {
                MessageBox.Show("Nagu kala wad");
            }
            else
            {


                Double n1 = double.Parse(txtfirstnumber.Text);
                Double n2 = double.Parse(txtsecondnumber.Text);

                if (rbtnadd.Checked)
                {

                    result = math.add(n1, n2);
                    lblresult.Text = result.ToString();
                }
                if (rbtnsub.Checked)
                {
                    result = math.sub(n1, n2);
                    lblresult.Text = result.ToString();
                }
                if (rbtnmult.Checked)
                {
                    result = math.mult(n1, n2);
                    lblresult.Text = result.ToString();
                }
                if (rbtndivide.Checked)
                {
                    result = math.divide(n1, n2);
                    lblresult.Text = result.ToString();
                }

            }
            //End of the else function 

        }

        private void txtfirstnumber_TextChanged(object sender, EventArgs e)
        {

        }
        //end of the bottom
    }
}
