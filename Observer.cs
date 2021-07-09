using HotelBMG2.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


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
            subject.RegisterObserver(this);
        }

        public Observer(string v, Subject promocode)
        {
            this.v = v;
            this.promocode = promocode;
        }

        public void update(string promocode)
        {
            
            string[] email = { "customeremail@email.com"};
           

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
