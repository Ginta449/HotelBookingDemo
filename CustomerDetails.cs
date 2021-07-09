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
        int counter = 0;
        public static string name = "";
        public static string surname = "";
        public static string address = "";
        public static string email = "";
        public static string phone = "";
       // private Rooms booking;

        HotelAdminNotifications bookings = new HotelAdminNotifications();

        Regex validation = new Regex("[a-zA-Z0-9]");
        public CustomerDetails()
        {
            InitializeComponent();
         
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            string totalPrice = RoomBuilder.total;
            lblDisplayTotal.Text = totalPrice.ToString();
            txtNoOfNights.Text = "1";          

        }

       
        public void SendEmail(string email)
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
            {
               
                Customer cust = new Customer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPhone.Text);
                SendEmail(txtEmail.Text);
                

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
            counter++;
            txtNoOfNights.Text = counter.ToString();
     
            string totalPrice = RoomBuilder.total;
            lblDisplayTotal.Text = (Double.Parse(totalPrice) * counter).ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            counter--;
            string totalPrice = RoomBuilder.total;

            if (counter == -1)
            {
                counter = 0;
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
