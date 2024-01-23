using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Promote()
        {
            Console.WriteLine("Promote logic changed");

            int res = CalculateRating();

            return res;
        }

        private int CalculateRating()
        {
            return 10;
        }

        protected int CalculateRatingProtected()
        {
            return 10;
        }
    }

    public class GoldCustomer: Customer
    {
        public void OfferVoucher()
        {
            this.Promote();
            // calculate rating is not accessible
            // this.CalculateRating();
            // this will throw an error
            Console.WriteLine( this.CalculateRatingProtected() );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
        }
    }
}