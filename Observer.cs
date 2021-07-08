using HotelBMG2.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//we were struggling for a while to find a way to implement observer pattern into realistic and effiecient manner
//after a while we were able to add usersname(email) as our observer and once promotional deal is posted all the users in database (represented by hard codes array)
//receive an email of the new promotion posted by hotel
namespace HotelBMG2
{
    class Observer : IObserver
    {
        private string v;
        private Subject promocode;

        public string UserName { get; set; }

        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);//registering the observer / username are the observers email
        }

        public Observer(string v, Subject promocode)
        {
            this.v = v;
            this.promocode = promocode;
        }

        public void update(string promocode)
        {
            //basically saying if new promocode is postede regster and update the observers in the array (username)
            string[] email = { "customeremail@email.com"};//we added user emails into array manually
            //to test ensure to put in your own emails. This array is a representation of how the email could be sent if the user emails were saved into a database

            for (int i = 0; i < email.Length; i++)
            {
                try
                {
                    var senderEmail = new MailAddress("youremail@email.com", "HotelDemo");
                    var receiverEmail = new MailAddress(email[i]);
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
                        Subject = "New Promo Deal",
                        Body = promocode
                    })


                    {
                        smtp.Send(mess);
                    }
                }
                catch
                {

                }

            }

        }
    }
}
