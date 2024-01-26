using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        // instead of being dependent on a concrete implementation of the shipping calculator class, we are now dependent on an interface.
        // this is called dependency injection.

        public OrderProcessor(IShippingCalculator shpcalc)
        {
            // instead of creating a new object of shipping calculator here we need to initialize this field using the constructor.
            // _shippingCalculator = new ShippingCalculator();
            // so we pass in the IShippingCalculator interface as a parameter to the constructor.
            _shippingCalculator = shpcalc;
            // here we are just referencing it to an interface.
            // this makes it loose coupling.
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }

        // in this class there is a problem. 
        // when we unit test something, we want to test only one particular component. We don't want to involve other components.
        // in this case, we are testing the OrderProcessor class, but we are also testing the ShippingCalculator class.
        // or in simple words, the processor class we have tight coupling with the ShippingCalculator class.
        // shipping calculator is instantiated inside the constructor of the OrderProcessor class.
        // because of this tight coupling, we cannot test the Process method in isolation.
        // in unit testing this becomes a problem because we want to test only one component at a time.
        // go to shipping calc class and make it an interface.

    }
}

