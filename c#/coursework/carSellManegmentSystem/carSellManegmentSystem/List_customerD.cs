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

namespace carSellManegmentSystem
{
    public partial class List_customerD : Form
    {
        public List_customerD()
        {
            InitializeComponent();
            // Menu ga markaa click lagu soo siiyay 
            //method ka show() ayan isticmalay
            //form kan code kiisa ne  waxan ka wacay class ka NewcustomerClass 
            //object giisana parameter waxa uga dhigay  text box ka
            NewCustomerClass list = new NewCustomerClass();

            list.list_Customer(txtshowlistcustomer.Text);

       txtshowlistcustomer.Text = list.listcustomerinfo;

        }
    }
}
