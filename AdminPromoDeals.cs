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

        public void SendPromo()
        {
            Subject promocode = new Subject(" ", DateTime.Now);
            Observer user = new Observer("youremail@email.com", promocode);
            

            promodeal = richTextBoxPromoDeals.Text;
            user.update(promodeal);

        }

        private void AdminPromoDeals_Load(object sender, EventArgs e)
        {

        }
    }
}
