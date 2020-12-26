using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    struct mainstruct
    {
        public String name;

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        employee einfo = new employee();
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
             

        }


        private void button1_Click(object sender, EventArgs e)
        {
           

            int age = int.Parse(cboxyear.Text);
            einfo.age(age);
            einfo.info(txtname.Text,txttell.Text,txtaddress.Text,txtdamiin.Text);
            printout print_info = new printout();
            print_info.Show();

        }
    }
}
