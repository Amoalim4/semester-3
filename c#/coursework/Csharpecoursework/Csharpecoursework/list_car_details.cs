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
    public partial class list_car_details : Form
    {
        public list_car_details()
        {
            InitializeComponent();
            CarClass cars = new CarClass();
            cars.list();
            ricshowcarDetails.Text = cars.read_car;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CarClass cars = new CarClass();
            cars.updatecar(ricshowcarDetails.Text);
            MessageBox.Show("successfully Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ricshowcarDetails.SelectedText = "";
            CarClass cars = new CarClass();
            cars.updatecar(ricshowcarDetails.Text);
            MessageBox.Show("Successfully Deleted");
        }
    }
}
