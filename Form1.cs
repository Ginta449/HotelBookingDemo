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
    
    public partial class Form1 : Form
    {
     
        HotelAdminNotifications bookings = new HotelAdminNotifications();
        
        public Form1()
        {
            InitializeComponent();
            

            bookings.Hide();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();
            roomBuilder.Show();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdminPromoDeals promo2 = new AdminPromoDeals();
            promo2.Show();                                 
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

          
        }

        private void btnDisplayDeals_Click(object sender, EventArgs e)
        {
            string promo = AdminPromoDeals.promodeal;
            lblPromoDeal.Text = promo; 
            lblPromoDeal.Visible = true;
        }
    }
}
