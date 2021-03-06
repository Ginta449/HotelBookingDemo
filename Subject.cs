using HotelBMG2.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBMG2
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string PromoCode { get; set; }
        private DateTime expDate { get; set; }

        public Subject(string code, DateTime expires)
        {
            PromoCode = code;
            expDate = expires;
        }

        public string getPromoCode()
        {
            return PromoCode;
        }

        public void setPromoCode(string promo)
        {
            this.PromoCode = promo;

            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {

            Console.WriteLine();//added for testing purposes only
            foreach (IObserver observer in observers)
            {
                observer.update(PromoCode);//telling the program to notify all observers if the promocode is updated
            }
        }

    }
}
