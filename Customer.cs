using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//we added a customer class with the idea of storing customer object and object details into database
//however after further testing we decided not to go ahead with the database as we wanted the observer pattern to be simple and easy to understand
namespace HotelBMG2
{
    public class Customer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    
        public Customer(string n, string s, string a, string e, string p)
        {
            this.name = n;
            this.surname = s;
            this.address = a;
            this.email = e;
            this.phone = p;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    
}
