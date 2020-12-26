using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path = @"C:\Users\A.Moallim\Pictures\saved\";
            if (cmbstate_list.Text == "Jubaland")
            {
                lblcapital.Text = " Bu'aale";
                lblname.Text = "Ahmed Islaam Madoobe";
                picflag.ImageLocation = path + "jubaland.PNG";
                pichead.ImageLocation = path + "madoobe.JPG";
            }
            else if (cmbstate_list.Text == "Galmudug")
            {
                lblcapital.Text = " Ku : Cadaado";
                lblname.Text = "Ahmed abdi kaariye (Qoor qoor)";
                picflag.ImageLocation = path + "galmudug.PNG";
                pichead.ImageLocation = path + "qoor qoor.JPG";
                


            }
            else if (cmbstate_list.Text == "Goonfur-galbeed")
            {
                lblcapital.Text = "Baraawe";
                lblname.Text = "Abdi aziz mohamed xasan";
                picflag.ImageLocation = path + "koonfurgalbeed.PNG";
                pichead.ImageLocation = path + "lafta gareen.JPG";
            }
            else if (cmbstate_list.Text == "Puntland")
            {
                lblcapital.Text = " Garoowe";
                lblname.Text = "saciid Abdullahi dani";
                picflag.ImageLocation = path + "puntland.JPG";
                pichead.ImageLocation = path + "dani.JPG";
                
                

            }
            else if (cmbstate_list.Text == "Somali-land")
            {
                lblcapital.Text = "Hargeysa";
                lblname.Text = "Muuse biixi abdi";
                picflag.ImageLocation = path + "somaliland.JPG";
                pichead.ImageLocation = path + "biixi.JPG";
                

            }
            else if (cmbstate_list.Text == "Banaadir")
            {
                lblcapital.Text = "Xamar-weyn";
                lblname.Text = "Cumar muhalig ";
                picflag.ImageLocation = path + "banadir.JPG";
                pichead.ImageLocation = path + "finish.JPG";
               

            }
            else if (cmbstate_list.Text == "Hirshabeele")
            {
                lblcapital.Text = " Jowhar";
                lblname.Text = "Maxamed Abdi waare";
                picflag.ImageLocation = path + "Hirshabeelle.PNG";
                pichead.ImageLocation = path + "waare.JPG";
               

            }
            else
            {
                picflag.ImageLocation = path + "image.jpg";
                pichead.ImageLocation = path + "image.JPG";
                lblcapital.Text = "Unknown";
                lblname.Text = "Unkhown";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
