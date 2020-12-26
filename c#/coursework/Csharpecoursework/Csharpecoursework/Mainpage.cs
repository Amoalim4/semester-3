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
    public partial class Mainpage : Form
    {
        
        ////////////////////////////////////////
        //                             objects
        //         //      Cars     /////
        Add_New_car_form add_car;

        show_recentiesForm showRecenties;

        list_car_details show_cars_detail;

        //                   Customer            ///////
        Add_new_customer Add_new;
        List_customer list_of_customers;

        //                          Test booking            ////
        List_Test_Bookings List_Booking;

        Test_bookingForm Test_booking;

        //                              Return Car                   ///
        returnCarForm Returned;
        // //                        /sells

        New_SellsForm sell_it;

        List_SellsForm ListSells;

        //                                // Staff                  /// ///      // // 
        New_StaffForm staff;
        ListStaff liststaffForm;

        //                            //      OWNER S
        AddNewOwnerForm AddOwner;
        ListOwnersForm list_owner;
        /// ///////////////////////////////////////
        /// 

        //stoping of many forms to be open at the same timee
        //add_car.close();
        //showRecenties.close();
        //show_cars_detail.close();
        //Add_new.close();
        //list_of_customers.close();
        //Test_booking.close();
        //Returned.close();
        //sell_it.close();
        //ListSells.close();
        //staff.close();
        //AddOwner.close();
        //list_owner.close();
        //liststaffForm.close();


        public Mainpage()
        {
            InitializeComponent();
            
        }
        //Form1 the_form;
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
            //if (add_car != null)
            //{
            //    add_car.Close();
            //}
            //if (showRecenties != null)
            //{
            //    showRecenties.Close();
            //}
            //if (show_cars_detail != null)
            //{
            //    show_cars_detail.Close();
            //}
            //if (Add_new != null)
            //{
            //    Add_new.Close();
            //}
            //if (list_of_customers != null)
            //{
            //    list_of_customers.Close();
            //}
            //if (Test_booking!=null)
            //{
            //    Test_booking.Close();
            //}
            //if (Returned!=null)
            //{
            //    Returned.Close();
            //}
            //if (List_Booking != null)
            //{
            //    List_Booking.Close();
            //}
            //if (sell_it!= null)
            //{
            //    sell_it.Close();
            //}
            //if (ListSells != null)
            //{
            //    ListSells.Close();
            //}

            //if (staff!= null)
            //{
            //    staff.Close();
            //}
            //if (AddOwner != null)
            //{
            //    AddOwner.Close();
            //}
            //if (list_owner!= null)
            //{
            //    list_owner.Close();
            //}
            //if (liststaffForm != null)
            //{
            //    liststaffForm.Close();
            //}
            //if (the_form== null)
            //{
            //    the_form = new Form1();
            //    the_form.MdiParent = this;
            //    the_form.Show();
            //}
            //the_form.Activate();
            //the_form.FormClosed += the_form_FormClosed;
        //}

        //void the_form_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    the_form = null;
        }

        /// <summary>
        ///             adding the new customer
        /// the code below is  creating an object to call Add_new_customer
        /// 
        /// 
        /// </summary>
        
        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (Add_new == null)
            {
                Add_new = new Add_new_customer();
                Add_new.MdiParent = this;
                Add_new.Show();
            }
            Add_new.Activate();
            Add_new.FormClosed += Add_new_FormClosed;
        }

        void Add_new_FormClosed(object sender, FormClosedEventArgs e)
        {
            Add_new = null;
        }


        /// <summary>
        /// the code below is creating an object to call the List_customer Form
        /// this will happen when the listCustomersToolStripMenuItem is clicked from thisform
        /// </summary>
        
        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (list_of_customers == null)
            {
                list_of_customers = new List_customer();
                list_of_customers.MdiParent = this;
                list_of_customers.Show();
            }
            list_of_customers.Activate();
            list_of_customers.FormClosed += list_of_customers_FormClosed;
        }

        void list_of_customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            list_of_customers = null;
        }
        /// <summary>
        /// this is the the customer Updeta button and function
        /// </summary>
        
        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" the Customer is updated");
        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (add_car == null)
            {
                add_car = new Add_New_car_form();
                add_car.MdiParent = this;
                add_car.Show();
            }
            add_car.Activate();
            add_car.FormClosed += add_car_FormClosed;

        }

        void add_car_FormClosed(object sender, FormClosedEventArgs e)
        {
            add_car = null;
        }

        private void recentlyCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }

            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (showRecenties == null)
            {
                showRecenties = new show_recentiesForm();
                showRecenties.MdiParent = this;
                showRecenties.Show();
            }
            showRecenties.Activate();

            showRecenties.FormClosed += showRecenties_FormClosed;

        }

        void showRecenties_FormClosed(object sender, FormClosedEventArgs e)
        {
            showRecenties = null;
        }

        private void carListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (show_cars_detail == null)
            {
                show_cars_detail = new list_car_details();
                show_cars_detail.MdiParent = this;
                show_cars_detail.Show();
            }
            show_cars_detail.Activate();
            show_cars_detail.FormClosed += show_cars_detail_FormClosed;
        }

        void show_cars_detail_FormClosed(object sender, FormClosedEventArgs e)
        {
            show_cars_detail = null;
        }

        private void makeNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (Test_booking == null)
            {
                Test_booking = new Test_bookingForm();
                Test_booking.MdiParent = this;
                Test_booking.Show();

            }
            Test_booking.Activate();

            Test_booking.FormClosed += Test_booking_FormClosed;
        }

        void Test_booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Test_booking = null;
        }

        private void listTestBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }

            if (List_Booking == null)
            {
                List_Booking = new List_Test_Bookings();
                List_Booking.MdiParent = this;
                List_Booking.Show();
            }
            List_Booking.Activate();
            List_Booking.FormClosed += List_Booking_FormClosed;
        }

        void List_Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            List_Booking = null;
        }

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (Returned == null)
            {
                Returned = new returnCarForm();
                Returned.MdiParent = this;
                Returned.Show();
            }
            Returned.Activate();
            Returned.FormClosed += Returned_FormClosed;
        }

        void Returned_FormClosed(object sender, FormClosedEventArgs e)
        {
            Returned = null;
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sellesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (ListSells == null)
            {
                ListSells = new List_SellsForm();
                ListSells.MdiParent = this;
                ListSells.Show();
            }
            ListSells.Activate();
            ListSells.FormClosed += ListSells_FormClosed;
        }

        void ListSells_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListSells = null;
        }

        private void newSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (add_car != null)
            {
                add_car.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (sell_it == null)
            {
                sell_it = new New_SellsForm();
                sell_it.MdiParent = this;
                sell_it.Show();
            }
            sell_it.Activate();
            sell_it.FormClosed += sell_it_FormClosed;
        }

        void sell_it_FormClosed(object sender, FormClosedEventArgs e)
        {
            sell_it = null;
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (add_car != null)
            {
                add_car.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (staff == null)
            {
                staff = new New_StaffForm();
                staff.MdiParent = this;
                staff.Show();
            }
            staff.Activate();
            staff.FormClosed += staff_FormClosed;
        }

        void staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            staff = null;
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            if (list_owner != null)
            {
                list_owner.Close();
            }
           
            if (liststaffForm == null)
            {
                liststaffForm = new ListStaff();
                liststaffForm.MdiParent = this;
                liststaffForm.Show();
            }
            liststaffForm.Activate();
            liststaffForm.FormClosed += liststaffForm_FormClosed;
        }

        void liststaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            liststaffForm = null;
        }

        private void newOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
           
            if (list_owner != null)
            {
                list_owner.Close();
            }
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (AddOwner == null)
            {
                AddOwner = new AddNewOwnerForm();
                AddOwner.MdiParent = this;
                AddOwner.Show();
            }
            AddOwner.Activate();
            AddOwner.FormClosed += AddOwner_FormClosed;
        }

        void AddOwner_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddOwner = null;
        }

        private void ownerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add_car != null)
            {
                add_car.Close();
            }
            if (List_Booking != null)
            {
                List_Booking.Close();
            }
            if (showRecenties != null)
            {
                showRecenties.Close();
            }
            if (show_cars_detail != null)
            {
                show_cars_detail.Close();
            }
            if (Add_new != null)
            {
                Add_new.Close();
            }
            if (list_of_customers != null)
            {
                list_of_customers.Close();
            }
            if (Test_booking != null)
            {
                Test_booking.Close();
            }
            if (Returned != null)
            {
                Returned.Close();
            }
            if (sell_it != null)
            {
                sell_it.Close();
            }
            if (ListSells != null)
            {
                ListSells.Close();
            }

            if (staff != null)
            {
                staff.Close();
            }
            if (AddOwner != null)
            {
                AddOwner.Close();
            }
            
            if (liststaffForm != null)
            {
                liststaffForm.Close();
            }
            if (list_owner == null)
            {
                list_owner = new ListOwnersForm();
                list_owner.MdiParent = this;
                list_owner.Show();
            }
            list_owner.Activate();
            list_owner.FormClosed += list_owner_FormClosed;
        }

        void list_owner_FormClosed(object sender, FormClosedEventArgs e)
        {
            list_owner = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateOrDeleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Click List customer to update or remove  customer");
        }

        private void updateOrDeleteStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Click List staff to update or remove Staff Member");
        }

        private void updateOrDeleteOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Click List Owner to update or remove  Owner");
        }

        private void updateOrDeleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Click List list cars to update or remove a car");
        }
        
    }

}
