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
    public partial class ListStaff : Form
    {
        public ListStaff()
        {
            InitializeComponent();
            stuffClass liststaff = new stuffClass();
            liststaff.list();
            richboxshowinfo.Text = liststaff.list();
        }

        private void ListStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            stuffClass staff = new stuffClass();
            staff.staffUpdate(richboxshowinfo.Text);
            MessageBox.Show("successfully Updated");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            richboxshowinfo.SelectedText = "";
            stuffClass staff = new stuffClass();
            staff.staffUpdate(richboxshowinfo.Text);
            MessageBox.Show("Deleted");

        }
    }
}
