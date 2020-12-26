using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertionBinaryDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            calculate cl = new calculate();
            int input = 0;
            try
            {
                input = int.Parse(txtinput.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("use only numbers");
            }

            if (radioDecimal.Checked)
            {
                
                if (txtinput.TextLength==8)
                {
                     
                    if (char.IsDigit(txtinput.Text[0]))
                    {

                        //int value;
                        //int.TryParse(txtinput.Text, out value);

                        //if (value == 0 || value == 1)
                        //{
                            cl.toDecimal(input);
                            lblshow.Visible = true;
                            lblshow.Text = cl.toDecimal(input);
                        //}
                        //else
                        //{
                        //    MessageBox.Show(value.ToString());
                        //}
                        
                    }

                    
                }
                else
                {
                    MessageBox.Show("Binary number can be only 8 digits and use only 0s and 1s");
                }
            }

            ///////////////////////////////////////////////////////////

            if (radioBinary.Checked)
            {
                cl.toBinary(input);
                lblshow.Visible = true;
                lblshow.Text = cl.toBinary(input);
            }

        }

        private void radioDecimal_CheckedChanged(object sender, EventArgs e)
        {
            lblnote.Text = "use only 0s and 1s";
            lblnote.Visible = true;
        }

        private void radioBinary_CheckedChanged(object sender, EventArgs e)
        {
            lblnote.Text = "use normal numbers";
            lblnote.Visible = true;
        
        }
    }
}
