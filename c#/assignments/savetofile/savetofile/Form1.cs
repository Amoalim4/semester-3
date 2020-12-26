using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savetofile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string tell = txttell.Text;
            string adderss = txtaddress.Text;
            int age = int.Parse(txtage.Text);
            student st = new student();
            st.save(txtname.Text, tell, adderss, age);
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            student st = new student();
            
            st.read();

            lblshowname.Text = st.names;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
