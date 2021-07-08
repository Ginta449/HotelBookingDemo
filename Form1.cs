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

//this application was developed by Mark, Ginta and Ben. This project was very much group effort and every each one of us 
//worked together on all the parts of this application
namespace HotelBMG2
{
    
    public partial class Form1 : Form
    {
       // private Rooms booking;
        HotelAdminNotifications bookings = new HotelAdminNotifications();
        
        public Form1()
        {
            InitializeComponent();
            //booking = new Rooms();

            bookings.Hide();
           // booking.RegisterObserver(bookings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();//brings the user to room builder form which uses decorator pattern
            roomBuilder.Show();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdminPromoDeals promo2 = new AdminPromoDeals();//running in the background are admin promo deal notification form 
            promo2.Show();                                 //which uses observer pattern to send promo deals or hotel update deals to the saved user emails in array
            lblPromoDeal.Visible = false; 
        }

        private void btnDeuxe_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();
            roomBuilder.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();
            roomBuilder.Show();
            this.Hide();

           // Customer cust = new Customer("Test"," Test","Test","Test","Test");//we did add a customer class and initially was used for the second observer pattern
            //booking.LoadForm(cust);                                           //to notify hotel admin of customer booking

        }

        private void btnDisplayDeals_Click(object sender, EventArgs e)
        {
            string promo = AdminPromoDeals.promodeal;//pulls the information out from admin from textbox and displays it in the main start up form
            lblPromoDeal.Text = promo; //one of the challenges we experienced when testing was how to pull information out from one form into another
            lblPromoDeal.Visible = true;
        }
    }
}
