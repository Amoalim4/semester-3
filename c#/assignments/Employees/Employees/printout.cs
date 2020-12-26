using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class printout : Form
    {
        public printout()
        {
            InitializeComponent();
        }
            

        private void printout_Load(object sender, EventArgs e)
        {
           Form1 tandt = new Form1();
            
           String name= "";
           String tell = "";
           String address="";
           string damiin ="";
            employee pinfo = new employee();
            pinfo.info(name,tell,address,damiin );
            lblname.Text = name;
            lbltell.Text = tell;
            lbladdress.Text = address;
            lbldamiin.Text = damiin;
        }
    }
}
