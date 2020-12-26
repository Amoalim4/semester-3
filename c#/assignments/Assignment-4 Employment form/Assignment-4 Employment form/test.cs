using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_Employment_form
{
    public partial class test : Form
    {
        public test( String name)
        {
            InitializeComponent();
            lbl.Text = name;
        }
    }
}
