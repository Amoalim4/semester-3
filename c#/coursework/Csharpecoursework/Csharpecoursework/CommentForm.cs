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
    public partial class CommentForm : Form
    {
        public CommentForm()
        {
            InitializeComponent();
            
        }
        //public  { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcomment.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtcomment.Text == "" || txtcomment.Text == " ")
            {

                MessageBox.Show("Please add some comments");
                
            }
            else
            {
              
            }
        }
    }
}
