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
        public static string total = "";//declaring public static string at a class level to be able to retrieve the information from one form into another

        public RoomBuilder()
        {
            InitializeComponent(); 
        }

        IRoom _room = new StandardRoom();

        private void radioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBreakfast.Checked = false;//because for each checkbox and radio button we are using decorator pattern
            checkBoxDinner.Checked = false;//some validation needed to be put in place to make sure that the values are displayed correctly
            
            _room = new StandardRoom();
            DisplayPrice();
            checkBoxBreakfast.Enabled = true;
            checkBoxDinner.Enabled = true;
        }

        private void radioButtonDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            _room = new DeluxeRoom(_room);//calls the decorator class of deluxe room
            DisplayPrice();
            checkBoxBreakfast.Enabled = false;
            checkBoxDinner.Enabled = false;
        }

        private void checkBoxBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBreakfast.Checked)
            {
                _room = new AddBreakfast(_room);//decorator
                DisplayPrice();
            }
            else if (checkBoxBreakfast.Checked == false)
            {
                _room = new RemoveBreakfast(_room);//decorator
                DisplayPrice();
            }
        }

        private void checkBoxDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDinner.Checked)
            {
                _room = new AddDinner(_room);//decorator
                DisplayPrice();
            }
            else if (checkBoxDinner.Checked == false)
            {
                _room = new RemoveDinner(_room);//decorator
                DisplayPrice();
            }
        }

        public void DisplayPrice()
        {
            
            lblTotalPrice.Text = _room.getPrice().ToString();//displays the original price
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        
            if (radioButtonDeluxe.Checked || radioButtonStandard.Checked || checkBoxBreakfast.Checked || checkBoxDinner.Checked)
            {
                total = lblTotalPrice.Text;
                CustomerDetails customerDetails = new CustomerDetails();
                customerDetails.Show();//opens the customer detail form

            }
            else
            {
                MessageBox.Show("Please enter a package");
            }
        }

        private void RoomBuilder_Load(object sender, EventArgs e)
        {
            radioButtonStandard.Checked = true;//to ensure users are not able to crash the program or get the wrong values we set the standard radio button to selected
        }
    }
}
