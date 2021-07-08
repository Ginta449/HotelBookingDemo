using HotelBMG2.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBMG2
{
    public partial class HotelAdminNotifications : Form
    {
        
        //private readonly Customer _customer;
        public HotelAdminNotifications()
        {
           
            InitializeComponent();
            
            //_customer = customer;
           
        }

        public void UpdateBooking(int count)
        {
            string name = CustomerDetails.name;
            string surname = CustomerDetails.surname;
            string email = CustomerDetails.email;
            string address = CustomerDetails.address;
            string phone = CustomerDetails.phone;


            dataGridView1.Rows.Add("customer:" + count.ToString(), name, surname,address, email, phone); ;
              
            //lstCustomerBookings.Items.Add("Customer:" + count.ToString() + " " + name + " " + surname + " " + email + " " + address + " " + phone);
        }

        public void Update(int count)
        {
            UpdateBooking(count);
        }

        private void HotelAdminNotifications_Load(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void lstCustomerBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
