using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
