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
    public partial class List_Test_Bookings : Form
    {
        public List_Test_Bookings()
        {
            InitializeComponent();
            Test_BookingClass Bookig_test = new Test_BookingClass();
            Bookig_test.list();
            richshowdetais.Text = Bookig_test.information;

        }
    }
}
