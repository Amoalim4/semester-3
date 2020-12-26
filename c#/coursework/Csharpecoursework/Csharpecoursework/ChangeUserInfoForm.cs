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
    public partial class ChangeUserInfoForm : Form
    {
        public ChangeUserInfoForm()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            string path_user = @"E:\semester two\c#\coursework\date\user.txt";

            string path_passwd = @"E:\semester two\c#\coursework\date\passwd.txt";

            string OlduserName = txtolduser.Text.Trim();
            string Oldpassword = txtoldpasswd.Text.Trim();

            string NewuserName = txtnewuser.Text.Trim();
            string Newpassword = txtnewpasswd.Text.Trim();

           
            string conform_password = txtconform.Text.Trim();

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
            if (user.Trim() == OlduserName && pass.Trim() == Oldpassword)
            {
                if (NewuserName != OlduserName && Newpassword != Oldpassword)
                {
                    if (conform_password == Newpassword )
                    {
                        using (StreamWriter swnewuser = new StreamWriter(path_user))
                        {
                            swnewuser.Write(NewuserName);
                        }
                        using (StreamWriter swnewpass = new StreamWriter(path_passwd))
                        {
                            swnewpass.Write(conform_password);
                        }
                        MessageBox.Show("Succssefully Changed the log in information");
                        MessageBox.Show("Please log in again");
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Confotm the new password");
                    }
                }
                else
                {
                    MessageBox.Show("Noting to change");

                }
            }
            else
            {
                MessageBox.Show("Access denied");
                MessageBox.Show("try again");
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }
    }
}
