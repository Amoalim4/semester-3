using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharpecoursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblslogen.Text = "Unlike any other";
        }
        Mainpage main;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //CustomerClass Class_of_customers = new CustomerClass();
            //Class_of_customers.Log_in_checking(txtusername.Text, txtpassword.Text);

            string path_user = @"E:\semester two\c#\coursework\date\user.txt";

            string path_passwd = @"E:\semester two\c#\coursework\date\passwd.txt";

            string userName = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            string user = "";
            using (StreamReader streamUser = new StreamReader(path_user))
            {
                user = streamUser.ReadLine();
            }
            string pass = "";
            using (StreamReader streampassword = new StreamReader(path_passwd))
            {
                pass = streampassword.ReadLine();
            }
            if (userName == user && password == pass)
            {
                if (main== null)
                {
                    main = new Mainpage();
                    main.Show();
                }
                main.Activate();
                main.FormClosed += main_FormClosed;
                
            }
            else
            {
                MessageBox.Show("Invalid Username or password");
            }
            
             

        }

        void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            main = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeUserInfoForm changeInfo = new ChangeUserInfoForm();
            changeInfo.Show();
            this.Hide();
        }
    }
}
