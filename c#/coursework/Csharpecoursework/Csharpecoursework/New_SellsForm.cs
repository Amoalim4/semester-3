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
    public partial class New_SellsForm : Form
    {
        public New_SellsForm()
        {
            InitializeComponent();
            //stuffClass stf = new stuffClass();
            //comboxstaffnames.Text = stf.staffNames().ToString();
        }

        private void New_SellsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellsClass sell_It = new SellsClass();

            CarClass All_cars = new CarClass();

            string CustomerName = txtCustomerName.Text;
            string customerTell = txtTell.Text;
            string customerAdress = txtAddress.Text;
            string CarName = txtcarName.Text;
            string CarModel = txtmodel.Text;
            string color = comBoColor.Text;
            string seller = comboxstaffnames.Text;
            
            string date = DatePicker.Value.ToString();

            if (CustomerName == "" || CustomerName == " " || customerAdress == "" || customerAdress == " " || customerTell == "" || customerTell == " ")
            {
                MessageBox.Show("Please fill personal details");
            }
            else
            {
                if (CarName == "" || CarName == " " || CarModel == ""||CarModel==" " || txtPrice.Text == " " || txtPrice.Text == "")
                {
                    MessageBox.Show("Please fill the car details");
                }
                else
                {
                    int CarPrice = int.Parse(txtPrice.Text);
                    if (All_cars.list().Contains(CarName) && All_cars.list().Contains(CarModel)) 
                    {
                        sell_It.register_Newsells(CustomerName, customerTell, customerAdress, CarName, CarModel,color,seller, CarPrice, date);
                        MessageBox.Show("Successfully sold");
                    }
                    else
                    {
                        MessageBox.Show("Sorry we don't have this car ");
                        MessageBox.Show("please check the cars list to see the cars we have"); 
                    }

                }
            }



        }
    }
}
