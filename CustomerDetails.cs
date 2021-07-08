using HotelBMG2.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBMG2
{
    public partial class CustomerDetails : Form 
    {
        int counter = 0;//counter declared to calculate number of nights added by user
        public static string name = "";
        public static string surname = "";
        public static string address = "";
        public static string email = "";
        public static string phone = "";
       // private Rooms booking;

        HotelAdminNotifications bookings = new HotelAdminNotifications();

        Regex validation = new Regex("[a-zA-Z0-9]");//adding basic regular expression that accepts all letters and all numbers to avoid user from crashing the application
        public CustomerDetails()
        {
            InitializeComponent();
           // booking = new Rooms();
           
            //booking.RegisterObserver(bookings);
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            string totalPrice = RoomBuilder.total;//getting the price from label using the public static string in room builder form
            lblDisplayTotal.Text = totalPrice.ToString();
            txtNoOfNights.Text = "1";          

        }

       
        public void SendEmail(string email)//this method sends email to user to notify the user that the booking has been made
        {
            email = txtEmail.Text;

            try
            {
                var senderEmail = new MailAddress("youremail@email.com", "HotelDemo");
                var receiverEmail = new MailAddress(email);
                var password = "yourpassword";
                var smtp = new SmtpClient
                {
                    Host = "smtp.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = "Booking Confirmation",
                    Body = "Hello " + email + "Booking Deatils:  Name: " + txtFirstName.Text.ToUpper() + " " + txtLastName.Text.ToUpper() + " " + "Number of nights: " + txtNoOfNights.Text + " " + "Booking Date: " + DateTime.Now.ToString()
                })


                {
                    smtp.Send(mess);
                }
            }
            catch
            {

            }
        }
        private void btnReserve_Click(object sender, EventArgs e)
        {
            
            name = txtFirstName.Text;
            surname = txtLastName.Text;
            address = txtAddress.Text;
            email = txtEmail.Text;
            phone = txtPhone.Text;

            if (validation.IsMatch(name) && validation.IsMatch(surname) && validation.IsMatch(address) && validation.IsMatch(email) && validation.IsMatch(phone))
            {//calling regex object is match method to validate the form
               
                Customer cust = new Customer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPhone.Text);
                SendEmail(txtEmail.Text);
                // booking.LoadForm(cust);
                //bookings.Show(); 

                MessageBox.Show("Your order has been received, please see your email for order details!");

            }
            else
            {
                MessageBox.Show("Please fill out all fields to make a reservation!");
            }

            txtAddress.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtNoOfNights.Clear();

            
            
           
        }

       
        private void btnAddNights_Click(object sender, EventArgs e)
        {
            counter++;//adds days
            txtNoOfNights.Text = counter.ToString();
            //at the beginning we used the lblDisplayTotal to get the price and multiply by counter however if the price hit 0 or any other changes were made
            //the values were not correct
            string totalPrice = RoomBuilder.total;//therefore we retrieved the original value from room builder form
            lblDisplayTotal.Text = (Double.Parse(totalPrice) * counter).ToString();//and multiplied it by counter(nights) to ensure values were correct
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            counter--;//removes days
            string totalPrice = RoomBuilder.total;

            if (counter == -1)//after testing we realized that the counter went into minuses
            {
                counter = 0;//therefore we told the program to reset counter to 0 if counter reached -1
                lblDisplayTotal.Text = totalPrice.ToString();
            }

            txtNoOfNights.Text = counter.ToString();

            lblDisplayTotal.Text = ((Double.Parse(lblDisplayTotal.Text) - (Double.Parse(totalPrice))).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomBuilder roombuild = new RoomBuilder();
            this.Hide();
            roombuild.Show();

        }
    }
}
