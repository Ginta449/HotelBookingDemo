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
using HotelBMG2.Subjects.Decorator;

namespace HotelBMG2
{
    public partial class RoomBuilder : Form
    {
        public static string total = "";

        public RoomBuilder()
        {
            InitializeComponent(); 
        }

        IRoom _room = new StandardRoom();

        private void radioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBreakfast.Checked = false;
            checkBoxDinner.Checked = false;
            
            _room = new StandardRoom();
            DisplayPrice();
            checkBoxBreakfast.Enabled = true;
            checkBoxDinner.Enabled = true;
        }

        private void radioButtonDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            _room = new DeluxeRoom(_room);
            DisplayPrice();
            checkBoxBreakfast.Enabled = false;
            checkBoxDinner.Enabled = false;
        }

        private void checkBoxBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBreakfast.Checked)
            {
                _room = new AddBreakfast(_room);
                DisplayPrice();
            }
            else if (checkBoxBreakfast.Checked == false)
            {
                _room = new RemoveBreakfast(_room);
                DisplayPrice();
            }
        }

        private void checkBoxDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDinner.Checked)
            {
                _room = new AddDinner(_room);
                DisplayPrice();
            }
            else if (checkBoxDinner.Checked == false)
            {
                _room = new RemoveDinner(_room);
                DisplayPrice();
            }
        }

        public void DisplayPrice()
        {
            
            lblTotalPrice.Text = _room.getPrice().ToString();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        
            if (radioButtonDeluxe.Checked || radioButtonStandard.Checked || checkBoxBreakfast.Checked || checkBoxDinner.Checked)
            {
                total = lblTotalPrice.Text;
                CustomerDetails customerDetails = new CustomerDetails();
                customerDetails.Show();

            }
            else
            {
                MessageBox.Show("Please enter a package");
            }
        }

        private void RoomBuilder_Load(object sender, EventArgs e)
        {
            radioButtonStandard.Checked = true;
        }
    }
}
