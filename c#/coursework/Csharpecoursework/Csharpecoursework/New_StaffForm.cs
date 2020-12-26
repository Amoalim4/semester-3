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
    public partial class New_StaffForm : Form
    {
        public New_StaffForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            stuffClass staffs = new stuffClass();
            string name = txtStaffName.Text;
            string tell = txtStaffTell.Text;
            int salary = 0;
            int age = 0;
            try
            {
                 salary = int.Parse(txtStaffSalary.Text);
                 age = int.Parse(txtStaffAge.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Use only numbers in age and salary");
            }
           
            string gender = "";
            
            
            if (radioMle.Checked)
            {
                gender = "Male";
            }

            else if (radioFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Select gender");
            }

            if (txtStaffName.Text == "" || txtStaffAge.Text == ""|| txtStaffSalary.Text=="" || txtStaffTell.Text == "")
            {
                MessageBox.Show("Please fill All the ");
            }
            else
            {
                if (staffs.list().Contains(txtStaffName.Text) && staffs.list().Contains(txtStaffTell.Text) )
                {
                    MessageBox.Show("This employee was already working here");
                }
                else
                {
                    if (age >= 17)
                    {
                        staffs.regester(name, gender, tell, salary, age);
                        MessageBox.Show("Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("You under the legal age ");
                    }
                }
            }

        }
    }
}
