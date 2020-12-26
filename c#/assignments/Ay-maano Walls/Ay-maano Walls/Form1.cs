using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_maano_Walls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmregistration customer_registration;

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblaymaano.Visible = false;
            if (customer_registration== null)
            {
                customer_registration = new frmregistration();
                customer_registration.MdiParent = this;
                customer_registration.Show();
            }
            customer_registration.Activate();

            customer_registration.FormClosed += customer_registration_FormClosed;
        }

        void customer_registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            customer_registration = null;
        }
        frminvoces invoce;
        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name="";
            String phone="";
            String address="";
            String membership ="";
            if (invoce==null)
            {
                invoce = new frminvoces(name,phone,address, membership);
                invoce.MdiParent = this;
                invoce.Show();
            }
            invoce.Activate();
            invoce.FormClosed += invoce_FormClosed;
            

        }

        void invoce_FormClosed(object sender, FormClosedEventArgs e)
        {
            invoce = null;
        }
    }
}
