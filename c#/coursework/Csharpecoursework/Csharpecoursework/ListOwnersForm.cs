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
    public partial class ListOwnersForm : Form
    {
        public ListOwnersForm()
        {
            InitializeComponent();
            OwnersClass Class_of_Owenr = new OwnersClass();
            Class_of_Owenr.list();
            richboxShow.Text = Class_of_Owenr.list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnersClass owner = new OwnersClass();
            owner.OwnerUpdate(richboxShow.Text);
            MessageBox.Show("successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richboxShow.SelectedText = "";
            OwnersClass owner = new OwnersClass();
            owner.OwnerUpdate(richboxShow.Text);
            MessageBox.Show("successfully Deleted");
        }
    }
}
