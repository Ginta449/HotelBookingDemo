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
    public partial class AdminPromoDeals : Form
    {
        public static string promodeal = ""; 

        public AdminPromoDeals()
        {
            InitializeComponent();
            
        }


        internal Observer Observer { get; private set; }

        private void buttonPromoDeals_Click(object sender, EventArgs e)
        {
            SendPromo();
        }

        public void SendPromo()//create amethod which can be called into button click
        {
            Subject promocode = new Subject(" ", DateTime.Now);
            Observer user = new Observer("youremail@email.com", promocode);//because button click is private we needed to add public method
            //and call it in private button click to retrieve the information from observer

            promodeal = richTextBoxPromoDeals.Text;
            user.update(promodeal);//as the promo deal gets added update methid gets called from observer class which then sends emails to users saved in array of any updates

        }

        private void AdminPromoDeals_Load(object sender, EventArgs e)
        {

        }
    }
}
