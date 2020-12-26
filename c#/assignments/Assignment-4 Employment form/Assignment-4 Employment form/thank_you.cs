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
    public partial class thank_you : Form
    {
        public thank_you( String name, String tell , String addresss)
        {
            InitializeComponent();
            lblshowname.Text = name;
            lblshowtell.Text = tell;
            lblshowaddress.Text = addresss;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            Form1 go_back = new Form1();
            go_back.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumary infomation = new sumary();
            infomation.Show();
            
        }

        private void thank_you_Load(object sender, EventArgs e)
        {
            
        }

        private void lblshowaddress_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            test test1 = new test(lblshowname.Text);
            test1.Show();
        }
    }
}
