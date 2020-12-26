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

namespace car_Sell
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string path_user = @"E:\semester two\c#\coursework\date\user.txt";
            string path_passwd = @"E:\semester two\c#\coursework\date\passwd.txt";
            string user = "";
            string Pass = "";
            using (StreamReader srU = new StreamReader(path_user))
            {
                
               user= srU.ReadLine();
                
            }
            using (StreamReader srp = new StreamReader(path_passwd))
            {

               Pass = srp.ReadLine();

            }



            if (user == txtuser.Text && txtpasswd.Text == Pass)
            {
                mainpage main = new mainpage();
                main.Show();
            }
            
            
        }
    }
}
