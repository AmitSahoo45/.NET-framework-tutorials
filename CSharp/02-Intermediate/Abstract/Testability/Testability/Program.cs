using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            // here we need to ship in the ShippingCalculator class.
            // this wont be expensive. It is perfectly fine to create an object of this class.
        }
    }
}
