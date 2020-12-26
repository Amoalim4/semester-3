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
    public partial class Add_New_car_form : Form
    {


        // object for the car class
        CarClass class_of_cars = new CarClass();


        public Add_New_car_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_car_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // the object diclered above to the method of Add_new_car() 
            //to add the new car info
            if (class_of_cars.list().Contains(txtcarname.Text) && class_of_cars.list().Contains(txtcarmodel.Text)) 
            {
                MessageBox.Show("Sorry this car is allready in the list");
            }
            else
            {
                class_of_cars.regester(txtcarname.Text, txtcarmodel.Text, txtcarcolor.Text, txtspeed.Text);
                MessageBox.Show("The new car is successfully Added");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
