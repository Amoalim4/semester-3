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
    public partial class AddNewOwnerForm : Form
    {
        public AddNewOwnerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OwnersClass Ownerclass = new OwnersClass();
            string name = txtname.Text;
            string tell = txtTell.Text;
            string AccNo = txtAccNo.Text;
            string gender = "";
            int age =int.Parse( txtage.Text);
            int shere = int.Parse(txtshare.Text);
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("select you gender");
            }

            if (name == "" || tell ==""||txtage.Text == ""||txtshare.Text == "" ||AccNo == "")
            {
                MessageBox.Show("Please Fill the form first ");
            }
            else
            {
                if (Ownerclass.list().Contains(name) && Ownerclass.list().Contains(AccNo) && Ownerclass.list().Contains(tell) )
                {
                    MessageBox.Show("This Information is Already in the file");
                }
                else
                {
                    if (Ownerclass.list().Contains(AccNo))
                    {
                        MessageBox.Show("This Account Number is registred For another person");
                    }
                    else
                    {
                        Ownerclass.regesterOwner(name, gender, tell, age, shere, AccNo);
                        MessageBox.Show("Successfully Added");
                    }
                }
            }

        }
    }
}
